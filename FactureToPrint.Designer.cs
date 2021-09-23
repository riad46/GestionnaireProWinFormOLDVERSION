
namespace Gestionnaire_Pro
{
    partial class FactureToPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Boutique = new System.Windows.Forms.GroupBox();
            this.boutiqueNum_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoutiqueAddress_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.geoupbox = new System.Windows.Forms.GroupBox();
            this.clientNumRegistre_lbl = new System.Windows.Forms.Label();
            this.clientAddress_lbl = new System.Windows.Forms.Label();
            this.clientNom_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFacture_lbl = new System.Windows.Forms.Label();
            this.nomBoutique_lbl = new System.Windows.Forms.Label();
            this.factureId_lbl = new System.Windows.Forms.Label();
            this.articlesTable = new System.Windows.Forms.DataGridView();
            this.nomArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVenteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.total_lbl = new System.Windows.Forms.Label();
            this.remise_lbl = new System.Windows.Forms.Label();
            this.netPayé_lbl = new System.Windows.Forms.Label();
            this.labelvc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.Boutique.SuspendLayout();
            this.geoupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Boutique);
            this.panel1.Controls.Add(this.geoupbox);
            this.panel1.Controls.Add(this.dateFacture_lbl);
            this.panel1.Controls.Add(this.nomBoutique_lbl);
            this.panel1.Controls.Add(this.factureId_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 201);
            this.panel1.TabIndex = 0;
            // 
            // Boutique
            // 
            this.Boutique.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Boutique.Controls.Add(this.boutiqueNum_lbl);
            this.Boutique.Controls.Add(this.label1);
            this.Boutique.Controls.Add(this.BoutiqueAddress_lbl);
            this.Boutique.Controls.Add(this.label2);
            this.Boutique.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Boutique.Location = new System.Drawing.Point(0, 61);
            this.Boutique.Name = "Boutique";
            this.Boutique.Size = new System.Drawing.Size(451, 135);
            this.Boutique.TabIndex = 6;
            this.Boutique.TabStop = false;
            this.Boutique.Text = "Informations du Boutique";
            // 
            // boutiqueNum_lbl
            // 
            this.boutiqueNum_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.boutiqueNum_lbl.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boutiqueNum_lbl.Location = new System.Drawing.Point(152, 67);
            this.boutiqueNum_lbl.Name = "boutiqueNum_lbl";
            this.boutiqueNum_lbl.Size = new System.Drawing.Size(225, 22);
            this.boutiqueNum_lbl.TabIndex = 17;
            this.boutiqueNum_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Address :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoutiqueAddress_lbl
            // 
            this.BoutiqueAddress_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BoutiqueAddress_lbl.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoutiqueAddress_lbl.Location = new System.Drawing.Point(103, 34);
            this.BoutiqueAddress_lbl.Name = "BoutiqueAddress_lbl";
            this.BoutiqueAddress_lbl.Size = new System.Drawing.Size(334, 22);
            this.BoutiqueAddress_lbl.TabIndex = 16;
            this.BoutiqueAddress_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "N° Téléphone :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // geoupbox
            // 
            this.geoupbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.geoupbox.Controls.Add(this.clientNumRegistre_lbl);
            this.geoupbox.Controls.Add(this.clientAddress_lbl);
            this.geoupbox.Controls.Add(this.clientNom_lbl);
            this.geoupbox.Controls.Add(this.label5);
            this.geoupbox.Controls.Add(this.label4);
            this.geoupbox.Controls.Add(this.label3);
            this.geoupbox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.geoupbox.Location = new System.Drawing.Point(473, 61);
            this.geoupbox.Name = "geoupbox";
            this.geoupbox.Size = new System.Drawing.Size(321, 135);
            this.geoupbox.TabIndex = 5;
            this.geoupbox.TabStop = false;
            this.geoupbox.Text = "Client";
            // 
            // clientNumRegistre_lbl
            // 
            this.clientNumRegistre_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clientNumRegistre_lbl.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientNumRegistre_lbl.Location = new System.Drawing.Point(122, 89);
            this.clientNumRegistre_lbl.Name = "clientNumRegistre_lbl";
            this.clientNumRegistre_lbl.Size = new System.Drawing.Size(192, 22);
            this.clientNumRegistre_lbl.TabIndex = 12;
            this.clientNumRegistre_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientAddress_lbl
            // 
            this.clientAddress_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clientAddress_lbl.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientAddress_lbl.Location = new System.Drawing.Point(89, 57);
            this.clientAddress_lbl.Name = "clientAddress_lbl";
            this.clientAddress_lbl.Size = new System.Drawing.Size(226, 22);
            this.clientAddress_lbl.TabIndex = 11;
            this.clientAddress_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientNom_lbl
            // 
            this.clientNom_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clientNom_lbl.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientNom_lbl.Location = new System.Drawing.Point(71, 28);
            this.clientNom_lbl.Name = "clientNom_lbl";
            this.clientNom_lbl.Size = new System.Drawing.Size(195, 22);
            this.clientNom_lbl.TabIndex = 8;
            this.clientNom_lbl.Text = "Client Par Default";
            this.clientNom_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "N° Registre :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nom :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateFacture_lbl
            // 
            this.dateFacture_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFacture_lbl.Font = new System.Drawing.Font("Times New Roman", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateFacture_lbl.Location = new System.Drawing.Point(595, 8);
            this.dateFacture_lbl.Name = "dateFacture_lbl";
            this.dateFacture_lbl.Size = new System.Drawing.Size(200, 23);
            this.dateFacture_lbl.TabIndex = 4;
            this.dateFacture_lbl.Text = "DD/MM/YYYY";
            this.dateFacture_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomBoutique_lbl
            // 
            this.nomBoutique_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nomBoutique_lbl.Font = new System.Drawing.Font("Times New Roman", 17.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomBoutique_lbl.Location = new System.Drawing.Point(191, 9);
            this.nomBoutique_lbl.Name = "nomBoutique_lbl";
            this.nomBoutique_lbl.Size = new System.Drawing.Size(383, 42);
            this.nomBoutique_lbl.TabIndex = 0;
            this.nomBoutique_lbl.Text = "Ma Boutique";
            this.nomBoutique_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // factureId_lbl
            // 
            this.factureId_lbl.AutoSize = true;
            this.factureId_lbl.Font = new System.Drawing.Font("Times New Roman", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.factureId_lbl.Location = new System.Drawing.Point(11, 9);
            this.factureId_lbl.Name = "factureId_lbl";
            this.factureId_lbl.Size = new System.Drawing.Size(111, 22);
            this.factureId_lbl.TabIndex = 15;
            this.factureId_lbl.Text = "Facture N°  ";
            this.factureId_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // articlesTable
            // 
            this.articlesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.articlesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.articlesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.articlesTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articlesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.articlesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articlesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomArticle,
            this.prixVenteCol,
            this.qntCol,
            this.total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.articlesTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.articlesTable.Location = new System.Drawing.Point(1, 207);
            this.articlesTable.MultiSelect = false;
            this.articlesTable.Name = "articlesTable";
            this.articlesTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.articlesTable.RowHeadersVisible = false;
            this.articlesTable.RowTemplate.Height = 25;
            this.articlesTable.Size = new System.Drawing.Size(799, 254);
            this.articlesTable.TabIndex = 1;
            // 
            // nomArticle
            // 
            this.nomArticle.DataPropertyName = "nom";
            this.nomArticle.HeaderText = "Nom Article";
            this.nomArticle.Name = "nomArticle";
            this.nomArticle.ReadOnly = true;
            // 
            // prixVenteCol
            // 
            this.prixVenteCol.DataPropertyName = "prixVente";
            this.prixVenteCol.HeaderText = "P.U";
            this.prixVenteCol.Name = "prixVenteCol";
            this.prixVenteCol.ReadOnly = true;
            // 
            // qntCol
            // 
            this.qntCol.DataPropertyName = "quantité";
            this.qntCol.HeaderText = "QNT";
            this.qntCol.Name = "qntCol";
            this.qntCol.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "P.T";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 160);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.total_lbl);
            this.groupBox1.Controls.Add(this.remise_lbl);
            this.groupBox1.Controls.Add(this.netPayé_lbl);
            this.groupBox1.Controls.Add(this.labelvc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(491, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 154);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // total_lbl
            // 
            this.total_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("SimSun", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total_lbl.Location = new System.Drawing.Point(116, 15);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(103, 25);
            this.total_lbl.TabIndex = 20;
            this.total_lbl.Text = "0.00 DA";
            this.total_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remise_lbl
            // 
            this.remise_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.remise_lbl.AutoSize = true;
            this.remise_lbl.Font = new System.Drawing.Font("SimSun", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remise_lbl.Location = new System.Drawing.Point(116, 47);
            this.remise_lbl.Name = "remise_lbl";
            this.remise_lbl.Size = new System.Drawing.Size(103, 25);
            this.remise_lbl.TabIndex = 19;
            this.remise_lbl.Text = "0.00 DA";
            this.remise_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // netPayé_lbl
            // 
            this.netPayé_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.netPayé_lbl.AutoSize = true;
            this.netPayé_lbl.Font = new System.Drawing.Font("SimSun", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.netPayé_lbl.Location = new System.Drawing.Point(116, 91);
            this.netPayé_lbl.Name = "netPayé_lbl";
            this.netPayé_lbl.Size = new System.Drawing.Size(103, 25);
            this.netPayé_lbl.TabIndex = 18;
            this.netPayé_lbl.Text = "0.00 DA";
            this.netPayé_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelvc
            // 
            this.labelvc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelvc.AutoSize = true;
            this.labelvc.Font = new System.Drawing.Font("Times New Roman", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelvc.Location = new System.Drawing.Point(6, 19);
            this.labelvc.Name = "labelvc";
            this.labelvc.Size = new System.Drawing.Size(62, 22);
            this.labelvc.TabIndex = 15;
            this.labelvc.Text = "Total :";
            this.labelvc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Net A Payé :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Remise :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // FactureToPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.articlesTable);
            this.Controls.Add(this.panel1);
            this.Name = "FactureToPrint";
            this.Text = "FactureToPrint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Boutique.ResumeLayout(false);
            this.Boutique.PerformLayout();
            this.geoupbox.ResumeLayout(false);
            this.geoupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nomBoutique_lbl;
        private System.Windows.Forms.Label dateFacture_lbl;
        private System.Windows.Forms.GroupBox geoupbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label clientNom_lbl;
        private System.Windows.Forms.Label clientAddress_lbl;
        private System.Windows.Forms.Label clientNumRegistre_lbl;
        private System.Windows.Forms.GroupBox Boutique;
        private System.Windows.Forms.Label boutiqueNum_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BoutiqueAddress_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label factureId_lbl;
        private System.Windows.Forms.DataGridView articlesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVenteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label remise_lbl;
        private System.Windows.Forms.Label netPayé_lbl;
        private System.Windows.Forms.Label labelvc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}