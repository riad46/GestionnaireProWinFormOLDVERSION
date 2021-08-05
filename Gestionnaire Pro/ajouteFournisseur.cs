﻿using Gestionnaire_Pro.DataBase.Models;
using System;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    public partial class ajouteFournisseur : Form
    {
        private int _id;
        public ajouteFournisseur()
        {
            InitializeComponent();
        }
        public ajouteFournisseur(Fournisseur fournisseur)
        {
            InitializeComponent();
            _id = fournisseur.Id;
            nom_txt.Text = fournisseur.nom;
            address_txt.Text = fournisseur.Address;
            numTlf_txt.Text = fournisseur.numTlf;
            credit_txt.Text = fournisseur.creditArendre.ToString();
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            ActionToDo();
            EmptyAllEntryBoxes();
        }
        private void EmptyAllEntryBoxes()
        {
            nom_txt.Text = "";
            credit_txt.Text = "";
            address_txt.Text = "";
            numTlf_txt.Text = "";
        }
       private void ActionToDo()
        {
            if (string.IsNullOrEmpty(credit_txt.Text))
            {
                credit_txt.Text = "0,00 ";
            }

            var fournisseur = new Fournisseur
            {
                nom = nom_txt.Text,
                numTlf = numTlf_txt.Text.Replace(" ", string.Empty),
                Address = address_txt.Text,
                creditArendre = Convert.ToSingle(credit_txt.Text)
            };
            switch (GlobalClass.typeOp)
            {
                case 0:      
                    DataBase.DataBaseMethods.GestionnaireProInsertingMethods.AddFournisseur(fournisseur);
                    MessageBox.Show("Fournisseur a été ajouter avec Succée");
                    break;
              
                case 1:
                   fournisseur.Id = _id;
                    DataBase.DataBaseMethods.GestionnaireProModifyDeleteMethods.ModifyFournisseurInfos(fournisseur);
                    MessageBox.Show("Fournisseur a été Modifier avec Succée");
                    break;
            }

        }
       
    }
}
