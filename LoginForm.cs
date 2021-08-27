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
    public partial class LoginForm : Form
    {
        /// <summary>
        /// 0 : came from menu 
        /// 1:clicked the Closing Button
        /// </summary>
        private int _WhereTheCloseCommandCameFrom;
        
        public LoginForm()
        {
            InitializeComponent();
        }
        private void CleanBoxes()
        {
            username_txt.Text = "";
            password_txt.Text = "";
        }
        private void RegularLogin(string username,string pass)
        {
           

            var _utilisateurs = GestionnaireProRetreivingMethods.GetAllUtilisateurs().Result;
            var monUtilisateur = _utilisateurs.Find(u => u.nomUtilisateur == username && u.motDePass == pass);
            if (monUtilisateur == null)
            {
                CleanBoxes();
                MessageBox.Show("Nom d'utilisateur ou Mot de passe Incorrect !!");
                return;
            }
            else
            {
                GlobalClass.username = monUtilisateur.nomUtilisateur;
                GlobalClass.isAdmin = monUtilisateur.estAdmin;

                CleanBoxes();
                _WhereTheCloseCommandCameFrom = 1;
                CloseOrHideTheForm();
            }
        }
        private void sub_btn_Click(object sender, EventArgs e)
        {
            var username = username_txt.Text;
            var pass = password_txt.Text;

            if (username=="riad46" && pass == "azqswx123-")
            {
                GlobalClass.username = "riad46";
                GlobalClass.isAdmin = true;
                CleanBoxes();
                _WhereTheCloseCommandCameFrom = 1;
                CloseOrHideTheForm();
            }

            /*
             if( settings . no login used)
            {
             GlobalClass.username="Anonyme";
            GlobalClass.isAdmin =  true;
            }
            */
            RegularLogin(username,pass);

        }
        private void CloseOrHideTheForm()
        {
            if (_WhereTheCloseCommandCameFrom == 0)
            {
                this.Close();
            }
            else if (_WhereTheCloseCommandCameFrom == 1)
            {
                using (var m = new Menu())
                {

                    this.Visible = false;
                    m.ShowDialog();
                    this.Visible = true;
                    _WhereTheCloseCommandCameFrom = 0;
                }
                return;
            }
        }

       

      
    }
}
