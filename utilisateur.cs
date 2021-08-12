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
    public partial class utilisateur : Form
    {
        private List<Utilisateur> _users = new List<Utilisateur>();
        private Utilisateur _myUser = new Utilisateur();
        private string _previousUserName="";
        private string _password = "";
        private string _numTlf = "";
        private bool _previousEstAdmin;
        private int _userId = 0;
        public utilisateur()
        {
            InitializeComponent();
        }
        private void SetUpTable()
        {
            _users = GestionnaireProRetreivingMethods.GetAllUtilisateurs().Result;
            userTable.AutoGenerateColumns = false;
            userTable.DataSource = _users;
            userTable.Refresh();
        }
        private void AddUtilisateur()
        {
            _myUser = new Utilisateur
            {
                nomUtilisateur = username_txt.Text,
                motDePass = pass_txt.Text,
                numTlf = numTlf_txt.Text,
                estAdmin = estAdmin.Checked


            };
            GestionnaireProInsertingMethods.AddUtilisateur(_myUser);
        }
        private void ModifyUtilisateur()
        {
            _myUser = new Utilisateur
            {
                Id=_userId,
                nomUtilisateur = username_txt.Text,
                motDePass = pass_txt.Text,
                numTlf = numTlf_txt.Text,
                estAdmin = estAdmin.Checked


            };
            GestionnaireProModifyDeleteMethods.ModifyUserInfos(_myUser);
        }
        private void CleanBoxes()
        {
            username_txt.Text = "";
            pass_txt.Text = "";
            numTlf_txt.Text = "";
            estAdmin.Checked = false;
        }
        private int  SearchForUserName()
        {
            //remove the user from list to search it for new entry 
            if (_previousUserName == "") return -1;
            var previousUserNameIndex = _users.FindIndex(u => u.nomUtilisateur == _previousUserName);

            var myUser = _users[previousUserNameIndex];
            _users.RemoveAt(previousUserNameIndex);
            
            var currentUserNameIndex = _users.FindIndex(u => u.nomUtilisateur == username_txt.Text);
            _users.Insert(previousUserNameIndex, myUser);

            return currentUserNameIndex;
           
        }
        private void utilisateur_Load(object sender, EventArgs e)
        {
            
            SetUpTable();
        }
        private void modify_btn_Click(object sender, EventArgs e)
        {
            
            GlobalClass.typeOp = 1;
            var selectedRow = userTable.SelectedRows[0].Index;

            username_txt.Text = userTable[usernameCol.Index, selectedRow].Value.ToString();
            if (userTable[passCol.Index, selectedRow].Value != null)
            {
                pass_txt.Text = userTable[passCol.Index, selectedRow].Value.ToString();
            }

            numTlf_txt.Text = userTable[numCol.Index, selectedRow].Value.ToString();
            if ((bool)userTable[AdminCol.Index, selectedRow].Value == true)
                estAdmin.Checked = true;

            //set the id of the user to modify 
            _userId = _users.Find(u => u.nomUtilisateur == username_txt.Text).Id;

            _previousUserName = username_txt.Text;
            _password = pass_txt.Text;
            _numTlf = numTlf_txt.Text;
            _previousEstAdmin = estAdmin.Checked;
        }
        private void sub_btn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(username_txt.Text.Trim()) || string.IsNullOrEmpty(pass_txt.Text.Trim()))
            {
                MessageBox.Show("Remlissez le champ nom d'utilisateur et le mot de passe avant d'effectué cette Opération");
                return;
            }
          
           

            if (GlobalClass.typeOp == 0)
            {
                if(SearchForUserName() != -1)
                {
                    MessageBox.Show("Nom d'utilisateur Déja existe");
                    CleanBoxes();
                    return;
                }
                AddUtilisateur();
               
            }
            if (GlobalClass.typeOp == 1)
            {
                if (SearchForUserName() != -1 && _password == pass_txt.Text && _numTlf == numTlf_txt.Text && _previousEstAdmin == estAdmin.Checked )
                {
                    MessageBox.Show("Nom d'utilisateur Déja existe");
                    CleanBoxes();
                    return;
                }

                ModifyUtilisateur();
                GlobalClass.typeOp = 0;
            }

            CleanBoxes();
            SetUpTable();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (_users.Count <= 1)
            {
                MessageBox.Show("Impossible de supprimer si Seulement un utilisateur Exist !!!","Attention",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if ( userTable.SelectedRows[0].Index == -1) return;   
            GestionnaireProModifyDeleteMethods.DeleteUser((int)userTable[idCol.Index, userTable.SelectedRows[0].Index].Value);
            SetUpTable();
        }
    }
}
