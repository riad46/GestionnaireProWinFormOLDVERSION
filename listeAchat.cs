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
    public partial class listeAchat : Form
    {
        List<Achat> _mesAchat = new List<Achat>();
        List<DetailAchat> _mesDetailsAchat = new List<DetailAchat>();
        public listeAchat()
        {
            InitializeComponent();
        }

       

        private void listeAchat_Load(object sender, EventArgs e)
        {
            _mesAchat = GestionnaireProRetreivingMethods.GetAllAchatsWithDetails().Result;
            achatTable.AutoGenerateColumns = false;
            achatTable.DataSource = _mesAchat;
            achatTable.Refresh();

        }

        private void achatTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_mesAchat.Count > 0)
            {
                if (achatTable.SelectedRows.Count > 0)
                {
                    var achatId = Convert.ToInt32(achatTable[0, achatTable.SelectedRows[0].Index].Value);
                    if (achatId != -1)
                    {
                        _mesDetailsAchat = (List<DetailAchat>)_mesAchat.Find(a => a.Id == achatId).DetailAchats;
                        detailsTable.AutoGenerateColumns = false;
                        detailsTable.DataSource = _mesDetailsAchat;
                       //fournisseur
                       
                        for(int i=0;i<_mesDetailsAchat.Count;i++)
                        {
                            if (_mesDetailsAchat[i].fournisseur!=null)
                                detailsTable[8, i].Value = _mesDetailsAchat[i].fournisseur.nom;
                        }
                    }
                }


            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e, montant_txt);
        }
    }
}
