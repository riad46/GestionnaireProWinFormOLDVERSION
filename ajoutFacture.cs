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
        private List<Article> _mesArticleAvendre= new List<Article>();

        public ajoutFacture()
        {
            InitializeComponent();
        }

        private void ajoutFacture_Load(object sender, EventArgs e)
        {
            if (GlobalClass.typeOp == 1)
            {
                SetUpTable();
            }
            AddClientsToCombo();
        }

        private void AddClientsToCombo()
        {
            throw new NotImplementedException();
        }

        private void SetUpTable()
        {
            throw new NotImplementedException();
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
    }
}
