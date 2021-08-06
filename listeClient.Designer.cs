
namespace Gestionnaire_Pro
{
    partial class listeClient
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
            this.tableClient = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numTlf_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nom_txt = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableClient)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableClient
            // 
            this.tableClient.AllowUserToAddRows = false;
            this.tableClient.AllowUserToDeleteRows = false;
            this.tableClient.AllowUserToOrderColumns = true;
            this.tableClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableClient.BackgroundColor = System.Drawing.SystemColors.Info;
            this.tableClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nom,
            this.address,
            this.num,
            this.credit});
            this.tableClient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableClient.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.tableClient.Location = new System.Drawing.Point(0, 155);
            this.tableClient.MultiSelect = false;
            this.tableClient.Name = "tableClient";
            this.tableClient.ReadOnly = true;
            this.tableClient.RowTemplate.Height = 25;
            this.tableClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableClient.Size = new System.Drawing.Size(557, 378);
            this.tableClient.TabIndex = 0;
            this.tableClient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableClient_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.numTlf_txt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nom_txt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 149);
            this.panel1.TabIndex = 1;
            // 
            // numTlf_txt
            // 
            this.numTlf_txt.Location = new System.Drawing.Point(350, 43);
            this.numTlf_txt.Name = "numTlf_txt";
            this.numTlf_txt.Size = new System.Drawing.Size(173, 23);
            this.numTlf_txt.TabIndex = 3;
            this.numTlf_txt.TextChanged += new System.EventHandler(this.numTlf_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "N° Téléphone";
            // 
            // nom_txt
            // 
            this.nom_txt.Location = new System.Drawing.Point(68, 43);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(173, 23);
            this.nom_txt.TabIndex = 0;
            this.nom_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Réf";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "adress";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
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
            // listeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(557, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableClient);
            this.Name = "listeClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listeClient";
            this.Load += new System.EventHandler(this.listeClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableClient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nom_txt;
        private System.Windows.Forms.TextBox numTlf_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
    }
}