
namespace Gestionnaire_Pro
{
    partial class VenteChoices
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
            this.historique_btn = new System.Windows.Forms.Button();
            this.nvVente_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historique_btn
            // 
            this.historique_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.historique_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historique_btn.Location = new System.Drawing.Point(294, 141);
            this.historique_btn.Name = "historique_btn";
            this.historique_btn.Size = new System.Drawing.Size(413, 72);
            this.historique_btn.TabIndex = 0;
            this.historique_btn.Text = "Historique de Vente";
            this.historique_btn.UseVisualStyleBackColor = true;
            this.historique_btn.Click += new System.EventHandler(this.historique_btn_Click);
            // 
            // nvVente_btn
            // 
            this.nvVente_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nvVente_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nvVente_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nvVente_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nvVente_btn.Location = new System.Drawing.Point(294, 30);
            this.nvVente_btn.Name = "nvVente_btn";
            this.nvVente_btn.Size = new System.Drawing.Size(413, 72);
            this.nvVente_btn.TabIndex = 1;
            this.nvVente_btn.Text = "Nouveau Vente";
            this.nvVente_btn.UseVisualStyleBackColor = true;
            // 
            // VenteChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.nvVente_btn);
            this.Controls.Add(this.historique_btn);
            this.Name = "VenteChoices";
            this.Text = "Opérations dans Vente";
            this.Load += new System.EventHandler(this.VenteChoices_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button historique_btn;
        private System.Windows.Forms.Button nvVente_btn;
    }
}