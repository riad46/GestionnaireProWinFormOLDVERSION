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
    public partial class revenue : Form
    {
        private float _totalPaye = 0;
        private float _totalAchat = 0;
        private List<DetailVente> _mesArticles = new List<DetailVente>(); 
        public revenue()
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


            revenueTable.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            revenueTable.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;
            revenueTable.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
        }

        private void SearchForRevenue()
        {
            _mesArticles = GestionnaireProRetreivingMethods.GetAllDetailVentes(GestionnaireProRetreivingMethods.GetVenteIds(dateMin_box.Value, dateMax_box.Value).Result).Result;
            ProcessFinalList();
            SetUpTable(_mesArticles);
        }
        private void SetUpTable(List<DetailVente> detailVentes)
        {
            var bindingArticlesList = new BindingList<DetailVente>(detailVentes);
            var source = new BindingSource(bindingArticlesList, null);

            revenueTable.AutoGenerateColumns = false;
            revenueTable.DataSource = source;
            totalPaye_lbl.Text = _totalAchat.ToString() + " DA";
            revTotal_lbl.Text = _totalPaye.ToString() + " DA";
            revNet_lbl.Text = (_totalPaye-_totalAchat).ToString() + " DA";

            int i = 0;
            foreach (var item in detailVentes)
            {
                revenueTable[total_Col.Index, i].Value = item.prixVente;
                i++;
            }
        }
        private void ProcessFinalList()
        {
            var result = new List<DetailVente>();
            var totalPayedForItems = new List<float>();
            
            if (_mesArticles.Count == 0) return;
            //remove duplicates
            foreach (var item in _mesArticles)
            {
                var myItemIndex = result.FindIndex(d => d.nom == item.nom);
                if (myItemIndex == -1)
                {
                    item.prixAchat = item.prixAchat * item.Quantité;
                    result.Add(item);
                    totalPayedForItems.Add(item.prixVente);
                }
                else
                {
                    result[myItemIndex].Quantité += item.Quantité;
                    totalPayedForItems[myItemIndex] += item.prixVente ;
                    
                    result[myItemIndex].prixAchat += item.prixAchat * item.Quantité;
                }
              

            }
            //assign each total payed for their products
            for (int i = 0; i < result.Count; i++)
            {
                result[i].prixVente = totalPayedForItems[i];
            }

            //add filter by name and type 
           _mesArticles = new List<DetailVente>();
            foreach (var item in result)
            {
                if (string.IsNullOrEmpty(type_txt.Text.Trim()) && string.IsNullOrEmpty(nom_txt.Text.Trim()))
                {
                    _mesArticles = result;
                    break;
                }
                if(!string.IsNullOrEmpty(type_txt.Text.Trim()))
                {
                    if (!item.Type.Contains(type_txt.Text.Trim()))
                    {
                        continue;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(nom_txt.Text.Trim()))
                        {
                            if (!item.nom.Contains(nom_txt.Text.Trim()))
                            {
                                continue;
                            }
                            else
                            {
                                _mesArticles.Add(item);
                            }
                        }
                        else
                        {
                            _mesArticles.Add(item);
                        }
                    }

                }
                else if (!string.IsNullOrEmpty(nom_txt.Text.Trim()))
                {
                    if (!item.nom.Contains(nom_txt.Text.Trim()))
                    {
                        continue;
                    }
                    else
                    {
                        _mesArticles.Add(item);
                    }
                }
              
            }
            _totalPaye = 0;
            _totalAchat = 0;
          
            foreach (var item in _mesArticles)
            {
                //calculate total payed and revenue total 
                _totalPaye +=  item.prixVente;
                _totalAchat +=  item.prixAchat;
            }
          

        }
        private void revenue_Load(object sender, EventArgs e)
        {
            dateMax_box.Value = DateTime.Now;
            dateMin_box.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);

            SearchForRevenue();
            var descriptionAction = $" Entrée dans Revenue !!!!!!!!!!!!!!!!!!!!!!!!";
            GlobalClass.AddAction(GlobalClass.username,descriptionAction);
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            _totalPaye = 0;
            _totalAchat = 0;
            SearchForRevenue();
        }
    }
}
