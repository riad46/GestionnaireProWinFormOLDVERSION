
namespace Gestionnaire_Pro
{
    partial class ajoutFacture
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
            this.venteTable = new System.Windows.Forms.DataGridView();
            this.codeBarreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remiseCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.print_checkBox = new System.Windows.Forms.CheckBox();
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.nbrPieceLabel = new System.Windows.Forms.Label();
            this.nbrArticleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.codeBarreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.venteTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // venteTable
            // 
            this.venteTable.AllowUserToAddRows = false;
            this.venteTable.AllowUserToDeleteRows = false;
            this.venteTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.venteTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.venteTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.venteTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.venteTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.venteTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.venteTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.venteTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.venteTable.Location = new System.Drawing.Point(313, 208);
            this.venteTable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.venteTable.MultiSelect = false;
            this.venteTable.Name = "venteTable";
            this.venteTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.venteTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.venteTable.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.venteTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.venteTable.RowTemplate.Height = 40;
            this.venteTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.venteTable.Size = new System.Drawing.Size(690, 482);
            this.venteTable.TabIndex = 5;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.print_checkBox);
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
            this.panel2.Size = new System.Drawing.Size(304, 690);
            this.panel2.TabIndex = 4;
            // 
            // print_checkBox
            // 
            this.print_checkBox.AutoSize = true;
            this.print_checkBox.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.print_checkBox.ForeColor = System.Drawing.Color.White;
            this.print_checkBox.Location = new System.Drawing.Point(70, 147);
            this.print_checkBox.Name = "print_checkBox";
            this.print_checkBox.Size = new System.Drawing.Size(172, 23);
            this.print_checkBox.TabIndex = 10;
            this.print_checkBox.Text = "Imprimer une Facture";
            this.print_checkBox.UseVisualStyleBackColor = true;
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
            this.listArticle_btn.ForeColor = System.Drawing.Color.White;
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
            this.panel3.Size = new System.Drawing.Size(404, 963);
            this.panel3.TabIndex = 2;
            // 
            // del_btn
            // 
            this.del_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.del_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Location = new System.Drawing.Point(21, 143);
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
            this.abort_btn.ForeColor = System.Drawing.Color.White;
            this.abort_btn.Location = new System.Drawing.Point(21, 77);
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
            this.sub_btn.ForeColor = System.Drawing.Color.White;
            this.sub_btn.Location = new System.Drawing.Point(21, 11);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(267, 48);
            this.sub_btn.TabIndex = 0;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalLabel.Font = new System.Drawing.Font("SimSun-ExtB", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalLabel.Location = new System.Drawing.Point(279, 120);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(406, 78);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "00.00 DA";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.Font = new System.Drawing.Font("SimSun-ExtB", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateLabel.Location = new System.Drawing.Point(386, 10);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(296, 48);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "11/11/1111 00:00:00";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nbrPieceLabel
            // 
            this.nbrPieceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nbrPieceLabel.AutoSize = true;
            this.nbrPieceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nbrPieceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nbrPieceLabel.Location = new System.Drawing.Point(112, 167);
            this.nbrPieceLabel.Name = "nbrPieceLabel";
            this.nbrPieceLabel.Size = new System.Drawing.Size(81, 19);
            this.nbrPieceLabel.TabIndex = 7;
            this.nbrPieceLabel.Text = "NBR piece";
            // 
            // nbrArticleLabel
            // 
            this.nbrArticleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nbrArticleLabel.AutoSize = true;
            this.nbrArticleLabel.BackColor = System.Drawing.Color.Transparent;
            this.nbrArticleLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nbrArticleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nbrArticleLabel.Location = new System.Drawing.Point(12, 167);
            this.nbrArticleLabel.Name = "nbrArticleLabel";
            this.nbrArticleLabel.Size = new System.Drawing.Size(82, 19);
            this.nbrArticleLabel.TabIndex = 8;
            this.nbrArticleLabel.Text = "Nbr article";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.codeBarreLabel);
            this.panel1.Controls.Add(this.nbrArticleLabel);
            this.panel1.Controls.Add(this.nbrPieceLabel);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.totalLabel);
            this.panel1.Location = new System.Drawing.Point(310, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 202);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // codeBarreLabel
            // 
            this.codeBarreLabel.Font = new System.Drawing.Font("SimSun-ExtB", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codeBarreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.codeBarreLabel.Location = new System.Drawing.Point(3, 9);
            this.codeBarreLabel.Name = "codeBarreLabel";
            this.codeBarreLabel.Size = new System.Drawing.Size(193, 48);
            this.codeBarreLabel.TabIndex = 6;
            this.codeBarreLabel.Text = "codebarre";
            this.codeBarreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ajoutFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1004, 690);
            this.Controls.Add(this.venteTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ajoutFacture";
            this.Text = "Nouvelle Facture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ajoutFacture_FormClosing);
            this.Load += new System.EventHandler(this.ajoutFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.venteTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView venteTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeBarreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn QNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixU;
        private System.Windows.Forms.DataGridViewTextBoxColumn remiseCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button listArticle_btn;
        private System.Windows.Forms.ComboBox client_combo;
        private System.Windows.Forms.TextBox remise_txt;
        private System.Windows.Forms.TextBox codeBarre_txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button abort_btn;
        private System.Windows.Forms.Button sub_btn;
     
       
       
        
        
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label nbrPieceLabel;
        private System.Windows.Forms.Label nbrArticleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label codeBarreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox print_checkBox;
    }
}