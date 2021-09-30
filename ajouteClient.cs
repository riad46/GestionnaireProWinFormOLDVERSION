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
    public partial class ajouteClient : Form
    {
        private List<Client> _mesClients = GestionnaireProRetreivingMethods.GetAllClients().Result;
        private int _id;
        private string descriptionAction = "";
        public ajouteClient()
        {
            InitializeComponent();
            LoadTheme();
            if (Properties.Settings.Default.autoNumRegistre)
            {
                numRegistre_txt.Enabled = false;
                AutoGenerateNumRegistre();
            }
        }
        public ajouteClient(Client client)
        {
            InitializeComponent();
            LoadTheme();
            _id = client.Id;
            numRegistre_txt.Text = client.numRegistre;
            nom_txt.Text = client.nom;
            address_txt.Text = client.address;
            numTlf_txt.Text = client.numTlf;
            credit_txt.Text = client.credit.ToString();
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
        private void AddClient(Client client)
        {
            DataBase.DataBaseMethods.GestionnaireProInsertingMethods.AddClient(client);
            descriptionAction = $"Ajouté Le Client {nom_txt.Text} avec {credit_txt} DA de Credit";
            MessageBox.Show("Client a été ajouter avec Succée");
        }
        private void ModifyClient(Client client)
        {
            DataBase.DataBaseMethods.GestionnaireProModifyDeleteMethods.ModifyClientInfos(client);
            descriptionAction = $"Modifier Le Client {nom_txt.Text} avec {credit_txt} DA de Credit";
            MessageBox.Show("Client a été Modifier avec Succée");
        }
        private void ActionToDo()
        {
            if (string.IsNullOrEmpty(credit_txt.Text))
            {
                credit_txt.Text = "0,00 ";
            }

            var client = new Client
            {
                numRegistre=numRegistre_txt.Text,
                nom = nom_txt.Text,
                numTlf = numTlf_txt.Text.Replace(" ", string.Empty),
                address = address_txt.Text,
                credit = Convert.ToSingle(credit_txt.Text)
            };
         
            switch (GlobalClass.typeOp)
            {
                case 0:
                    AddClient(client);
                    GlobalClass.AddAction(GlobalClass.username, descriptionAction);
                    cleanBoxes();
                    break;

                case 1:
                    client.Id = _id;
                    if(_mesClients.FindIndex(c => c.numRegistre == numRegistre_txt.Text) != -1)
                    {
                        MessageBox.Show(this,"Ce Numéro de Registre Exist Déja Attention !!!!!!!!!!","ATTENTION",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                    ModifyClient(client);
                    GlobalClass.AddAction(GlobalClass.username, descriptionAction);
                    cleanBoxes();
                    break;
            }
           

        }
        private void sub_btn_Click(object sender, EventArgs e)
        {
            ActionToDo();
            if (Properties.Settings.Default.autoNumRegistre)
            {
                AutoGenerateNumRegistre();
            }
            
           
        }
        private void AutoGenerateNumRegistre()
        {
           
            Random r = new Random();
            var numRegistre = r.Next(1111111, 12345678);
            while (_mesClients.FindIndex(c => c.numRegistre == numRegistre.ToString()) != -1)
            {
                numRegistre = r.Next(1111111, 12345678);
            }
            numRegistre_txt.Text = numRegistre.ToString();
        }
        private void cleanBoxes()
        {
            address_txt.Text = "";
            nom_txt.Text = "";
            numTlf_txt.Text = "";
            credit_txt.Text = "";
        }
        private void credit_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e,credit_txt);
        }
    }
}
