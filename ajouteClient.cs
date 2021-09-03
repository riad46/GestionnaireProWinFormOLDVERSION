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
        public ajouteClient()
        {
            InitializeComponent();
        }
        public ajouteClient(Client client)
        {
            InitializeComponent();
            _id = client.Id;
            nom_txt.Text = client.nom;
            address_txt.Text = client.address;
            numTlf_txt.Text = client.numTlf;
            credit_txt.Text = client.credit.ToString();
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
                    MessageBox.Show("Client a été ajouter avec Succée");
                    break;

                case 1:
                    client.Id = _id;
                    DataBase.DataBaseMethods.GestionnaireProModifyDeleteMethods.ModifyClientInfos(client);
                    MessageBox.Show("Client a été Modifier avec Succée");
                    break;
            }

        }
        private void sub_btn_Click(object sender, EventArgs e)
        {
            ActionToDo();
        }

        private void ajouteClient_Load(object sender, EventArgs e)
        {

        }

        private void credit_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e,credit_txt);
        }
    }
}
