
namespace Gestionnaire_Pro
{
    partial class caisse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.montantInitCaisse_txt = new System.Windows.Forms.TextBox();
            this.dateMin_box = new System.Windows.Forms.DateTimePicker();
            this.dateMax_box = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.venteTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.achatTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontantTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.montantDansCaisse_txt = new System.Windows.Forms.TextBox();
            this.totalVente_txt = new System.Windows.Forms.TextBox();
            this.totalAchat_txt = new System.Windows.Forms.TextBox();
            this.benfice_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venteTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.achatTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.montantInitCaisse_txt);
            this.panel1.Controls.Add(this.dateMin_box);
            this.panel1.Controls.Add(this.dateMax_box);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 106);
            this.panel1.TabIndex = 0;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_btn.Location = new System.Drawing.Point(375, 11);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(97, 35);
            this.search_btn.TabIndex = 6;
            this.search_btn.Text = "Recherche";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(218, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Montant Initial dans la Caisse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(185, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "De";
            // 
            // montantInitCaisse_txt
            // 
            this.montantInitCaisse_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.montantInitCaisse_txt.Location = new System.Drawing.Point(436, 69);
            this.montantInitCaisse_txt.Name = "montantInitCaisse_txt";
            this.montantInitCaisse_txt.Size = new System.Drawing.Size(137, 29);
            this.montantInitCaisse_txt.TabIndex = 2;
            this.montantInitCaisse_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montantInitCaisse_txt_KeyPress);
            // 
            // dateMin_box
            // 
            this.dateMin_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateMin_box.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMin_box.Location = new System.Drawing.Point(51, 11);
            this.dateMin_box.Name = "dateMin_box";
            this.dateMin_box.Size = new System.Drawing.Size(128, 29);
            this.dateMin_box.TabIndex = 1;
            // 
            // dateMax_box
            // 
            this.dateMax_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateMax_box.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMax_box.Location = new System.Drawing.Point(211, 12);
            this.dateMax_box.Name = "dateMax_box";
            this.dateMax_box.Size = new System.Drawing.Size(126, 29);
            this.dateMax_box.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.venteTable);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(483, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 480);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vente";
            // 
            // venteTable
            // 
            this.venteTable.AllowUserToAddRows = false;
            this.venteTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.venteTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.venteTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.venteTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.venteTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.venteTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.venteTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.venteTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.venteTable.ColumnHeadersHeight = 50;
            this.venteTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dateVente,
            this.netPay});
            this.venteTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.venteTable.EnableHeadersVisualStyles = false;
            this.venteTable.Location = new System.Drawing.Point(3, 31);
            this.venteTable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.venteTable.MultiSelect = false;
            this.venteTable.Name = "venteTable";
            this.venteTable.ReadOnly = true;
            this.venteTable.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.venteTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.venteTable.RowTemplate.Height = 35;
            this.venteTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.venteTable.Size = new System.Drawing.Size(474, 446);
            this.venteTable.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Réf";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dateVente
            // 
            this.dateVente.DataPropertyName = "dateVente";
            this.dateVente.HeaderText = "Date Vente";
            this.dateVente.Name = "dateVente";
            this.dateVente.ReadOnly = true;
            // 
            // netPay
            // 
            this.netPay.DataPropertyName = "netPayé";
            this.netPay.HeaderText = "Net a Payé";
            this.netPay.Name = "netPay";
            this.netPay.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(this.achatTable);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 480);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Achat";
            // 
            // achatTable
            // 
            this.achatTable.AllowUserToAddRows = false;
            this.achatTable.AllowUserToDeleteRows = false;
            this.achatTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.achatTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.achatTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.achatTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.achatTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.achatTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.achatTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.achatTable.ColumnHeadersHeight = 50;
            this.achatTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dateAchat,
            this.MontantTotal});
            this.achatTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.achatTable.EnableHeadersVisualStyles = false;
            this.achatTable.Location = new System.Drawing.Point(3, 31);
            this.achatTable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.achatTable.MultiSelect = false;
            this.achatTable.Name = "achatTable";
            this.achatTable.ReadOnly = true;
            this.achatTable.RowHeadersVisible = false;
            this.achatTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.achatTable.RowTemplate.Height = 35;
            this.achatTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.achatTable.Size = new System.Drawing.Size(474, 446);
            this.achatTable.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Réf";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateAchat
            // 
            this.dateAchat.DataPropertyName = "dateAchat";
            this.dateAchat.HeaderText = "Date Achat";
            this.dateAchat.Name = "dateAchat";
            this.dateAchat.ReadOnly = true;
            // 
            // MontantTotal
            // 
            this.MontantTotal.DataPropertyName = "montantTotal";
            this.MontantTotal.HeaderText = "Montant Total";
            this.MontantTotal.Name = "MontantTotal";
            this.MontantTotal.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.montantDansCaisse_txt);
            this.panel2.Controls.Add(this.totalVente_txt);
            this.panel2.Controls.Add(this.totalAchat_txt);
            this.panel2.Controls.Add(this.benfice_txt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 598);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 213);
            this.panel2.TabIndex = 1;
            // 
            // montantDansCaisse_txt
            // 
            this.montantDansCaisse_txt.Enabled = false;
            this.montantDansCaisse_txt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.montantDansCaisse_txt.Location = new System.Drawing.Point(308, 160);
            this.montantDansCaisse_txt.Name = "montantDansCaisse_txt";
            this.montantDansCaisse_txt.Size = new System.Drawing.Size(141, 32);
            this.montantDansCaisse_txt.TabIndex = 7;
            // 
            // totalVente_txt
            // 
            this.totalVente_txt.Enabled = false;
            this.totalVente_txt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalVente_txt.Location = new System.Drawing.Point(164, 63);
            this.totalVente_txt.Name = "totalVente_txt";
            this.totalVente_txt.Size = new System.Drawing.Size(122, 32);
            this.totalVente_txt.TabIndex = 6;
            // 
            // totalAchat_txt
            // 
            this.totalAchat_txt.Enabled = false;
            this.totalAchat_txt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalAchat_txt.Location = new System.Drawing.Point(164, 13);
            this.totalAchat_txt.Name = "totalAchat_txt";
            this.totalAchat_txt.Size = new System.Drawing.Size(122, 32);
            this.totalAchat_txt.TabIndex = 5;
            // 
            // benfice_txt
            // 
            this.benfice_txt.Enabled = false;
            this.benfice_txt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.benfice_txt.Location = new System.Drawing.Point(164, 108);
            this.benfice_txt.Name = "benfice_txt";
            this.benfice_txt.Size = new System.Drawing.Size(122, 32);
            this.benfice_txt.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(18, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Montant Total dans la Caisse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bénifice Net";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total de Vente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total d\'Achat";
            // 
            // caisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 811);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "caisse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "caisse";
            this.Load += new System.EventHandler(this.caisse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.venteTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.achatTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView venteTable;
        private System.Windows.Forms.DataGridView achatTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontantTotal;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox montantInitCaisse_txt;
        private System.Windows.Forms.DateTimePicker dateMin_box;
        private System.Windows.Forms.DateTimePicker dateMax_box;
        private System.Windows.Forms.TextBox montantDansCaisse_txt;
        private System.Windows.Forms.TextBox totalVente_txt;
        private System.Windows.Forms.TextBox totalAchat_txt;
        private System.Windows.Forms.TextBox benfice_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn netPay;
    }
}