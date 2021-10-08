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
    public partial class caisse : Form
    {
        List<Achat> _mesAchat = new List<Achat>();
        List<Vente> _mesVente = new List<Vente>();
        private float _totalAchat = 0;
        private float _totalVente = 0;
        private float _benificeNet = 0;
        private float _montantInitCaisse = 0;
        public caisse()
        {
            InitializeComponent();
            LoadTheme();
        }
        private void LoadTheme()
        {
            
                foreach (Control pan in Controls)
                {
                    pan.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.2);
                }

            achatTable.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            achatTable.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;
            achatTable.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;

            venteTable.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            venteTable.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;
            venteTable.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;

        }

        private void GetAchatVenteLists()
        {
            var dateMin = dateMin_box.Value;
            var dateMax = dateMax_box.Value;
            _mesAchat = GestionnaireProRetreivingMethods.GetAchatByFilter(dateMin, dateMax).Result;
            _mesVente = GestionnaireProRetreivingMethods.GetHistoriqueDeVenteByFilter(-1, -1, -1, dateMin, dateMax).Result;
        }
        private void SetUpTables()
        {

            if (_mesVente.Count>0)
            {
                foreach (var item in _mesVente)
                {
                    if (item.nouveauNetAPayé != null)
                        item.netPayé =(float) item.nouveauNetAPayé;
                }
            }
            achatTable.AutoGenerateColumns = false;
            achatTable.DataSource = _mesAchat;

            venteTable.AutoGenerateColumns = false;
            venteTable.DataSource = _mesVente;

        }
        private void ResetValues()
        {
          _mesAchat = new List<Achat>();
          _mesVente = new List<Vente>();
          _totalAchat = 0;
          _totalVente = 0;
          _benificeNet = 0;
          _montantInitCaisse = 0;

            totalAchat_txt.Text =  "0,00 DA";
            totalVente_txt.Text = "0,00 DA";
            benfice_txt.Text =  "0,00 DA";
            montantDansCaisse_txt.Text = "0,00 DA";

        }
        private void CalculateAll()
        {
            var listVenteIds = new List<int>();

            foreach (var item in _mesAchat)
            {
                _totalAchat += item.montantTotal;
            }

            foreach (var item in _mesVente)
            {
                _totalVente += item.netPayé;
                listVenteIds.Add(item.Id);
            
            }
            var detailsVente = GestionnaireProRetreivingMethods.GetAllDetailVentes(listVenteIds).Result;
            foreach (var item in detailsVente)
            {
                _benificeNet += (item.prixVente - item.prixAchat) * item.Quantité;
            }

            if (! string.IsNullOrEmpty( montantInitCaisse_txt.Text))
                _montantInitCaisse =Convert.ToSingle(montantInitCaisse_txt.Text);
            


        }
        private void PutValuesInBoxes()
        {
            totalAchat_txt.Text = _totalAchat + " DA";
            totalVente_txt.Text = _totalVente + " DA";
            benfice_txt.Text = _benificeNet + " DA";
            montantDansCaisse_txt.Text = (_totalVente - _totalAchat + _montantInitCaisse).ToString() + " DA";
        }
        private void caisse_Load(object sender, EventArgs e)
        {
            dateMin_box.Value = DateTime.Now;
            dateMax_box.Value = DateTime.Now;

            GetAchatVenteLists();    
            SetUpTables();
            CalculateAll();
            PutValuesInBoxes();
            var descriptionAction = $" Entrée dans la Caisse !!!!!!!!!!!!!!!!!!!!!!!!";
            GlobalClass.AddAction(GlobalClass.username,descriptionAction);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            ResetValues();

            GetAchatVenteLists();
            SetUpTables();
            CalculateAll();
            PutValuesInBoxes();
        }

        private void montantInitCaisse_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e,montantInitCaisse_txt);
        }
    }
}
