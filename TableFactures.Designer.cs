
namespace Gestionnaire_Pro
{
    partial class TableFactures
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.del_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sub_btn = new System.Windows.Forms.Button();
            this.dateMax_box = new System.Windows.Forms.DateTimePicker();
            this.dateMin_box = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomClient_txt = new System.Windows.Forms.TextBox();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.historiqueTable = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateVenteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remiseCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetpayéCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiqueTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.del_btn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 218);
            this.panel1.TabIndex = 3;
            // 
            // del_btn
            // 
            this.del_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Location = new System.Drawing.Point(935, 167);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(136, 46);
            this.del_btn.TabIndex = 13;
            this.del_btn.Text = "Supprimer";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sub_btn);
            this.groupBox1.Controls.Add(this.dateMax_box);
            this.groupBox1.Controls.Add(this.dateMin_box);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nomClient_txt);
            this.groupBox1.Controls.Add(this.total_txt);
            this.groupBox1.Controls.Add(this.id_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // sub_btn
            // 
            this.sub_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sub_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sub_btn.ForeColor = System.Drawing.Color.White;
            this.sub_btn.Location = new System.Drawing.Point(663, 164);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(181, 46);
            this.sub_btn.TabIndex = 11;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // dateMax_box
            // 
            this.dateMax_box.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateMax_box.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateMax_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMax_box.Location = new System.Drawing.Point(572, 28);
            this.dateMax_box.Name = "dateMax_box";
            this.dateMax_box.Size = new System.Drawing.Size(241, 35);
            this.dateMax_box.TabIndex = 12;
            // 
            // dateMin_box
            // 
            this.dateMin_box.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateMin_box.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateMin_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMin_box.Location = new System.Drawing.Point(272, 28);
            this.dateMin_box.Name = "dateMin_box";
            this.dateMin_box.Size = new System.Drawing.Size(246, 35);
            this.dateMin_box.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(524, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Au";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nom Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Réf";
            // 
            // nomClient_txt
            // 
            this.nomClient_txt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomClient_txt.Location = new System.Drawing.Point(152, 164);
            this.nomClient_txt.Name = "nomClient_txt";
            this.nomClient_txt.Size = new System.Drawing.Size(94, 35);
            this.nomClient_txt.TabIndex = 4;
            // 
            // total_txt
            // 
            this.total_txt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total_txt.Location = new System.Drawing.Point(79, 115);
            this.total_txt.Name = "total_txt";
            this.total_txt.Size = new System.Drawing.Size(109, 35);
            this.total_txt.TabIndex = 3;
            this.total_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.total_txt_KeyPress);
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.id_txt.Location = new System.Drawing.Point(77, 70);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(75, 35);
            this.id_txt.TabIndex = 2;
            this.id_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Facturation:     DU";
            // 
            // historiqueTable
            // 
            this.historiqueTable.AllowUserToAddRows = false;
            this.historiqueTable.AllowUserToDeleteRows = false;
            this.historiqueTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.historiqueTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.historiqueTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historiqueTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historiqueTable.BackgroundColor = System.Drawing.Color.White;
            this.historiqueTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historiqueTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.historiqueTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historiqueTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.historiqueTable.ColumnHeadersHeight = 90;
            this.historiqueTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.DateVenteCol,
            this.totalCol,
            this.remiseCol,
            this.NetpayéCol,
            this.clientCol,
            this.userCol});
            this.historiqueTable.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historiqueTable.DefaultCellStyle = dataGridViewCellStyle7;
            this.historiqueTable.EnableHeadersVisualStyles = false;
            this.historiqueTable.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.historiqueTable.Location = new System.Drawing.Point(0, 221);
            this.historiqueTable.MultiSelect = false;
            this.historiqueTable.Name = "historiqueTable";
            this.historiqueTable.ReadOnly = true;
            this.historiqueTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.historiqueTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.historiqueTable.RowHeadersVisible = false;
            this.historiqueTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.historiqueTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.historiqueTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historiqueTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.historiqueTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.historiqueTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.historiqueTable.RowTemplate.Height = 40;
            this.historiqueTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historiqueTable.Size = new System.Drawing.Size(1074, 329);
            this.historiqueTable.TabIndex = 2;
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
            this.DateVenteCol.DataPropertyName = "dateFacture";
            this.DateVenteCol.HeaderText = "Date Facturation";
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
            // TableFactures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.historiqueTable);
            this.Name = "TableFactures";
            this.Text = "Table de Factures";
            
            this.Shown += new System.EventHandler(this.TableFactureForm_Shown);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiqueTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateMax_box;
        private System.Windows.Forms.DateTimePicker dateMin_box;
        
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomClient_txt;
        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView historiqueTable;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateVenteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn remiseCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetpayéCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCol;
    }
}