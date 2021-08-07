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
    public partial class vente : Form
    {
        private List<Article> _mesArticleAvendre = new List<Article>();
        private readonly int _codeBarreIndex = 0;
        private readonly int _qntIndex = 2;
        private readonly int _prixVenteIndex = 3;
        private readonly int _remiseIndex = 4;
        private readonly int _totalIndex = 5;

        private float total = 0;
        private float totalRemise = 0;
        private int nbrArticle = 0;
        private float nbrPiece = 0;

        public vente()
        {
            InitializeComponent();
        }
        private int GetCurrentSelectedTableRow()
        {
            return venteTable.SelectedRows[0].Index;
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
                dateVente=DateTime.Now,
                montantTotale=total,
                remise=totalRemise,
                netPayé=total-totalRemise
                
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
                    nomArticle = item.nom,
                    typeArticle=item.type,
                    prixAchat = item.prixAchat,
                    prixVente = item.prixVente,
                    qnt = item.quantité,
                    remise= Convert.ToSingle(venteTable.Rows[i].Cells[_remiseIndex].Value),
                    VenteId = venteId

                });
                i++;
            }
            GestionnaireProInsertingMethods.AddDetailVente(details);
        }
        private void SetUpTable()
        {
            var bindingArticlesList = new BindingList<Article>(_mesArticleAvendre);
            var source = new BindingSource(bindingArticlesList, null);

            venteTable.AutoGenerateColumns = false;
            venteTable.DataSource = source;
            venteTable.Refresh();
            if(venteTable.RowCount>0)
            for(int i=0;i< venteTable.RowCount;i++)
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
            if (venteTable.SelectedRows.Count > 0)
                codeBarreLabel.Text = venteTable[_codeBarreIndex, venteTable.SelectedRows[0].Index].Value.ToString();
        }
        private void CalculateAll()
        {
            total = 0;
            totalRemise = 0;
            nbrPiece = 0;

            for (int i = 0; i < venteTable.Rows.Count; i++)
            {
             venteTable.Rows[i].Cells[_totalIndex].Value =( Convert.ToSingle(venteTable.Rows[i].Cells[_qntIndex].Value) * Convert.ToSingle(venteTable.Rows[i].Cells[_prixVenteIndex].Value) )- (Convert.ToSingle(venteTable.Rows[i].Cells[_remiseIndex].Value) * Convert.ToSingle(venteTable.Rows[i].Cells[_qntIndex].Value));
             total += (float)venteTable.Rows[i].Cells[_totalIndex].Value;

               
                    totalRemise += Convert.ToSingle(venteTable.Rows[i].Cells[_remiseIndex].Value);
             
                nbrPiece += Convert.ToSingle(venteTable.Rows[i].Cells[_qntIndex].Value);
            }

            PutValuesInTitles(total,nbrArticle,nbrPiece);

        }
        private void PutValuesInTitles(float total, int nbrArticle, float nbrPiece)
        {
            totalLabel.Text = total+ " DA";
            nbrArticleLabel.Text = "Articles :"+nbrArticle;
            nbrPieceLabel.Text = "Pieces :"+nbrPiece;
        }

        
        private Article SearchForArticle(string codeBarre)
        {

            var res= GestionnaireProRetreivingMethods.GetArticleForVente(codeBarre).Result;
            return res;
        }

        private void codeBarre_txt_TextChanged(object sender, EventArgs e)
        {
            if (codeBarre_txt.Text.Length > 0)
            {
                var monArticle = SearchForArticle(codeBarre_txt.Text);
                if (monArticle != null)
                {
                    var monArticleSearch =_mesArticleAvendre.Find(a => a.codeBarre == monArticle.codeBarre);
                    
                    if (monArticleSearch == null) 
                    {
                        monArticle.quantité=1;
                        _mesArticleAvendre.Add(monArticle);
                        nbrArticle++;
                    }
                    else
                    {
                        _mesArticleAvendre[_mesArticleAvendre.IndexOf(monArticleSearch)].quantité +=1;
                    }

                    codeBarre_txt.Text = "";
                    SetUpTable();
                }
            }

        }
        private void venteTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateAll();
        }
        private void timer1_Tick(object sender , EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString();
        }
        private void venteTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            SetCodeBarre();
        }

        private void vente_Load(object sender, EventArgs e)
        {
            AddClientsToCombo();
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
                if(_mesArticleAvendre.Count == 0)
            {
                
                return;
            }
            
            AddVente(); 
            AddDetailVente();     
            ResetTable(); 
          
            
        }
        private void AddToVenteFromListArticles(Article article)
        {
           
            var result = _mesArticleAvendre.FindIndex(a=>a.nom == article.nom);
            if(result == -1)
            {
                _mesArticleAvendre.Add(article);
                return;
            }
            _mesArticleAvendre[result].quantité += 1;
        }
        private void listArticle_btn_Click(object sender, EventArgs e)
        {
            using (var listArticle = new ListArticle())
            {
                listArticle.ShowDialog();
              AddToVenteFromListArticles(listArticle.monArticle);
                SetUpTable();
            }
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
    }
}
