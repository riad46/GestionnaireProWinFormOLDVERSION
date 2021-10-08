
namespace Gestionnaire_Pro
{
    partial class Notification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.delQntArticle_btn = new System.Windows.Forms.Button();
            this.addQntArticle_btn = new System.Windows.Forms.Button();
            this.qntArticlesTable = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeBarreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.qnt_txt = new System.Windows.Forms.TextBox();
            this.LB1 = new System.Windows.Forms.Label();
            this.ActivateQntNotificationSys_CheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.delDateArticle_btn = new System.Windows.Forms.Button();
            this.addDateArticle_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateArticlesTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.days_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ActivateDateNotificationSys_CheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qntArticlesTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateArticlesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.delQntArticle_btn);
            this.tabPage1.Controls.Add(this.addQntArticle_btn);
            this.tabPage1.Controls.Add(this.qntArticlesTable);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.qnt_txt);
            this.tabPage1.Controls.Add(this.LB1);
            this.tabPage1.Controls.Add(this.ActivateQntNotificationSys_CheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quantité ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // delQntArticle_btn
            // 
            this.delQntArticle_btn.BackColor = System.Drawing.Color.White;
            this.delQntArticle_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delQntArticle_btn.FlatAppearance.BorderSize = 2;
            this.delQntArticle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delQntArticle_btn.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.delQntArticle_btn.ForeColor = System.Drawing.Color.White;
            this.delQntArticle_btn.Location = new System.Drawing.Point(508, 113);
            this.delQntArticle_btn.Name = "delQntArticle_btn";
            this.delQntArticle_btn.Size = new System.Drawing.Size(163, 35);
            this.delQntArticle_btn.TabIndex = 16;
            this.delQntArticle_btn.Text = "Supprimer Article";
            this.delQntArticle_btn.UseVisualStyleBackColor = false;
            this.delQntArticle_btn.Click += new System.EventHandler(this.delQntArticle_btn_Click);
            // 
            // addQntArticle_btn
            // 
            this.addQntArticle_btn.BackColor = System.Drawing.Color.White;
            this.addQntArticle_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addQntArticle_btn.FlatAppearance.BorderSize = 2;
            this.addQntArticle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addQntArticle_btn.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.addQntArticle_btn.ForeColor = System.Drawing.Color.White;
            this.addQntArticle_btn.Location = new System.Drawing.Point(339, 113);
            this.addQntArticle_btn.Name = "addQntArticle_btn";
            this.addQntArticle_btn.Size = new System.Drawing.Size(163, 35);
            this.addQntArticle_btn.TabIndex = 15;
            this.addQntArticle_btn.Text = "Ajouter Article";
            this.addQntArticle_btn.UseVisualStyleBackColor = false;
            this.addQntArticle_btn.Click += new System.EventHandler(this.addQntArticle_btn_Click);
            // 
            // qntArticlesTable
            // 
            this.qntArticlesTable.AllowUserToAddRows = false;
            this.qntArticlesTable.AllowUserToDeleteRows = false;
            this.qntArticlesTable.AllowUserToOrderColumns = true;
            this.qntArticlesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qntArticlesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qntArticlesTable.BackgroundColor = System.Drawing.Color.White;
            this.qntArticlesTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.qntArticlesTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.qntArticlesTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.qntArticlesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.qntArticlesTable.ColumnHeadersHeight = 45;
            this.qntArticlesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.codeBarreCol,
            this.nomCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.qntArticlesTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.qntArticlesTable.EnableHeadersVisualStyles = false;
            this.qntArticlesTable.GridColor = System.Drawing.Color.White;
            this.qntArticlesTable.Location = new System.Drawing.Point(3, 154);
            this.qntArticlesTable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.qntArticlesTable.Name = "qntArticlesTable";
            this.qntArticlesTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.qntArticlesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.qntArticlesTable.RowHeadersVisible = false;
            this.qntArticlesTable.RowTemplate.Height = 25;
            this.qntArticlesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.qntArticlesTable.Size = new System.Drawing.Size(765, 395);
            this.qntArticlesTable.TabIndex = 14;
            // 
            // idCol
            // 
            this.idCol.DataPropertyName = "Id";
            this.idCol.HeaderText = "Réf";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            // 
            // codeBarreCol
            // 
            this.codeBarreCol.DataPropertyName = "codeBarre";
            this.codeBarreCol.HeaderText = "code_Barre";
            this.codeBarreCol.Name = "codeBarreCol";
            this.codeBarreCol.ReadOnly = true;
            // 
            // nomCol
            // 
            this.nomCol.DataPropertyName = "nom";
            this.nomCol.HeaderText = "Nom Article";
            this.nomCol.Name = "nomCol";
            this.nomCol.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Exclu ces Articles du Vérification :";
            // 
            // qnt_txt
            // 
            this.qnt_txt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qnt_txt.Location = new System.Drawing.Point(458, 55);
            this.qnt_txt.Name = "qnt_txt";
            this.qnt_txt.PlaceholderText = "Quantité";
            this.qnt_txt.Size = new System.Drawing.Size(123, 35);
            this.qnt_txt.TabIndex = 12;
            this.qnt_txt.TextChanged += new System.EventHandler(this.qnt_txt_TextChanged);
            this.qnt_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qnt_txt_KeyPress);
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.BackColor = System.Drawing.Color.White;
            this.LB1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LB1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LB1.Location = new System.Drawing.Point(7, 61);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(445, 24);
            this.LB1.TabIndex = 11;
            this.LB1.Text = "Me Notifier si un Article a du Quantité Inférieur a";
            // 
            // ActivateQntNotificationSys_CheckBox
            // 
            this.ActivateQntNotificationSys_CheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ActivateQntNotificationSys_CheckBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ActivateQntNotificationSys_CheckBox.Location = new System.Drawing.Point(172, 6);
            this.ActivateQntNotificationSys_CheckBox.Name = "ActivateQntNotificationSys_CheckBox";
            this.ActivateQntNotificationSys_CheckBox.Size = new System.Drawing.Size(458, 43);
            this.ActivateQntNotificationSys_CheckBox.TabIndex = 10;
            this.ActivateQntNotificationSys_CheckBox.Text = "Activer les Notifications du Stock Resté";
            this.ActivateQntNotificationSys_CheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.delDateArticle_btn);
            this.tabPage2.Controls.Add(this.addDateArticle_btn);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dateArticlesTable);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.days_txt);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ActivateDateNotificationSys_CheckBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Date";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // delDateArticle_btn
            // 
            this.delDateArticle_btn.BackColor = System.Drawing.Color.White;
            this.delDateArticle_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delDateArticle_btn.FlatAppearance.BorderSize = 2;
            this.delDateArticle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delDateArticle_btn.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.delDateArticle_btn.ForeColor = System.Drawing.Color.White;
            this.delDateArticle_btn.Location = new System.Drawing.Point(507, 121);
            this.delDateArticle_btn.Name = "delDateArticle_btn";
            this.delDateArticle_btn.Size = new System.Drawing.Size(163, 35);
            this.delDateArticle_btn.TabIndex = 26;
            this.delDateArticle_btn.Text = "Supprimer Article";
            this.delDateArticle_btn.UseVisualStyleBackColor = false;
            this.delDateArticle_btn.Click += new System.EventHandler(this.delDateArticle_btn_Click);
            // 
            // addDateArticle_btn
            // 
            this.addDateArticle_btn.BackColor = System.Drawing.Color.White;
            this.addDateArticle_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addDateArticle_btn.FlatAppearance.BorderSize = 2;
            this.addDateArticle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDateArticle_btn.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.addDateArticle_btn.ForeColor = System.Drawing.Color.White;
            this.addDateArticle_btn.Location = new System.Drawing.Point(338, 121);
            this.addDateArticle_btn.Name = "addDateArticle_btn";
            this.addDateArticle_btn.Size = new System.Drawing.Size(163, 35);
            this.addDateArticle_btn.TabIndex = 25;
            this.addDateArticle_btn.Text = "Ajouter Article";
            this.addDateArticle_btn.UseVisualStyleBackColor = false;
            this.addDateArticle_btn.Click += new System.EventHandler(this.addDateArticle_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Exclu ces Articles du Vérification :";
            // 
            // dateArticlesTable
            // 
            this.dateArticlesTable.AllowUserToAddRows = false;
            this.dateArticlesTable.AllowUserToDeleteRows = false;
            this.dateArticlesTable.AllowUserToOrderColumns = true;
            this.dateArticlesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateArticlesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dateArticlesTable.BackgroundColor = System.Drawing.Color.White;
            this.dateArticlesTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateArticlesTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dateArticlesTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dateArticlesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dateArticlesTable.ColumnHeadersHeight = 45;
            this.dateArticlesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dateArticlesTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.dateArticlesTable.EnableHeadersVisualStyles = false;
            this.dateArticlesTable.GridColor = System.Drawing.Color.White;
            this.dateArticlesTable.Location = new System.Drawing.Point(5, 169);
            this.dateArticlesTable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dateArticlesTable.Name = "dateArticlesTable";
            this.dateArticlesTable.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dateArticlesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dateArticlesTable.RowHeadersVisible = false;
            this.dateArticlesTable.RowTemplate.Height = 25;
            this.dateArticlesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dateArticlesTable.Size = new System.Drawing.Size(766, 392);
            this.dateArticlesTable.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Réf";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codeBarre";
            this.dataGridViewTextBoxColumn2.HeaderText = "code_Barre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nom Article";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(669, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "jours";
            // 
            // days_txt
            // 
            this.days_txt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.days_txt.Location = new System.Drawing.Point(565, 67);
            this.days_txt.Name = "days_txt";
            this.days_txt.PlaceholderText = "Jours";
            this.days_txt.Size = new System.Drawing.Size(92, 35);
            this.days_txt.TabIndex = 21;
            this.days_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.days_txt_KeyPress);
            this.days_txt.Leave += new System.EventHandler(this.days_txt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(555, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Me Notifier si la Date d\'Expiration d\'un Article est Inférieur a ";
            // 
            // ActivateDateNotificationSys_CheckBox
            // 
            this.ActivateDateNotificationSys_CheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ActivateDateNotificationSys_CheckBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ActivateDateNotificationSys_CheckBox.Location = new System.Drawing.Point(164, 6);
            this.ActivateDateNotificationSys_CheckBox.Name = "ActivateDateNotificationSys_CheckBox";
            this.ActivateDateNotificationSys_CheckBox.Size = new System.Drawing.Size(501, 43);
            this.ActivateDateNotificationSys_CheckBox.TabIndex = 19;
            this.ActivateDateNotificationSys_CheckBox.Text = "Activer les Notifications du Date d\'Expiration";
            this.ActivateDateNotificationSys_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 598);
            this.Controls.Add(this.tabControl1);
            this.Name = "Notification";
            this.Text = "Notification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notification_FormClosing);
            this.Load += new System.EventHandler(this.Notification_FormLoad);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qntArticlesTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateArticlesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView qntArticlesTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qnt_txt;
        private System.Windows.Forms.Label LB1;
        private System.Windows.Forms.CheckBox ActivateQntNotificationSys_CheckBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox days_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ActivateDateNotificationSys_CheckBox;
        private System.Windows.Forms.Button addQntArticle_btn;
        private System.Windows.Forms.DataGridView dateArticlesTable;
        private System.Windows.Forms.Button addDateArticle_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delQntArticle_btn;
        private System.Windows.Forms.Button delDateArticle_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeBarreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}