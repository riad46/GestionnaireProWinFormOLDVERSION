
namespace Gestionnaire_Pro
{
    partial class utilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(utilisateur));
            this.userTable = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.numTlf_txt = new System.Windows.Forms.TextBox();
            this.estAdmin = new System.Windows.Forms.CheckBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.modify_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.sub_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            this.SuspendLayout();
            // 
            // userTable
            // 
            this.userTable.AllowUserToAddRows = false;
            this.userTable.AllowUserToDeleteRows = false;
            this.userTable.AllowUserToOrderColumns = true;
            this.userTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.usernameCol,
            this.passCol,
            this.numCol,
            this.AdminCol});
            this.userTable.Location = new System.Drawing.Point(12, 12);
            this.userTable.MultiSelect = false;
            this.userTable.Name = "userTable";
            this.userTable.ReadOnly = true;
            this.userTable.RowTemplate.Height = 25;
            this.userTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userTable.Size = new System.Drawing.Size(580, 288);
            this.userTable.TabIndex = 0;
            // 
            // idCol
            // 
            this.idCol.DataPropertyName = "Id";
            this.idCol.HeaderText = "Id";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            // 
            // usernameCol
            // 
            this.usernameCol.DataPropertyName = "nomUtilisateur";
            this.usernameCol.HeaderText = "Nom d\'utilisateur";
            this.usernameCol.Name = "usernameCol";
            this.usernameCol.ReadOnly = true;
            // 
            // passCol
            // 
            this.passCol.DataPropertyName = "motDePass";
            this.passCol.HeaderText = "Mot de Passe";
            this.passCol.Name = "passCol";
            this.passCol.ReadOnly = true;
            this.passCol.Visible = false;
            // 
            // numCol
            // 
            this.numCol.DataPropertyName = "numTlf";
            this.numCol.HeaderText = "N° Téléphone";
            this.numCol.Name = "numCol";
            this.numCol.ReadOnly = true;
            // 
            // AdminCol
            // 
            this.AdminCol.DataPropertyName = "estAdmin";
            this.AdminCol.FalseValue = "0";
            this.AdminCol.HeaderText = "Admin";
            this.AdminCol.Name = "AdminCol";
            this.AdminCol.ReadOnly = true;
            this.AdminCol.TrueValue = "1";
            // 
            // username_txt
            // 
            this.username_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.username_txt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_txt.Location = new System.Drawing.Point(188, 312);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(189, 32);
            this.username_txt.TabIndex = 1;
            // 
            // pass_txt
            // 
            this.pass_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pass_txt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass_txt.Location = new System.Drawing.Point(188, 367);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(189, 32);
            this.pass_txt.TabIndex = 2;
            // 
            // numTlf_txt
            // 
            this.numTlf_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numTlf_txt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numTlf_txt.Location = new System.Drawing.Point(188, 414);
            this.numTlf_txt.Name = "numTlf_txt";
            this.numTlf_txt.Size = new System.Drawing.Size(189, 32);
            this.numTlf_txt.TabIndex = 3;
            // 
            // estAdmin
            // 
            this.estAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.estAdmin.AutoSize = true;
            this.estAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.estAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.estAdmin.Location = new System.Drawing.Point(188, 468);
            this.estAdmin.Name = "estAdmin";
            this.estAdmin.Size = new System.Drawing.Size(133, 25);
            this.estAdmin.TabIndex = 4;
            this.estAdmin.Text = "Administrateur";
            this.estAdmin.UseVisualStyleBackColor = true;
            // 
            // lab1
            // 
            this.lab1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab1.ForeColor = System.Drawing.SystemColors.Control;
            this.lab1.Location = new System.Drawing.Point(12, 319);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(170, 25);
            this.lab1.TabIndex = 5;
            this.lab1.Text = "Nom d\'Utilisateur";
            // 
            // lab2
            // 
            this.lab2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab2.ForeColor = System.Drawing.SystemColors.Control;
            this.lab2.Location = new System.Drawing.Point(12, 366);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(129, 25);
            this.lab2.TabIndex = 6;
            this.lab2.Text = "Mot de Passe";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "N° Téléphone";
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.add_btn.Location = new System.Drawing.Point(622, 25);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(155, 51);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "Ajouter";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // modify_btn
            // 
            this.modify_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modify_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.modify_btn.Location = new System.Drawing.Point(622, 105);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(155, 51);
            this.modify_btn.TabIndex = 9;
            this.modify_btn.Text = "Modifier";
            this.modify_btn.UseVisualStyleBackColor = true;
            this.modify_btn.Click += new System.EventHandler(this.modify_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.del_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.del_btn.Location = new System.Drawing.Point(622, 185);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(155, 51);
            this.del_btn.TabIndex = 10;
            this.del_btn.Text = "Supprimer";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // sub_btn
            // 
            this.sub_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sub_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sub_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.sub_btn.Location = new System.Drawing.Point(396, 312);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(155, 51);
            this.sub_btn.TabIndex = 11;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.modify_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.estAdmin);
            this.Controls.Add(this.numTlf_txt);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.userTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "utilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "utilisateur";
            this.Load += new System.EventHandler(this.utilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.TextBox numTlf_txt;
        private System.Windows.Forms.CheckBox estAdmin;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button modify_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn passCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AdminCol;
    }
}