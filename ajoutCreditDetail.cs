using Gestionnaire_Pro.DataBase.DataBaseMethods;
using Gestionnaire_Pro.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    public partial class ajoutCreditDetail : Form
    {
        public float AddedCredit = 0;
        private int _id;
        private List<DetailCreditClient> _details = new List<DetailCreditClient>();
        private readonly int _descriptionCell = 0;
        private readonly int _prixTotalCell = 1;
        private readonly int _dateCell = 4;
        private readonly int _estPayé=3;
      
        
        public ajoutCreditDetail()
        {
            InitializeComponent();
        }
        public ajoutCreditDetail(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void AddDetailsToDb()
        {
            
         
          
            int i = 0;
            var table = tablecreditDetail.Rows;
            foreach (var item in table)
            {

                var prixTotalCol = table[i].Cells[_prixTotalCell].Value;
                if( !string.IsNullOrWhiteSpace( (string )prixTotalCol) && prixTotalCol.ToString() != "")
                { 
                _details.Add(new DetailCreditClient
                {
                    descriptionProduit = (string)table[i].Cells[_descriptionCell].Value,
                    dateCredit = (DateTime)table[i].Cells[_dateCell].Value,
                    prixTotale = Convert.ToSingle(prixTotalCol.ToString()),
                    restApayé = Convert.ToSingle(prixTotalCol.ToString()),
                    estPayé = false,
                    ClientId = _id
                   
                  

                         });
                AddedCredit += Convert.ToSingle(table[i].Cells[_prixTotalCell].Value.ToString());
               }  
            if (i < table.Count) i++;
            }
          
            GestionnaireProInsertingMethods.AddDetailCreditClient(_details);
            Close();
        }
        private int GetCurrentSelectedTableRowId()
        {

            return (int)tablecreditDetail.SelectedRows[0].Index;
        }
        private void SetDateAndRest()
        {
            tablecreditDetail[restCol.Index, GetCurrentSelectedTableRowId()].Value = tablecreditDetail[totalCol.Index, GetCurrentSelectedTableRowId()].Value;
            tablecreditDetail[dateCol.Index, GetCurrentSelectedTableRowId()].Value = DateTime.Now;
            tablecreditDetail.Refresh();
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SetDateAndRest();

        }

       
        private void sub_btn_Click(object sender, EventArgs e)
        {
            
            AddDetailsToDb();
            
        }

        private void ajoutCreditDetail_Load(object sender, EventArgs e)
        {
            if (GlobalClass.typeOp == 1) 
            {
                sub_btn.Visible = false; 
                tablecreditDetail.ReadOnly = true;
               
                _details = GestionnaireProRetreivingMethods.GetDetailsCreditClient(_id).Result;
                tablecreditDetail.AutoGenerateColumns = false;
                tablecreditDetail.DataSource = _details;
                tablecreditDetail.Refresh();
                
                GlobalClass.typeOp = 0;
            }

        }
    }
}
