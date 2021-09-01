using Gestionnaire_Pro.DataBase.DataBaseMethods;
using Gestionnaire_Pro.DataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    public partial class ajoutCreditClient : Form
    {
        
        private List<Client> _mesClients= new List<Client>();
        private float creditActuel = 0.0f;
        public ajoutCreditClient()
        {
            InitializeComponent();
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


            var nouveauCredit = _mesClients.Find(c => c.nom == client_combo.Text).credit + (Convert.ToSingle(creditAjout_txt.Text));
            var clientId = _mesClients.Find(c => c.nom == client_combo.Text).Id;

            GestionnaireProModifyDeleteMethods.SetClientCredit(clientId, nouveauCredit);
        }
        private void ajoutCredit_Load(object sender, EventArgs e)
        {
            RefreshThePage();
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            SubmitOperation();
            CleanTheBoxes();
            RefreshThePage();
           
        }

        private void client_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            creditActuel=_mesClients[client_combo.SelectedIndex].credit;
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
             

            creditInit_txt.Text = (creditActuel + Convert.ToSingle(addedString)).ToString();
        }

        private void creditAjout_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e,creditAjout_txt);
        
        }

        private void details_btn_Click(object sender, EventArgs e)
        {
            if (client_combo.Text == "")
            {
                MessageBox.Show("Séléctionner un Client avant d'ajouter les details de Crédit");
                return;
            }
            using (var c = new ajoutCreditDetail(_mesClients.Find(c => c.nom == client_combo.Text).Id))
            {
                c.ShowDialog();
                var newCredit = Convert.ToSingle(creditInit_txt.Text) + c.AddedCredit;
                GestionnaireProModifyDeleteMethods.SetClientCredit(_mesClients.Find(c => c.nom == client_combo.Text).Id,newCredit);
                CleanTheBoxes();
                RefreshThePage();
            } 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void creditInit_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
