using Gestionnaire_Pro.DataBase.DataBaseMethods;
using Gestionnaire_Pro.DataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    public partial class vente : Form
    {
        private int _venteId=0;
        private List<Article> _mesArticles = new List<Article>();
        private List<Article> _mesArticleAvendre = new List<Article>();
        private readonly int _codeBarreIndex = 0;
        private readonly int _qntIndex = 2;
        private readonly int _prixVenteIndex = 3;
        private readonly int _remiseIndex = 4;
        private readonly int _totalIndex = 5;

        private int currentlySelectedRow = 0;
        private float ancientQnt = 0;
        private float total = 0;
        private float totalRemise = 0;
        private int nbrArticle = 0;
        private float nbrPiece = 0;

        public vente()
        {
            InitializeComponent();
            LoadTheme();
        }
        private void vente_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.venteLocation != new Point(0, 0))
                this.Location = Properties.Settings.Default.venteLocation;
            this.Size = Properties.Settings.Default.venteSize;

            if (GlobalClass.typeOp == 1)
            {
                SetUpTable();
            }
            AddClientsToCombo();
            _mesArticles = GestionnaireProRetreivingMethods.GetAllArticles().Result;
        }
        private void vente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.venteSize = this.Size;
            Properties.Settings.Default.venteLocation = this.Location;
            Properties.Settings.Default.Save();
            ResetArticlesStock();
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
        public vente(int venteId)
        {

            InitializeComponent();
            LoadTheme();
            _venteId = venteId;
            var mesArticle = GestionnaireProRetreivingMethods.GetAllDetailVentes(new List<int> { venteId }).Result;
            foreach (var item in mesArticle)
            {
                _mesArticleAvendre.Add(new Article
                {

                    Id = item.Id,
                    codeBarre = item.codeBarre,
                    nom = item.nom,
                    prixAchat = item.prixAchat,
                    prixVente = item.prixVente,
                    quantité = item.Quantité,
                    type = item.Type

                });
                var client_Id = GestionnaireProRetreivingMethods.GetHistoriqueDeVenteByFilter(venteId, -1, -1, default, DateTime.Now).Result[0].clientId;
               if(client_Id !=null)
                client_combo.Text = GestionnaireProRetreivingMethods.GetClientNameById((int)client_Id).Result ;

            }


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
        private void ResetTable()
        {
            _mesArticleAvendre = new List<Article>();
            SetUpTable();
        }
        private void AddVente()
        {
            if (remise_txt.Text == "") remise_txt.Text = "0";
            totalRemise += Convert.ToSingle(remise_txt.Text);
            var monVente = new Vente()
            {
                ajouterPar = GlobalClass.username,
                dateVente = DateTime.Now,
                montantTotale = total,
                remise = totalRemise,
                netPayé = total - totalRemise

            };
            if (!string.IsNullOrWhiteSpace(client_combo.Text) && client_combo.Text != "")
            {
                monVente.clientId = GestionnaireProRetreivingMethods.GetClientIdByName(client_combo.Text).Result;
            }
            GestionnaireProInsertingMethods.AddVente(monVente);
        }
        private void AddDetailVente()
        {
            var venteId = GestionnaireProRetreivingMethods.RetreiveLastInsertedRowId("ventes").Result;
            var details = new List<DetailVente>();
            int i = 0;
            foreach (var item in _mesArticleAvendre)
            {

                details.Add(new DetailVente
                {
                    codeBarre = item.codeBarre,
                    nom = item.nom,
                    Type = item.type,
                    prixAchat = item.prixAchat,
                    prixVente = item.prixVente * item.quantité,
                    Quantité = item.quantité,
                    remise = Convert.ToSingle(venteTable.Rows[i].Cells[_remiseIndex].Value),
                    VenteId = venteId

                });
                i++;
            }
            GestionnaireProInsertingMethods.AddDetailVente(details);
        }

        private void ModifyVente()
        {
            var vente = new Vente
            {
                dateModification = DateTime.Now,
                modifierPar = GlobalClass.username,
                nouveauMontantTotal = total,
                nouvelleRemise = totalRemise,
                nouveauNetAPayé = total - totalRemise

            };
            if (!string.IsNullOrWhiteSpace(client_combo.Text) && client_combo.Text != "")
            {
                vente.clientId = GestionnaireProRetreivingMethods.GetClientIdByName(client_combo.Text).Result;
            }
            GestionnaireProModifyDeleteMethods.ModifyVente(vente);


        }
        private void ModifyDetailVente()
        {
            List<DetailVente> details = new List<DetailVente>();

            int i = 0;
            foreach (var item in _mesArticleAvendre)
            {
                details.Add(new DetailVente
                {
                    nouveauTotal = item.prixVente * item.quantité,
                    nouvelleQnt = item.quantité,
                    nouvelleRemise = Convert.ToSingle(venteTable[_remiseIndex, i].Value),


                });
                i++;
            }
            GestionnaireProModifyDeleteMethods.ModifyDetailVente(details);
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
        private void AddClientsToCombo()
        {
            var mesClients = GestionnaireProRetreivingMethods.GetAllClients().Result;
            foreach (var client in mesClients)
            {
                client_combo.Items.Add(client.nom);
            }


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
        private void ResetArticlesStock()
        {
            _mesArticles = GestionnaireProRetreivingMethods.GetAllArticles().Result;
            if (venteTable.RowCount > 0)
            {
                var entryData = new Dictionary<int, float>();
                foreach (var item in _mesArticleAvendre)
                {
                    if (_mesArticles.Find(a => a.Id == item.Id) != null)
                        entryData.Add(item.Id, item.quantité + _mesArticles.Find(a => a.Id == item.Id).quantité);
                }
                foreach (var item in entryData)
                {
                    GestionnaireProModifyDeleteMethods.SetArticleQnt(item.Key, item.Value);
                }
            }

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

        private void venteTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            currentlySelectedRow = venteTable.SelectedRows[0].Index;
            ancientQnt = Convert.ToSingle(venteTable[QNT.Index, currentlySelectedRow].Value.ToString().Replace('.', ','));

        }
        private void venteTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cell = venteTable.CurrentCell;
          

            if (venteTable[QNT.Index, currentlySelectedRow].Value == null) venteTable[QNT.Index, currentlySelectedRow].Value = 0;
            if (venteTable[remiseCol.Index, currentlySelectedRow].Value == null) venteTable[remiseCol.Index, currentlySelectedRow].Value = 0;


            var monArticle = SearchForArticle(venteTable[codeBarreCol.Index, currentlySelectedRow].Value.ToString());
            if (monArticle == null) return;

            if (monArticle.quantité + ancientQnt - Convert.ToSingle(venteTable[QNT.Index, currentlySelectedRow].Value.ToString().Replace('.', ',')) > 0)
            {

                GestionnaireProModifyDeleteMethods.SetArticleQnt(monArticle.Id, monArticle.quantité + ancientQnt - Convert.ToSingle(venteTable[QNT.Index, currentlySelectedRow].Value.ToString().Replace('.', ',')));
                CalculateAll();
                return;
            }
            else
            {

                venteTable[QNT.Index, currentlySelectedRow].Value = monArticle.quantité + ancientQnt;

                GestionnaireProModifyDeleteMethods.SetArticleQnt(monArticle.Id, 0.0f);
                MessageBox.Show("Quantité Insuffisant !!");
                CalculateAll();
                return;

            }




        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString();
        }
        private void venteTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            SetCodeBarre();
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            var descriptionAction = "";
            if (GlobalClass.typeOp == 1)
            {
                ModifyVente();
                ModifyDetailVente();
                descriptionAction = $" Modifier le Vente du Référence {_venteId }";
                //reset Operation type
                GlobalClass.typeOp = 0;
            }
            else
            {
                if (_mesArticleAvendre.Count == 0)
                {

                    return;
                }
                descriptionAction = $" Modifier le Vente du Référence {_venteId }";
                AddVente();
                AddDetailVente();
            }


            GlobalClass.AddAction(GlobalClass.username, descriptionAction);
            ResetTable();


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
            using (var listArticle = new ListArticle())
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

        private void AbortVente()
        {
            _mesArticleAvendre = new List<Article>();
            SetUpTable();
        }
        private void abort_btn_Click(object sender, EventArgs e)
        {
            ResetArticlesStock();
            AbortVente();
        }

        private void ResetSingleArticleStock(int id,float qnt)
        {
            var monArticle = _mesArticles.Find(a => a.Id == id);
            if (monArticle != null)
                qnt += monArticle.quantité;
            GestionnaireProModifyDeleteMethods.SetArticleQnt(id,qnt);
        }
        private void DeleteCurrentSelectedRow()
        {

            var myRow = GetCurrentSelectedTableRow();
            if (myRow == -1) return;

            ResetSingleArticleStock(_mesArticles.Find(a => a.codeBarre == GetCurrentSelectedTableRow_CodeBarre()).Id, Convert.ToSingle(venteTable[_qntIndex, myRow].Value));
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

       
        private void QNT_KeyPress(object sender, KeyPressEventArgs e,TextBox t1)
        {
            GlobalClass.CheckForInputToBeNumbers(e, t1);
            
        }
      

        private void venteTable_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {


            TextBox tb = new TextBox();
                e.Control.KeyPress -= new KeyPressEventHandler((sender,e)=>QNT_KeyPress(sender,e,tb));
                if (venteTable.CurrentCell.ColumnIndex == _qntIndex || venteTable.CurrentCell.ColumnIndex == _remiseIndex || venteTable.CurrentCell.ColumnIndex == _totalIndex) //Desired Column
            {
                    tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler((sender, e) => QNT_KeyPress(sender, e, tb));
                        
                    }
                }
        }
      
            
           
        }
}


