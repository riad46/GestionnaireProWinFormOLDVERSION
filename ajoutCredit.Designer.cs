﻿
namespace Gestionnaire_Pro
{
    partial class ajoutCredit
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
            this.client_combo = new System.Windows.Forms.ComboBox();
            this.creditInit_txt = new System.Windows.Forms.TextBox();
            this.creditAjout_txt = new System.Windows.Forms.TextBox();
            this.sub_btn = new System.Windows.Forms.Button();
            this.details_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // client_combo
            // 
            this.client_combo.FormattingEnabled = true;
            this.client_combo.Location = new System.Drawing.Point(47, 58);
            this.client_combo.Name = "client_combo";
            this.client_combo.Size = new System.Drawing.Size(266, 23);
            this.client_combo.TabIndex = 0;
            this.client_combo.SelectedIndexChanged += new System.EventHandler(this.client_combo_SelectedIndexChanged);
            // 
            // creditInit_txt
            // 
            this.creditInit_txt.Location = new System.Drawing.Point(47, 146);
            this.creditInit_txt.Name = "creditInit_txt";
            this.creditInit_txt.Size = new System.Drawing.Size(268, 23);
            this.creditInit_txt.TabIndex = 1;
            this.creditInit_txt.TextChanged += new System.EventHandler(this.creditInit_txt_TextChanged);
            // 
            // creditAjout_txt
            // 
            this.creditAjout_txt.Location = new System.Drawing.Point(47, 252);
            this.creditAjout_txt.Name = "creditAjout_txt";
            this.creditAjout_txt.Size = new System.Drawing.Size(268, 23);
            this.creditAjout_txt.TabIndex = 2;
            this.creditAjout_txt.TextChanged += new System.EventHandler(this.creditAjout_txt_TextChanged);
            this.creditAjout_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.creditAjout_txt_KeyPress);
            // 
            // sub_btn
            // 
            this.sub_btn.Location = new System.Drawing.Point(45, 327);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(268, 60);
            this.sub_btn.TabIndex = 3;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // details_btn
            // 
            this.details_btn.Location = new System.Drawing.Point(45, 419);
            this.details_btn.Name = "details_btn";
            this.details_btn.Size = new System.Drawing.Size(268, 60);
            this.details_btn.TabIndex = 4;
            this.details_btn.Text = "Ajouter Avec Detail";
            this.details_btn.UseVisualStyleBackColor = true;
            this.details_btn.Click += new System.EventHandler(this.details_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Credit ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Montant a ajouté";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ajoutCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 491);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.details_btn);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.creditAjout_txt);
            this.Controls.Add(this.creditInit_txt);
            this.Controls.Add(this.client_combo);
            this.Name = "ajoutCredit";
            this.Text = "ajoutCredit";
            this.Load += new System.EventHandler(this.ajoutCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox client_combo;
        private System.Windows.Forms.TextBox creditInit_txt;
        private System.Windows.Forms.TextBox creditAjout_txt;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Button details_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}