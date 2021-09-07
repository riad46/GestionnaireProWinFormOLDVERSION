
namespace Gestionnaire_Pro
{
    partial class paimentCreditClient
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sub_btn = new System.Windows.Forms.Button();
            this.creditAjout_txt = new System.Windows.Forms.TextBox();
            this.creditInit_txt = new System.Windows.Forms.TextBox();
            this.client_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Montant a ajouté";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Credit ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Client";
            // 
            // sub_btn
            // 
            this.sub_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sub_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sub_btn.Location = new System.Drawing.Point(21, 410);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(268, 60);
            this.sub_btn.TabIndex = 11;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // creditAjout_txt
            // 
            this.creditAjout_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.creditAjout_txt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creditAjout_txt.Location = new System.Drawing.Point(21, 347);
            this.creditAjout_txt.Name = "creditAjout_txt";
            this.creditAjout_txt.Size = new System.Drawing.Size(268, 39);
            this.creditAjout_txt.TabIndex = 10;
            this.creditAjout_txt.TextChanged += new System.EventHandler(this.creditAjout_txt_TextChanged);
            this.creditAjout_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.creditAjout_txt_KeyPress);
            // 
            // creditInit_txt
            // 
            this.creditInit_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.creditInit_txt.Enabled = false;
            this.creditInit_txt.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creditInit_txt.Location = new System.Drawing.Point(23, 229);
            this.creditInit_txt.Name = "creditInit_txt";
            this.creditInit_txt.Size = new System.Drawing.Size(268, 39);
            this.creditInit_txt.TabIndex = 9;
            // 
            // client_combo
            // 
            this.client_combo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.client_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.client_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.client_combo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.client_combo.FormattingEnabled = true;
            this.client_combo.Location = new System.Drawing.Point(23, 141);
            this.client_combo.Name = "client_combo";
            this.client_combo.Size = new System.Drawing.Size(266, 39);
            this.client_combo.TabIndex = 8;
            this.client_combo.SelectedIndexChanged += new System.EventHandler(this.client_combo_SelectedIndexChanged);
            // 
            // paimentCreditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(316, 513);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.creditAjout_txt);
            this.Controls.Add(this.creditInit_txt);
            this.Controls.Add(this.client_combo);
            this.Name = "paimentCreditClient";
            this.Text = "paimentCreditClient";
            this.Load += new System.EventHandler(this.paimentCreditClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.TextBox creditAjout_txt;
        private System.Windows.Forms.TextBox creditInit_txt;
        private System.Windows.Forms.ComboBox client_combo;
    }
}