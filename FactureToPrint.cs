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
    public partial class FactureToPrint : Form
    {
       
       
        public FactureToPrint()
        {
            InitializeComponent();
        }
        public FactureToPrint(DateTime dateFacture,List<Article> mesArticles,Client client,int venteId,float total,float remise,float netPayé)
        {
            InitializeComponent();
            dateFacture_lbl.Text = dateFacture.ToString();
            SetUpPayementValues(venteId, total, remise, netPayé);
            SetUpClientInfos(client);
            SetUpBoutiqueInfos();

            SetUpTable(mesArticles);

        }

        private void SetUpPayementValues(int venteId, float total, float remise, float netPayé)
        {
            factureId_lbl.Text += $" {venteId}";
            total_lbl.Text = $"{total} DA";
            remise_lbl.Text = $"{remise} DA";
            netPayé_lbl.Text = $"{netPayé} DA";
            
        }
        private void SetUpTable(List<Article> mesArticles)
        {
            articlesTable.AutoGenerateColumns = false;
            articlesTable.DataSource = mesArticles;
        }
        private void SetUpClientInfos(Client client)
        {
            if(client != null)
            {
                clientNom_lbl.Text = client.nom;
                clientAddress_lbl.Text = client.address;
                //clientNumRegistre_lbl.Text = client.numRegistre;
            }


        }
        private void SetUpBoutiqueInfos()
        {
            var boutiqueInfos = GestionnaireProRetreivingMethods.GetBoutiqueInfos().Result;
            if (boutiqueInfos == null) return;
            nomBoutique_lbl.Text = boutiqueInfos.nomBoutique;
            BoutiqueAddress_lbl.Text = boutiqueInfos.address;
            boutiqueNum_lbl.Text = boutiqueInfos.numTlf;
        }
        
        private void PrintTheForm()
        {
            CaptureScreen();
            printPreviewDialog1.ShowDialog();
            Close();

        }

       
           
    

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

     

        private void print_btn_Click(object sender, EventArgs e)
        {
            print_btn.Visible = false;
            //this.ControlBox = false;
            
            this.FormBorderStyle = (FormBorderStyle)BorderStyle.None;
            PrintTheForm();

        }
    }
}
