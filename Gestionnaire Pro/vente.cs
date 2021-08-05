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
       
        private void AddVente()
        {
            totalRemise += Convert.ToSingle(remise_txt.Text);
            var monVente = new Vente()
            {
                ajouterPar = GlobalClass.username,
                dateVente=DateTime.Now,
                montantTotale=total,
                remise=totalRemise,
                netAPayé=total-totalRemise
                
          };
            if (!string.IsNullOrWhiteSpace(client_combo.Text) && client_combo.Text != "") 
            {
                monVente.clientId = GestionnaireProRetreivingMethods.GetClientIdByName(client_combo.Text).Result;
            }
            GestionnaireProInsertingMethods.AddVente(monVente); 
        }
        private void AddDetailVente()
        {

        }
        private void SetUpTable()
        {
            var bindingArticlesList = new BindingList<Article>(_mesArticleAvendre);
            var source = new BindingSource(bindingArticlesList, null);

            venteTable.AutoGenerateColumns = false;
            venteTable.DataSource = source;
            venteTable.Refresh();

            CalculateAll();
        }
        private void AddClientsToCombo()
        {
            var mesClients = GestionnaireProRetreivingMethods.GetAllClients().Result;
            client_combo.Items.AddRange(mesClients.ToArray());

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

                if ((string)venteTable.Rows[i].Cells[_remiseIndex].Value != "") 
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
    }
}
