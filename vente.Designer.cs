namespace Gestionnaire_Pro
{
    partial class vente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.codeBarreLabel = new System.Windows.Forms.Label();
            this.nbrArticleLabel = new System.Windows.Forms.Label();
            this.nbrPieceLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listArticle_btn = new System.Windows.Forms.Button();
            this.client_combo = new System.Windows.Forms.ComboBox();
            this.remise_txt = new System.Windows.Forms.TextBox();
            this.codeBarre_txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.del_btn = new System.Windows.Forms.Button();
            this.abort_btn = new System.Windows.Forms.Button();
            this.sub_btn = new System.Windows.Forms.Button();
            this.venteTable = new System.Windows.Forms.DataGridView();
            this.codeBarreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remiseCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venteTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.codeBarreLabel);
            this.panel1.Controls.Add(this.nbrArticleLabel);
            this.panel1.Controls.Add(this.nbrPieceLabel);
            this.panel1.Controls.Add(this.totalLabel);
            this.panel1.Location = new System.Drawing.Point(299, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 202);
            this.panel1.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.Font = new System.Drawing.Font("SimSun-ExtB", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateLabel.Location = new System.Drawing.Point(382, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(296, 48);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "11/11/1111 00:00:00";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // codeBarreLabel
            // 
            this.codeBarreLabel.Font = new System.Drawing.Font("SimSun-ExtB", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codeBarreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.codeBarreLabel.Location = new System.Drawing.Point(12, 9);
            this.codeBarreLabel.Name = "codeBarreLabel";
            this.codeBarreLabel.Size = new System.Drawing.Size(193, 48);
            this.codeBarreLabel.TabIndex = 3;
            this.codeBarreLabel.Text = "codebarre";
            this.codeBarreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nbrArticleLabel
            // 
            this.nbrArticleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nbrArticleLabel.AutoSize = true;
            this.nbrArticleLabel.BackColor = System.Drawing.Color.Transparent;
            this.nbrArticleLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nbrArticleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nbrArticleLabel.Location = new System.Drawing.Point(12, 178);
            this.nbrArticleLabel.Name = "nbrArticleLabel";
            this.nbrArticleLabel.Size = new System.Drawing.Size(82, 19);
            this.nbrArticleLabel.TabIndex = 2;
            this.nbrArticleLabel.Text = "Nbr article";
            // 
            // nbrPieceLabel
            // 
            this.nbrPieceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nbrPieceLabel.AutoSize = true;
            this.nbrPieceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nbrPieceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nbrPieceLabel.Location = new System.Drawing.Point(112, 178);
            this.nbrPieceLabel.Name = "nbrPieceLabel";
            this.nbrPieceLabel.Size = new System.Drawing.Size(81, 19);
            this.nbrPieceLabel.TabIndex = 1;
            this.nbrPieceLabel.Text = "NBR piece";
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalLabel.Font = new System.Drawing.Font("SimSun-ExtB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalLabel.Location = new System.Drawing.Point(275, 119);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(406, 78);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "00.00 DA";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.listArticle_btn);
            this.panel2.Controls.Add(this.client_combo);
            this.panel2.Controls.Add(this.remise_txt);
            this.panel2.Controls.Add(this.codeBarre_txt);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 578);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Remise";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "CodeBarre";
            // 
            // listArticle_btn
            // 
            this.listArticle_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.listArticle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listArticle_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listArticle_btn.Location = new System.Drawing.Point(70, 175);
            this.listArticle_btn.Name = "listArticle_btn";
            this.listArticle_btn.Size = new System.Drawing.Size(164, 27);
            this.listArticle_btn.TabIndex = 3;
            this.listArticle_btn.Text = "Liste d\'Article";
            this.listArticle_btn.UseVisualStyleBackColor = true;
            this.listArticle_btn.Click += new System.EventHandler(this.listArticle_btn_Click);
            // 
            // client_combo
            // 
            this.client_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.client_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.client_combo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.client_combo.FormattingEnabled = true;
            this.client_combo.Location = new System.Drawing.Point(92, 108);
            this.client_combo.Name = "client_combo";
            this.client_combo.Size = new System.Drawing.Size(184, 33);
            this.client_combo.TabIndex = 5;
            // 
            // remise_txt
            // 
            this.remise_txt.Font = new System.Drawing.Font("PMingLiU-ExtB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remise_txt.Location = new System.Drawing.Point(92, 63);
            this.remise_txt.Name = "remise_txt";
            this.remise_txt.Size = new System.Drawing.Size(186, 39);
            this.remise_txt.TabIndex = 4;
            this.remise_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.remise_txt_KeyPress);
            // 
            // codeBarre_txt
            // 
            this.codeBarre_txt.Font = new System.Drawing.Font("PMingLiU-ExtB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codeBarre_txt.Location = new System.Drawing.Point(92, 18);
            this.codeBarre_txt.Name = "codeBarre_txt";
            this.codeBarre_txt.Size = new System.Drawing.Size(186, 39);
            this.codeBarre_txt.TabIndex = 3;
            this.codeBarre_txt.TextChanged += new System.EventHandler(this.codeBarre_txt_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.del_btn);
            this.panel3.Controls.Add(this.abort_btn);
            this.panel3.Controls.Add(this.sub_btn);
            this.panel3.Location = new System.Drawing.Point(0, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 373);
            this.panel3.TabIndex = 2;
            // 
            // del_btn
            // 
            this.del_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.del_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.del_btn.Location = new System.Drawing.Point(10, 146);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(267, 48);
            this.del_btn.TabIndex = 2;
            this.del_btn.Text = "Supprimer";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // abort_btn
            // 
            this.abort_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.abort_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.abort_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abort_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.abort_btn.Location = new System.Drawing.Point(10, 80);
            this.abort_btn.Name = "abort_btn";
            this.abort_btn.Size = new System.Drawing.Size(267, 48);
            this.abort_btn.TabIndex = 1;
            this.abort_btn.Text = "Annuler";
            this.abort_btn.UseVisualStyleBackColor = true;
            this.abort_btn.Click += new System.EventHandler(this.abort_btn_Click);
            // 
            // sub_btn
            // 
            this.sub_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sub_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sub_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sub_btn.Location = new System.Drawing.Point(10, 14);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(267, 48);
            this.sub_btn.TabIndex = 0;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // venteTable
            // 
            this.venteTable.AllowUserToAddRows = false;
            this.venteTable.AllowUserToDeleteRows = false;
            this.venteTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.venteTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.venteTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.venteTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.venteTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.venteTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.venteTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.venteTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.venteTable.ColumnHeadersHeight = 60;
            this.venteTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeBarreCol,
            this.nom,
            this.QNT,
            this.prixU,
            this.remiseCol,
            this.Total});
            this.venteTable.EnableHeadersVisualStyles = false;
            this.venteTable.GridColor = System.Drawing.Color.White;
            this.venteTable.Location = new System.Drawing.Point(299, 208);
            this.venteTable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.venteTable.MultiSelect = false;
            this.venteTable.Name = "venteTable";
            this.venteTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.venteTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.venteTable.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.venteTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.venteTable.RowTemplate.Height = 40;
            this.venteTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.venteTable.Size = new System.Drawing.Size(681, 358);
            this.venteTable.TabIndex = 2;
            this.venteTable.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.venteTable_CellBeginEdit);
            this.venteTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.venteTable_CellEndEdit);
            this.venteTable.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.venteTable_EditingControlShowing);
            this.venteTable.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.venteTable_RowStateChanged);
            // 
            // codeBarreCol
            // 
            this.codeBarreCol.DataPropertyName = "codeBarre";
            this.codeBarreCol.HeaderText = "codeBarre";
            this.codeBarreCol.Name = "codeBarreCol";
            this.codeBarreCol.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom Article";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // QNT
            // 
            this.QNT.DataPropertyName = "quantité";
            this.QNT.HeaderText = "Quantité";
            this.QNT.Name = "QNT";
            // 
            // prixU
            // 
            this.prixU.DataPropertyName = "prixVente";
            this.prixU.HeaderText = "P.U";
            this.prixU.Name = "prixU";
            this.prixU.ReadOnly = true;
            // 
            // remiseCol
            // 
            this.remiseCol.HeaderText = "Remise";
            this.remiseCol.Name = "remiseCol";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // vente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(992, 578);
            this.Controls.Add(this.venteTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "vente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.vente_FormClosing);
            this.Load += new System.EventHandler(this.vente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.venteTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView venteTable;
        private System.Windows.Forms.Label codeBarreLabel;
        private System.Windows.Forms.Label nbrArticleLabel;
        private System.Windows.Forms.Label nbrPieceLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.ComboBox client_combo;
        private System.Windows.Forms.TextBox remise_txt;
        private System.Windows.Forms.TextBox codeBarre_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button listArticle_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button abort_btn;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeBarreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn QNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixU;
        private System.Windows.Forms.DataGridViewTextBoxColumn remiseCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}