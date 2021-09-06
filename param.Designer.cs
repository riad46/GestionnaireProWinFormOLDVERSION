
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sub_btn = new Gestionnaire_Pro.Assets.RoundButton();
            this.loginAcrive_checkBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.sub_btn);
            this.panel1.Controls.Add(this.loginAcrive_checkBox);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 394);
            this.panel1.TabIndex = 0;
            // 
            // sub_btn
            // 
            this.sub_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sub_btn.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sub_btn.Location = new System.Drawing.Point(65, 317);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(306, 61);
            this.sub_btn.TabIndex = 1;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // loginAcrive_checkBox
            // 
            this.loginAcrive_checkBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginAcrive_checkBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginAcrive_checkBox.Location = new System.Drawing.Point(52, 14);
            this.loginAcrive_checkBox.Name = "loginAcrive_checkBox";
            this.loginAcrive_checkBox.Size = new System.Drawing.Size(354, 42);
            this.loginAcrive_checkBox.TabIndex = 0;
            this.loginAcrive_checkBox.Text = "Utilisé System d\'Authentification";
            this.loginAcrive_checkBox.UseVisualStyleBackColor = true;
            // 
            // param
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "param";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "param";
            this.Load += new System.EventHandler(this.param_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox loginAcrive_checkBox;
        private Assets.RoundButton sub_btn;
    }
}