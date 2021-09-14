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
    public partial class ajoutFacture : Form
    {
        private int _venteId = 0;
        private List<Article> _mesArticles = new List<Article>();
        private List<Article> _mesArticleAvendre = new List<Article>();
        private readonly int _codeBarreIndex = 0;
        private readonly int _qntIndex = 2;
        private readonly int _prixVenteIndex = 3;
        private readonly int _remiseIndex = 4;
        private readonly int _totalIndex = 5;

        private int currentlySelectedRow = 0;
    
        private float total = 0;
        private float totalRemise = 0;
        private int nbrArticle = 0;
        private float nbrPiece = 0;


        public ajoutFacture()
        {
            InitializeComponent();
            LoadTheme();
        }
        private void LoadTheme()
        {

            foreach (Control pan in Controls)
            {
                if (pan.Name != "panel1")
                    pan.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.2);

            }

            venteTable.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            venteTable.DefaultCellStyle.SelectionBackColor = ThemeColor.SecondaryColor;
            venteTable.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
        }
        private void ajoutFacture_Load(object sender, EventArgs e)
        {
            if (GlobalClass.typeOp == 1)
            {
                SetUpTable();
            }
            AddClientsToCombo();
        }
        private int GetCurrentSelectedTableRow()
        {
            if (venteTable.RowCount > 0)
                return venteTable.SelectedRows[0].Index;
            return -1;
        }
        private string GetCurrentSelectedTableRow_CodeBarre()
        {
            return venteTable[codeBarreCol.Index, venteTable.SelectedRows[0].Index].Value.ToString();
        }
     
        private void AddClientsToCombo()
        {
            var mesClients = GestionnaireProRetreivingMethods.GetAllClients().Result;
            foreach (var client in mesClients)
            {
                client_combo.Items.Add(client.nom);
            }


        }

        private void SetUpTable()
        {
            var bindingArticlesList = new BindingList<Article>(_mesArticleAvendre);
            var source = new BindingSource(bindingArticlesList, null);

            venteTable.AutoGenerateColumns = false;
            venteTable.DataSource = source;
            venteTable.Refresh();
            if (venteTable.RowCount > 0)
                for (int i = 0; i < venteTable.RowCount; i++)
                {
                    if (string.IsNullOrEmpty((string)venteTable.Rows[i].Cells[_remiseIndex].Value)) venteTable.Rows[i].Cells[_remiseIndex].Value = 0.0f;
                }
            CalculateAll();
            
        }
        private void SetCodeBarre()
        {
            if (venteTable.RowCount > 0 && venteTable.SelectedRows.Count > 0)
                if (venteTable[_codeBarreIndex, venteTable.SelectedRows[0].Index].Value != null)
                    codeBarreLabel.Text = venteTable[_codeBarreIndex, venteTable.SelectedRows[0].Index].Value.ToString();
        }
        private void CalculateAll()
        {
            total = 0;
            totalRemise = 0;
            nbrPiece = 0;

            for (int i = 0; i < venteTable.Rows.Count; i++)
            {
                venteTable.Rows[i].Cells[_totalIndex].Value = (Convert.ToSingle(venteTable.Rows[i].Cells[_qntIndex].Value) * Convert.ToSingle(venteTable.Rows[i].Cells[_prixVenteIndex].Value)) - (Convert.ToSingle(venteTable.Rows[i].Cells[_remiseIndex].Value) * Convert.ToSingle(venteTable.Rows[i].Cells[_qntIndex].Value));
                total += (float)venteTable.Rows[i].Cells[_totalIndex].Value;


                totalRemise += Convert.ToSingle(venteTable.Rows[i].Cells[_remiseIndex].Value);

                nbrPiece += Convert.ToSingle(venteTable.Rows[i].Cells[_qntIndex].Value);
            }

            PutValuesInTitles(total, nbrArticle, nbrPiece);

        }
        private void PutValuesInTitles(float total, int nbrArticle, float nbrPiece)
        {
            totalLabel.Text = total + " DA";
            nbrArticleLabel.Text = "Articles :" + nbrArticle;
            nbrPieceLabel.Text = "Pieces :" + nbrPiece;
        }
       
        private Article SearchForArticle(string codeBarre)
        {

            var res = GestionnaireProRetreivingMethods.GetArticleForVente(codeBarre).Result;
            return res;
        }
        private void codeBarre_txt_TextChanged(object sender, EventArgs e)
        {
            if (codeBarre_txt.Text.Length > 0)
            {
                var monArticle = SearchForArticle(codeBarre_txt.Text);
                if (monArticle != null)
                {
                    var monArticleSearch = _mesArticleAvendre.Find(a => a.codeBarre == monArticle.codeBarre);

                    if (monArticleSearch == null)
                    {
                        if (monArticle.quantité > 0)
                        {
                            GestionnaireProModifyDeleteMethods.SetArticleQnt(monArticle.Id, monArticle.quantité - 1);
                            monArticle.quantité = 1;
                            _mesArticleAvendre.Add(monArticle);
                            nbrArticle++;
                        }
                        else
                        {
                            MessageBox.Show("Quantité Insuffisant !!");
                            return;
                        }

                    }
                    else
                    {
                        if (monArticle.quantité > 0)
                        {
                            _mesArticleAvendre[_mesArticleAvendre.IndexOf(monArticleSearch)].quantité += 1;
                            GestionnaireProModifyDeleteMethods.SetArticleQnt(monArticle.Id, monArticle.quantité - 1);
                        }
                        else
                        {
                            MessageBox.Show("Quantité Insuffisant !!");
                        }
                    }

                    codeBarre_txt.Text = "";
                    SetUpTable();
                }
            }

        }
        private void venteTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            SetCodeBarre();
        }
        private void AbortVente()
        {
            _mesArticleAvendre = new List<Article>();
            SetUpTable();
        }
        private void abort_btn_Click(object sender, EventArgs e)
        {

            AbortVente();
        }
        private void DeleteCurrentSelectedRow()
        {

            var myRow = GetCurrentSelectedTableRow();
            if (myRow == -1) return;

           
            var myArticleIndex = _mesArticleAvendre.FindIndex(a => a.codeBarre == GetCurrentSelectedTableRow_CodeBarre());
            _mesArticleAvendre.RemoveAt(myArticleIndex);
            SetUpTable();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            DeleteCurrentSelectedRow();
        }

        private void remise_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass.CheckForInputToBeNumbers(e, remise_txt);
        }


        private void QNT_KeyPress(object sender, KeyPressEventArgs e, TextBox t1)
        {
            GlobalClass.CheckForInputToBeNumbers(e, t1);

        }


        private void venteTable_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {


            TextBox tb = new TextBox();
            e.Control.KeyPress -= new KeyPressEventHandler((sender, e) => QNT_KeyPress(sender, e, tb));
            if (venteTable.CurrentCell.ColumnIndex == _qntIndex || venteTable.CurrentCell.ColumnIndex == _remiseIndex || venteTable.CurrentCell.ColumnIndex == _totalIndex) //Desired Column
            {
                tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler((sender, e) => QNT_KeyPress(sender, e, tb));

                }
            }
        }
        private void AddToVenteFromListArticles(Article article)
        {

            var result = _mesArticleAvendre.FindIndex(a => a.nom == article.nom);
            if (result == -1)
            {
                _mesArticleAvendre.Add(article);
                return;
            }
            _mesArticleAvendre[result].quantité += 1;
        }
        private void listArticle_btn_Click(object sender, EventArgs e)
        {
            GlobalClass.typeOp = 10;
            using (var listArticle = new ListArticle(1))
            {
                listArticle.ShowDialog();
                if (listArticle.monArticle == null) return;
                if (listArticle.monArticle.nom != null)
                {
                    AddToVenteFromListArticles(listArticle.monArticle);
                    _mesArticles = GestionnaireProRetreivingMethods.GetAllArticles().Result;
                    SetUpTable();
                }
            }
        }

        private void AddFacture()
        {
            if (remise_txt.Text == "") remise_txt.Text = "0";
            totalRemise += Convert.ToSingle(remise_txt.Text);
            var maFacture = new Facture()
            {
                ajouterPar = GlobalClass.username,
                dateFacture = DateTime.Now,
                montantTotale = total,
                remise = totalRemise,
                netPayé = total - totalRemise

            };
            if (!string.IsNullOrWhiteSpace(client_combo.Text) && client_combo.Text != "")
            {
                maFacture.clientId = GestionnaireProRetreivingMethods.GetClientIdByName(client_combo.Text).Result;
            }
            GestionnaireProInsertingMethods.AddFacture(maFacture);
        
        }
    
        private void AddDetailsFacture()
        {
            var factureId = GestionnaireProRetreivingMethods.RetreiveLastInsertedRowId("factures").Result;
            var details = new List<DetailsFacture>();
            int i = 0;
            foreach (var item in _mesArticleAvendre)
            {

                details.Add(new DetailsFacture
                {
                    codeBarre = item.codeBarre,
                    nom = item.nom,
                    Type = item.type,
                    prixAchat = item.prixAchat,
                    prixVente = item.prixVente * item.quantité,
                    Quantité = item.quantité,
                    remise = Convert.ToSingle(venteTable.Rows[i].Cells[_remiseIndex].Value),
                    factureId = factureId

                });
                i++;
            }
            GestionnaireProInsertingMethods.AddDetailsFacture(details);
        }
        private void sub_btn_Click(object sender, EventArgs e)
        {
            if (_mesArticleAvendre.Count == 0)
            {
                return;
            }
            if (GlobalClass.typeOp == 1)
            {
                //Only Print the Facture
                return;
            }
            
            AddFacture();
            AddDetailsFacture();
            _mesArticleAvendre = new List<Article>();
            SetUpTable();
        }
    }
}
