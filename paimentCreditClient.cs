using Gestionnaire_Pro.DataBase.DataBaseMethods;
using Gestionnaire_Pro.DataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    public partial class paimentCreditClient : Form
    {
        private float creditActuel = 0;
        private List<Client> _mesClients = new List<Client>();
        private List<DetailCreditClient> _mesDetailsClient = new List<DetailCreditClient>();
        public paimentCreditClient()
        {
            InitializeComponent();
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (var item in Controls)
            {
                if (item.GetType() == new Button().GetType())
                {
                    ((Button)item).BackColor = ThemeColor.PrimaryColor;
                    ((Button)item).ForeColor = Color.White;
                }
            }
        }
        private void GetClients()
        {
            _mesClients = GestionnaireProRetreivingMethods.GetAllClients().Result;
        }
        private void SetTheBoxes()
        {
            foreach (var item in _mesClients)
            {
                client_combo.Items.Add(item.nom);
            }

        }
        private void RefreshThePage()
        {
            CleanTheBoxes();
           
            //Refresh
            GetClients();
            SetTheBoxes();
        }
        private void CleanTheBoxes()
        {
            client_combo.Text = "";
            client_combo.Items.Clear();
            creditInit_txt.Text = "0.0";
            creditAjout_txt.Text = "0.0";
        }
        private void SearchClientDetails()
        {
            var SelectedRow_ClientId = _mesClients[client_combo.SelectedIndex].Id ;
            _mesDetailsClient = GestionnaireProRetreivingMethods.GetDetailsCreditClient(SelectedRow_ClientId).Result;
        }
        private void SubmitOperation()
        {
            creditActuel = 0.0f;
            if (client_combo.Text == "")
            {
                MessageBox.Show("Séléctionné un Client avant d'Effectué l'opération");
                return;
            }
            if (Convert.ToSingle(creditAjout_txt.Text.Replace('.', ',')) <= 0)
            {
                MessageBox.Show("Le Credit Ajouté doit être Supérieur a 0");
                return;
            }


            var nouveauCredit = Convert.ToSingle(creditInit_txt.Text);
            var clientId = _mesClients.Find(c => c.nom == client_combo.Text).Id;

            if (nouveauCredit==0)
            {
                GestionnaireProModifyDeleteMethods.DeleteDetailCreditClient(clientId);
            }
            else
            {
                var myPaiment = Convert.ToSingle(creditAjout_txt.Text);
                var theCreditTotal = 0.0f;
                SearchClientDetails();
                foreach (var item in _mesDetailsClient)
                {
                    theCreditTotal = item.restApayé;
                    item.restApayé -= myPaiment;
                    myPaiment -= theCreditTotal;
                    
                    if (item.restApayé <= 0) 
                    {
                        item.estPayé = true;
                        item.restApayé = 0;
                    }
                    if (myPaiment <= 0) break ;
                }
                GestionnaireProModifyDeleteMethods.ModifyDetailCreditClient(_mesDetailsClient);
            }

            GestionnaireProModifyDeleteMethods.SetClientCredit(clientId, nouveauCredit);
        }



        private void sub_btn_Click(object sender, EventArgs e)
        {
            SubmitOperation();
            RefreshThePage();
            var descriptionAction = $"{GlobalClass.username} a Payé <<{creditAjout_txt}>> du  Credit de {client_combo.Text}";
            GlobalClass.AddAction(descriptionAction);
        }

        private void paimentCreditClient_Load(object sender, EventArgs e)
        {
            RefreshThePage();
        }
        private void client_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            creditActuel = _mesClients[client_combo.SelectedIndex].credit;
            creditInit_txt.Text = creditActuel.ToString();
        }

        private void creditAjout_txt_TextChanged(object sender, EventArgs e)
        {
            var addedString = "";
            if (creditAjout_txt.Text == "" || string.IsNullOrWhiteSpace(creditAjout_txt.Text) || creditAjout_txt.Text.Trim() == ",")
            {
                creditInit_txt.Text = creditActuel.ToString();
                return;
            }
            if (creditAjout_txt.Text.IndexOfAny(new char[] { '.', ',' }) > -1)
            {
                addedString = creditAjout_txt.Text.Replace('.', ',');
            }
            else
            {
                addedString = creditAjout_txt.Text;
            }

            var currentCredit = (creditActuel - Convert.ToSingle(addedString));
            if(currentCredit > 0) 
            {
                
                creditInit_txt.Text = currentCredit.ToString();
            }
            else
            {
                creditActuel = 0;
                creditInit_txt.Text = creditActuel.ToString();

            }
            
        }

        private void creditAjout_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e, creditAjout_txt);

        }

    }
}
