
namespace Gestionnaire_Pro
{
    partial class historiqueVente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.historiqueTable = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateVenteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remiseCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetpayéCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifierLeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifierPar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NvtotaleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvRemise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvNetCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateMax_box = new System.Windows.Forms.DateTimePicker();
            this.dateMin_box = new System.Windows.Forms.DateTimePicker();
            this.sub_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomClient_txt = new System.Windows.Forms.TextBox();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.historiqueTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // historiqueTable
            // 
            this.historiqueTable.AllowUserToAddRows = false;
            this.historiqueTable.AllowUserToDeleteRows = false;
            this.historiqueTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.historiqueTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.historiqueTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historiqueTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historiqueTable.BackgroundColor = System.Drawing.Color.White;
            this.historiqueTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historiqueTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.historiqueTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historiqueTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.historiqueTable.ColumnHeadersHeight = 90;
            this.historiqueTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.DateVenteCol,
            this.totalCol,
            this.remiseCol,
            this.NetpayéCol,
            this.clientCol,
            this.userCol,
            this.modifierLeCol,
            this.modifierPar,
            this.NvtotaleCol,
            this.nvRemise,
            this.nvNetCol});
            this.historiqueTable.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historiqueTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.historiqueTable.EnableHeadersVisualStyles = false;
            this.historiqueTable.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.historiqueTable.Location = new System.Drawing.Point(0, 190);
            this.historiqueTable.MultiSelect = false;
            this.historiqueTable.Name = "historiqueTable";
            this.historiqueTable.ReadOnly = true;
            this.historiqueTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.historiqueTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.historiqueTable.RowHeadersVisible = false;
            this.historiqueTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.historiqueTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.historiqueTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historiqueTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.historiqueTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.historiqueTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.historiqueTable.RowTemplate.Height = 40;
            this.historiqueTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historiqueTable.Size = new System.Drawing.Size(1045, 569);
            this.historiqueTable.TabIndex = 0;
            this.historiqueTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historique_Table_CellDoubleClick);
            // 
            // idCol
            // 
            this.idCol.DataPropertyName = "Id";
            this.idCol.HeaderText = "Réf";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            // 
            // DateVenteCol
            // 
            this.DateVenteCol.DataPropertyName = "dateVente";
            this.DateVenteCol.HeaderText = "Date Vente";
            this.DateVenteCol.Name = "DateVenteCol";
            this.DateVenteCol.ReadOnly = true;
            // 
            // totalCol
            // 
            this.totalCol.DataPropertyName = "montantTotale";
            this.totalCol.HeaderText = "Montant Total";
            this.totalCol.Name = "totalCol";
            this.totalCol.ReadOnly = true;
            // 
            // remiseCol
            // 
            this.remiseCol.DataPropertyName = "remise";
            this.remiseCol.HeaderText = "Remise";
            this.remiseCol.Name = "remiseCol";
            this.remiseCol.ReadOnly = true;
            // 
            // NetpayéCol
            // 
            this.NetpayéCol.DataPropertyName = "netPayé";
            this.NetpayéCol.HeaderText = "Net Payé";
            this.NetpayéCol.Name = "NetpayéCol";
            this.NetpayéCol.ReadOnly = true;
            // 
            // clientCol
            // 
            this.clientCol.HeaderText = "Client";
            this.clientCol.Name = "clientCol";
            this.clientCol.ReadOnly = true;
            // 
            // userCol
            // 
            this.userCol.DataPropertyName = "ajouterPar";
            this.userCol.HeaderText = "Ajouter Par";
            this.userCol.Name = "userCol";
            this.userCol.ReadOnly = true;
            // 
            // modifierLeCol
            // 
            this.modifierLeCol.DataPropertyName = "dateModification";
            this.modifierLeCol.HeaderText = "Modifier Le";
            this.modifierLeCol.Name = "modifierLeCol";
            this.modifierLeCol.ReadOnly = true;
            // 
            // modifierPar
            // 
            this.modifierPar.DataPropertyName = "modifierPar";
            this.modifierPar.HeaderText = "Modifier Par";
            this.modifierPar.Name = "modifierPar";
            this.modifierPar.ReadOnly = true;
            // 
            // NvtotaleCol
            // 
            this.NvtotaleCol.DataPropertyName = "nouveauMontantTotal";
            this.NvtotaleCol.HeaderText = "Nouveau Total";
            this.NvtotaleCol.Name = "NvtotaleCol";
            this.NvtotaleCol.ReadOnly = true;
            // 
            // nvRemise
            // 
            this.nvRemise.DataPropertyName = "nouvelleRemise";
            this.nvRemise.HeaderText = "Nouvelle Remise";
            this.nvRemise.Name = "nvRemise";
            this.nvRemise.ReadOnly = true;
            // 
            // nvNetCol
            // 
            this.nvNetCol.DataPropertyName = "NouveauNetAPayé";
            this.nvNetCol.HeaderText = "Nouveau Net Payé";
            this.nvNetCol.Name = "nvNetCol";
            this.nvNetCol.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 184);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateMax_box);
            this.groupBox1.Controls.Add(this.dateMin_box);
            this.groupBox1.Controls.Add(this.sub_btn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nomClient_txt);
            this.groupBox1.Controls.Add(this.total_txt);
            this.groupBox1.Controls.Add(this.id_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // dateMax_box
            // 
            this.dateMax_box.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateMax_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMax_box.Location = new System.Drawing.Point(277, 22);
            this.dateMax_box.Name = "dateMax_box";
            this.dateMax_box.Size = new System.Drawing.Size(152, 23);
            this.dateMax_box.TabIndex = 12;
            // 
            // dateMin_box
            // 
            this.dateMin_box.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateMin_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMin_box.Location = new System.Drawing.Point(103, 22);
            this.dateMin_box.Name = "dateMin_box";
            this.dateMin_box.Size = new System.Drawing.Size(147, 23);
            this.dateMin_box.TabIndex = 11;
            // 
            // sub_btn
            // 
            this.sub_btn.Location = new System.Drawing.Point(179, 147);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(97, 33);
            this.sub_btn.TabIndex = 10;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nom Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Réf";
            // 
            // nomClient_txt
            // 
            this.nomClient_txt.Location = new System.Drawing.Point(101, 115);
            this.nomClient_txt.Name = "nomClient_txt";
            this.nomClient_txt.Size = new System.Drawing.Size(94, 23);
            this.nomClient_txt.TabIndex = 4;
            // 
            // total_txt
            // 
            this.total_txt.Location = new System.Drawing.Point(277, 70);
            this.total_txt.Name = "total_txt";
            this.total_txt.Size = new System.Drawing.Size(109, 23);
            this.total_txt.TabIndex = 3;
            this.total_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.total_txt_KeyPress);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(101, 67);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(75, 23);
            this.id_txt.TabIndex = 2;
            this.id_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Vente     DU";
            // 
            // historiqueVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.historiqueTable);
            this.Name = "historiqueVente";
            this.Text = "historyVente";
            this.Shown += new System.EventHandler(this.historiqueVente_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.historiqueTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView historiqueTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateVenteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn remiseCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetpayéCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifierLeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifierPar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NvtotaleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvRemise;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvNetCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomClient_txt;
        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.DateTimePicker dateMax_box;
        private System.Windows.Forms.DateTimePicker dateMin_box;
    }
}