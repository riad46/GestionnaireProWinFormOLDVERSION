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
        private int _id;
        private string descriptionAction = "";
        public ajouteClient()
        {
            InitializeComponent();
            LoadTheme();
        }
        public ajouteClient(Client client)
        {
            InitializeComponent();
            LoadTheme();
            _id = client.Id;
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
        private void ActionToDo()
        {
            if (string.IsNullOrEmpty(credit_txt.Text))
            {
                credit_txt.Text = "0,00 ";
            }

            var client = new Client
            {
                nom = nom_txt.Text,
                numTlf = numTlf_txt.Text.Replace(" ", string.Empty),
                address = address_txt.Text,
                credit = Convert.ToSingle(credit_txt.Text)
            };
            switch (GlobalClass.typeOp)
            {
                case 0:
                    DataBase.DataBaseMethods.GestionnaireProInsertingMethods.AddClient(client);
                    descriptionAction = $"{GlobalClass.username} a Ajouté Le Client {nom_txt.Text} avec {credit_txt} DA de Credit";
                    MessageBox.Show("Client a été ajouter avec Succée");
                    break;

                case 1:
                    client.Id = _id;
                    DataBase.DataBaseMethods.GestionnaireProModifyDeleteMethods.ModifyClientInfos(client);
                    descriptionAction = $"{GlobalClass.username} a Modifier Le Client {nom_txt.Text} avec {credit_txt} DA de Credit";
                    MessageBox.Show("Client a été Modifier avec Succée");
                    break;
            }
            cleanBoxes();

        }
        private void sub_btn_Click(object sender, EventArgs e)
        {
            ActionToDo();
             
            GlobalClass.AddAction(descriptionAction);
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
