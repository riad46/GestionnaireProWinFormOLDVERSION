
namespace Gestionnaire_Pro
{
    partial class param
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
            this.sub_btn = new Gestionnaire_Pro.Assets.RoundButton();
            this.loginAcrive_checkBox = new System.Windows.Forms.CheckBox();
            this.autoCodeBarre_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sub_btn
            // 
            this.sub_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sub_btn.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sub_btn.Location = new System.Drawing.Point(113, 149);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(306, 61);
            this.sub_btn.TabIndex = 3;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // loginAcrive_checkBox
            // 
            this.loginAcrive_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginAcrive_checkBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginAcrive_checkBox.Location = new System.Drawing.Point(113, 43);
            this.loginAcrive_checkBox.Name = "loginAcrive_checkBox";
            this.loginAcrive_checkBox.Size = new System.Drawing.Size(354, 42);
            this.loginAcrive_checkBox.TabIndex = 2;
            this.loginAcrive_checkBox.Text = "Utilisé System d\'Authentification";
            this.loginAcrive_checkBox.UseVisualStyleBackColor = true;
            // 
            // autoCodeBarre_checkBox
            // 
            this.autoCodeBarre_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.autoCodeBarre_checkBox.AutoSize = true;
            this.autoCodeBarre_checkBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoCodeBarre_checkBox.Location = new System.Drawing.Point(42, 105);
            this.autoCodeBarre_checkBox.Name = "autoCodeBarre_checkBox";
            this.autoCodeBarre_checkBox.Size = new System.Drawing.Size(497, 28);
            this.autoCodeBarre_checkBox.TabIndex = 4;
            this.autoCodeBarre_checkBox.Text = "Génération Automatique du Code_Barre des Articles";
            this.autoCodeBarre_checkBox.UseVisualStyleBackColor = true;
            // 
            // param
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.autoCodeBarre_checkBox);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.loginAcrive_checkBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "param";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paramètre";
            this.Load += new System.EventHandler(this.param_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox loginAcrive_checkBox;
        private Assets.RoundButton sub_btn;
        private System.Windows.Forms.CheckBox autoCodeBarre_checkBox;
    }
}