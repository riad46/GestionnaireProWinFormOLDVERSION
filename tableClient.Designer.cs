﻿
namespace Gestionnaire_Pro
{
    partial class tableClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_btn = new System.Windows.Forms.Button();
            this.Modify_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numTlf_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nom_txt = new System.Windows.Forms.TextBox();
            this.tableCl = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsTable = new System.Windows.Forms.DataGridView();
            this.descCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estPayé = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.Modify_btn);
            this.panel1.Controls.Add(this.del_btn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 140);
            this.panel1.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(500, 3);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(135, 39);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Ajouter";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Modify_btn
            // 
            this.Modify_btn.Location = new System.Drawing.Point(653, 3);
            this.Modify_btn.Name = "Modify_btn";
            this.Modify_btn.Size = new System.Drawing.Size(135, 39);
            this.Modify_btn.TabIndex = 2;
            this.Modify_btn.Text = "Modifier";
            this.Modify_btn.UseVisualStyleBackColor = true;
            this.Modify_btn.Click += new System.EventHandler(this.Modify_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(653, 72);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(135, 39);
            this.del_btn.TabIndex = 1;
            this.del_btn.Text = "Supprimer";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numTlf_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nom_txt);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(11, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche Client";
            // 
            // numTlf_txt
            // 
            this.numTlf_txt.Location = new System.Drawing.Point(136, 80);
            this.numTlf_txt.Name = "numTlf_txt";
            this.numTlf_txt.Size = new System.Drawing.Size(173, 36);
            this.numTlf_txt.TabIndex = 6;
            this.numTlf_txt.TextChanged += new System.EventHandler(this.numTlf_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "N° Téléphone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // nom_txt
            // 
            this.nom_txt.Location = new System.Drawing.Point(136, 35);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(173, 36);
            this.nom_txt.TabIndex = 3;
            this.nom_txt.TextChanged += new System.EventHandler(this.nom_txt_TextChanged);
            // 
            // tableCl
            // 
            this.tableCl.AllowUserToAddRows = false;
            this.tableCl.AllowUserToDeleteRows = false;
            this.tableCl.AllowUserToOrderColumns = true;
            this.tableCl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableCl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableCl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableCl.BackgroundColor = System.Drawing.SystemColors.Info;
            this.tableCl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nom,
            this.address,
            this.num,
            this.credit});
            this.tableCl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tableCl.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.tableCl.Location = new System.Drawing.Point(0, 146);
            this.tableCl.MultiSelect = false;
            this.tableCl.Name = "tableCl";
            this.tableCl.ReadOnly = true;
            this.tableCl.RowTemplate.Height = 25;
            this.tableCl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableCl.Size = new System.Drawing.Size(800, 211);
            this.tableCl.TabIndex = 2;
            this.tableCl.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.tableCl_CellStateChanged);
            this.tableCl.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tableCl_RowPostPaint);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "Id";
            this.id.Frozen = true;
            this.id.HeaderText = "Réf";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 151;
            // 
            // nom
            // 
            this.nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nom.DataPropertyName = "nom";
            this.nom.Frozen = true;
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 152;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 151;
            // 
            // num
            // 
            this.num.DataPropertyName = "numTlf";
            this.num.HeaderText = "N° Téléphone";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // credit
            // 
            this.credit.DataPropertyName = "credit";
            this.credit.HeaderText = "Credit";
            this.credit.Name = "credit";
            this.credit.ReadOnly = true;
            // 
            // detailsTable
            // 
            this.detailsTable.AllowUserToAddRows = false;
            this.detailsTable.AllowUserToDeleteRows = false;
            this.detailsTable.AllowUserToOrderColumns = true;
            this.detailsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descCol,
            this.date,
            this.Col,
            this.rest,
            this.estPayé});
            this.detailsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.detailsTable.Location = new System.Drawing.Point(0, 363);
            this.detailsTable.MultiSelect = false;
            this.detailsTable.Name = "detailsTable";
            this.detailsTable.ReadOnly = true;
            this.detailsTable.RowTemplate.Height = 25;
            this.detailsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detailsTable.Size = new System.Drawing.Size(800, 254);
            this.detailsTable.TabIndex = 3;
            // 
            // descCol
            // 
            this.descCol.DataPropertyName = "descriptionProduit";
            this.descCol.HeaderText = "Description ";
            this.descCol.Name = "descCol";
            this.descCol.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "dateCredit";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // Col
            // 
            this.Col.DataPropertyName = "prixTotale";
            this.Col.HeaderText = "Total";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            // 
            // rest
            // 
            this.rest.DataPropertyName = "RestApayé";
            this.rest.HeaderText = "Rest A Payé";
            this.rest.Name = "rest";
            this.rest.ReadOnly = true;
            // 
            // estPayé
            // 
            this.estPayé.DataPropertyName = "estPayé";
            this.estPayé.FalseValue = "0";
            this.estPayé.HeaderText = "Est Payé?";
            this.estPayé.Name = "estPayé";
            this.estPayé.ReadOnly = true;
            this.estPayé.TrueValue = "1";
            // 
            // tableClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.detailsTable);
            this.Controls.Add(this.tableCl);
            this.Controls.Add(this.panel1);
            this.Name = "tableClient";
            this.Load += new System.EventHandler(this.tableClient_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tableCl;
        private System.Windows.Forms.DataGridView detailsTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nom_txt;
        private System.Windows.Forms.TextBox numTlf_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn descCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn rest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estPayé;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button Modify_btn;
        private System.Windows.Forms.Button del_btn;
    }
}