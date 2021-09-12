
namespace Gestionnaire_Pro
{
    partial class revenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(revenue));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.recherche = new System.Windows.Forms.GroupBox();
            this.dateMax_box = new System.Windows.Forms.DateTimePicker();
            this.dateMin_box = new System.Windows.Forms.DateTimePicker();
            this.sub_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nom_txt = new System.Windows.Forms.TextBox();
            this.type_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPaye_lbl = new System.Windows.Forms.Label();
            this.revTotal_lbl = new System.Windows.Forms.Label();
            this.revNet_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.revenueTable = new System.Windows.Forms.DataGridView();
            this.codeBarre_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qnt_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revenueTable)).BeginInit();
            this.SuspendLayout();
            // 
            // recherche
            // 
            this.recherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recherche.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.recherche.Controls.Add(this.dateMax_box);
            this.recherche.Controls.Add(this.dateMin_box);
            this.recherche.Controls.Add(this.sub_btn);
            this.recherche.Controls.Add(this.label8);
            this.recherche.Controls.Add(this.label7);
            this.recherche.Controls.Add(this.label6);
            this.recherche.Controls.Add(this.label5);
            this.recherche.Controls.Add(this.nom_txt);
            this.recherche.Controls.Add(this.type_txt);
            this.recherche.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.recherche.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recherche.Location = new System.Drawing.Point(724, 3);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(530, 208);
            this.recherche.TabIndex = 0;
            this.recherche.TabStop = false;
            this.recherche.Text = "Filtre";
            // 
            // dateMax_box
            // 
            this.dateMax_box.CalendarFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateMax_box.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateMax_box.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateMax_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMax_box.Location = new System.Drawing.Point(316, 31);
            this.dateMax_box.Name = "dateMax_box";
            this.dateMax_box.Size = new System.Drawing.Size(205, 32);
            this.dateMax_box.TabIndex = 15;
            this.dateMax_box.Value = new System.DateTime(2021, 8, 19, 13, 51, 34, 0);
            // 
            // dateMin_box
            // 
            this.dateMin_box.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateMin_box.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateMin_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMin_box.Location = new System.Drawing.Point(83, 31);
            this.dateMin_box.Name = "dateMin_box";
            this.dateMin_box.Size = new System.Drawing.Size(207, 32);
            this.dateMin_box.TabIndex = 10;
            this.dateMin_box.Value = new System.DateTime(2021, 8, 19, 13, 51, 34, 0);
            // 
            // sub_btn
            // 
            this.sub_btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sub_btn.Location = new System.Drawing.Point(197, 165);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(117, 37);
            this.sub_btn.TabIndex = 14;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(293, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date De";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(255, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type";
            // 
            // nom_txt
            // 
            this.nom_txt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nom_txt.Location = new System.Drawing.Point(316, 110);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(123, 32);
            this.nom_txt.TabIndex = 1;
            // 
            // type_txt
            // 
            this.type_txt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.type_txt.Location = new System.Drawing.Point(83, 110);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(123, 32);
            this.type_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Payé Pour les Produit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(278, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Revenue Totale :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(278, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Revenue Net :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(427, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "_________________________________________________________________________________" +
    "___";
            // 
            // totalPaye_lbl
            // 
            this.totalPaye_lbl.AutoSize = true;
            this.totalPaye_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPaye_lbl.Location = new System.Drawing.Point(563, 39);
            this.totalPaye_lbl.Name = "totalPaye_lbl";
            this.totalPaye_lbl.Size = new System.Drawing.Size(67, 26);
            this.totalPaye_lbl.TabIndex = 5;
            this.totalPaye_lbl.Text = "label5";
            // 
            // revTotal_lbl
            // 
            this.revTotal_lbl.AutoSize = true;
            this.revTotal_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.revTotal_lbl.Location = new System.Drawing.Point(563, 91);
            this.revTotal_lbl.Name = "revTotal_lbl";
            this.revTotal_lbl.Size = new System.Drawing.Size(100, 26);
            this.revTotal_lbl.TabIndex = 6;
            this.revTotal_lbl.Text = "00000111";
            // 
            // revNet_lbl
            // 
            this.revNet_lbl.AutoSize = true;
            this.revNet_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.revNet_lbl.Location = new System.Drawing.Point(563, 153);
            this.revNet_lbl.Name = "revNet_lbl";
            this.revNet_lbl.Size = new System.Drawing.Size(67, 26);
            this.revNet_lbl.TabIndex = 7;
            this.revNet_lbl.Text = "label7";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::Gestionnaire_Pro.Properties.Resources.money;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.recherche);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.revNet_lbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.revTotal_lbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.totalPaye_lbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 226);
            this.panel1.TabIndex = 10;
            // 
            // revenueTable
            // 
            this.revenueTable.AllowUserToAddRows = false;
            this.revenueTable.AllowUserToDeleteRows = false;
            this.revenueTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.revenueTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.revenueTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.revenueTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.revenueTable.BackgroundColor = System.Drawing.Color.White;
            this.revenueTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.revenueTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.revenueTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.revenueTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.revenueTable.ColumnHeadersHeight = 60;
            this.revenueTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeBarre_Col,
            this.nom_Col,
            this.type_Col,
            this.qnt_Col,
            this.total_Col});
            this.revenueTable.EnableHeadersVisualStyles = false;
            this.revenueTable.GridColor = System.Drawing.Color.White;
            this.revenueTable.Location = new System.Drawing.Point(0, 226);
            this.revenueTable.MultiSelect = false;
            this.revenueTable.Name = "revenueTable";
            this.revenueTable.ReadOnly = true;
            this.revenueTable.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.revenueTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.revenueTable.RowTemplate.Height = 35;
            this.revenueTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.revenueTable.Size = new System.Drawing.Size(1257, 449);
            this.revenueTable.TabIndex = 11;
            // 
            // codeBarre_Col
            // 
            this.codeBarre_Col.DataPropertyName = "codeBarre";
            this.codeBarre_Col.HeaderText = "Code Barre";
            this.codeBarre_Col.Name = "codeBarre_Col";
            this.codeBarre_Col.ReadOnly = true;
            // 
            // nom_Col
            // 
            this.nom_Col.DataPropertyName = "nom";
            this.nom_Col.HeaderText = "Nom Article";
            this.nom_Col.Name = "nom_Col";
            this.nom_Col.ReadOnly = true;
            // 
            // type_Col
            // 
            this.type_Col.DataPropertyName = "type";
            this.type_Col.HeaderText = "Type";
            this.type_Col.Name = "type_Col";
            this.type_Col.ReadOnly = true;
            // 
            // qnt_Col
            // 
            this.qnt_Col.DataPropertyName = "Quantité";
            this.qnt_Col.HeaderText = "Quantité";
            this.qnt_Col.Name = "qnt_Col";
            this.qnt_Col.ReadOnly = true;
            // 
            // total_Col
            // 
            this.total_Col.HeaderText = "Total";
            this.total_Col.Name = "total_Col";
            this.total_Col.ReadOnly = true;
            // 
            // revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 675);
            this.Controls.Add(this.revenueTable);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "revenue";
            this.Text = "Revenue";
            this.Load += new System.EventHandler(this.revenue_Load);
            this.recherche.ResumeLayout(false);
            this.recherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.revenueTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox recherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalPaye_lbl;
        private System.Windows.Forms.Label revTotal_lbl;
        private System.Windows.Forms.Label revNet_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView revenueTable;
        private System.Windows.Forms.TextBox nom_txt;
        private System.Windows.Forms.TextBox type_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.DateTimePicker dateMin_box;
        private System.Windows.Forms.DateTimePicker dateMax_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeBarre_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn qnt_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_Col;
    }
}