
namespace Gestionnaire_Pro
{
    partial class ajoutCreditDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablecreditDetail = new System.Windows.Forms.DataGridView();
            this.des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablecreditDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tablecreditDetail
            // 
            this.tablecreditDetail.AllowUserToOrderColumns = true;
            this.tablecreditDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablecreditDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablecreditDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablecreditDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablecreditDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablecreditDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.des,
            this.totalCol,
            this.restCol,
            this.Column3,
            this.dateCol});
            this.tablecreditDetail.Location = new System.Drawing.Point(9, 2);
            this.tablecreditDetail.MultiSelect = false;
            this.tablecreditDetail.Name = "tablecreditDetail";
            this.tablecreditDetail.RowTemplate.Height = 25;
            this.tablecreditDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablecreditDetail.Size = new System.Drawing.Size(723, 381);
            this.tablecreditDetail.TabIndex = 0;
            this.tablecreditDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // des
            // 
            this.des.DataPropertyName = "descriptionProduit";
            this.des.HeaderText = "Description ";
            this.des.Name = "des";
            // 
            // totalCol
            // 
            this.totalCol.DataPropertyName = "prixTotal";
            this.totalCol.HeaderText = "PrixTotal";
            this.totalCol.Name = "totalCol";
            // 
            // restCol
            // 
            this.restCol.DataPropertyName = "restApayé";
            this.restCol.HeaderText = "Rest A Payé";
            this.restCol.Name = "restCol";
            this.restCol.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "estPayé";
            this.Column3.FalseValue = "0";
            this.Column3.HeaderText = "est Payé";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.TrueValue = "1";
            // 
            // dateCol
            // 
            this.dateCol.DataPropertyName = "dateCredit";
            this.dateCol.HeaderText = "Date";
            this.dateCol.Name = "dateCol";
            this.dateCol.ReadOnly = true;
            // 
            // sub_btn
            // 
            this.sub_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sub_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sub_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sub_btn.Location = new System.Drawing.Point(9, 395);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(723, 84);
            this.sub_btn.TabIndex = 1;
            this.sub_btn.Text = "Valider";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // ajoutCreditDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(734, 479);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.tablecreditDetail);
            this.Name = "ajoutCreditDetail";
            this.Text = "ajoutCreditDetail";
            this.Load += new System.EventHandler(this.ajoutCreditDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablecreditDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablecreditDetail;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn des;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn restCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCol;
    }
}