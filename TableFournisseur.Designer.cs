
namespace Gestionnaire_Pro
{
    partial class TableFournisseur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableFournisseur));
            this.fournisseurTable = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTlfCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.credit_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num_txt = new System.Windows.Forms.TextBox();
            this.nom_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.del_btn = new System.Windows.Forms.Button();
            this.modify_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fournisseurTable
            // 
            this.fournisseurTable.AllowUserToAddRows = false;
            this.fournisseurTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.fournisseurTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fournisseurTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fournisseurTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fournisseurTable.BackgroundColor = System.Drawing.Color.White;
            this.fournisseurTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fournisseurTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.fournisseurTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fournisseurTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.fournisseurTable.ColumnHeadersHeight = 58;
            this.fournisseurTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.fournisseurTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.nomCol,
            this.numTlfCol,
            this.addressCol,
            this.creditCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fournisseurTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.fournisseurTable.EnableHeadersVisualStyles = false;
            this.fournisseurTable.GridColor = System.Drawing.Color.CadetBlue;
            this.fournisseurTable.Location = new System.Drawing.Point(0, 105);
            this.fournisseurTable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.fournisseurTable.MultiSelect = false;
            this.fournisseurTable.Name = "fournisseurTable";
            this.fournisseurTable.ReadOnly = true;
            this.fournisseurTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.fournisseurTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.fournisseurTable.RowHeadersVisible = false;
            this.fournisseurTable.RowHeadersWidth = 55;
            this.fournisseurTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.fournisseurTable.RowTemplate.Height = 50;
            this.fournisseurTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fournisseurTable.Size = new System.Drawing.Size(613, 345);
            this.fournisseurTable.TabIndex = 0;
            // 
            // idCol
            // 
            this.idCol.DataPropertyName = "id";
            this.idCol.HeaderText = "Ref";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            // 
            // nomCol
            // 
            this.nomCol.DataPropertyName = "nom";
            this.nomCol.HeaderText = "Nom";
            this.nomCol.Name = "nomCol";
            this.nomCol.ReadOnly = true;
            // 
            // numTlfCol
            // 
            this.numTlfCol.DataPropertyName = "numTlf";
            this.numTlfCol.HeaderText = "N° Téléphone";
            this.numTlfCol.Name = "numTlfCol";
            this.numTlfCol.ReadOnly = true;
            // 
            // addressCol
            // 
            this.addressCol.DataPropertyName = "Address";
            this.addressCol.HeaderText = "Address";
            this.addressCol.Name = "addressCol";
            this.addressCol.ReadOnly = true;
            // 
            // creditCol
            // 
            this.creditCol.DataPropertyName = "creditArendre";
            this.creditCol.HeaderText = "Crédit a Rendre";
            this.creditCol.Name = "creditCol";
            this.creditCol.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.credit_txt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.num_txt);
            this.panel1.Controls.Add(this.nom_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 97);
            this.panel1.TabIndex = 4;
            // 
            // credit_txt
            // 
            this.credit_txt.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.credit_txt.Location = new System.Drawing.Point(640, 37);
            this.credit_txt.Name = "credit_txt";
            this.credit_txt.Size = new System.Drawing.Size(93, 31);
            this.credit_txt.TabIndex = 9;
            this.credit_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(502, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Crédit A rendre";
            // 
            // num_txt
            // 
            this.num_txt.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_txt.Location = new System.Drawing.Point(340, 37);
            this.num_txt.Name = "num_txt";
            this.num_txt.Size = new System.Drawing.Size(136, 31);
            this.num_txt.TabIndex = 11;
            this.num_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // nom_txt
            // 
            this.nom_txt.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nom_txt.Location = new System.Drawing.Point(66, 34);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(142, 31);
            this.nom_txt.TabIndex = 10;
            this.nom_txt.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(217, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "N° Téléphone";
            // 
            // del_btn
            // 
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Location = new System.Drawing.Point(9, 112);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(169, 46);
            this.del_btn.TabIndex = 7;
            this.del_btn.Text = "Supprimer";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // modify_btn
            // 
            this.modify_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modify_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modify_btn.ForeColor = System.Drawing.Color.White;
            this.modify_btn.Location = new System.Drawing.Point(9, 60);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(169, 46);
            this.modify_btn.TabIndex = 6;
            this.modify_btn.Text = "Modifier";
            this.modify_btn.UseVisualStyleBackColor = true;
            this.modify_btn.Click += new System.EventHandler(this.modify_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(9, 8);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(169, 46);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Ajouter";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.add_btn);
            this.panel2.Controls.Add(this.del_btn);
            this.panel2.Controls.Add(this.modify_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(619, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 360);
            this.panel2.TabIndex = 5;
            // 
            // TableFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fournisseurTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableFournisseur";
            this.Text = "Table Fournisseur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableFournisseur_FormClosing);
            this.Load += new System.EventHandler(this.TableFournisseur_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fournisseurTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTlfCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button modify_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox credit_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num_txt;
        private System.Windows.Forms.TextBox nom_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}