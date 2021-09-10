
namespace Gestionnaire_Pro
{
    partial class historiqueAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historiqueAction));
            this.actionsTable = new System.Windows.Forms.DataGridView();
            this.userCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateActionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.actionsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // actionsTable
            // 
            this.actionsTable.AllowUserToAddRows = false;
            this.actionsTable.AllowUserToDeleteRows = false;
            this.actionsTable.AllowUserToOrderColumns = true;
            this.actionsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.actionsTable.BackgroundColor = System.Drawing.Color.White;
            this.actionsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.actionsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.actionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actionsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userCol,
            this.dateActionCol,
            this.description});
            this.actionsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsTable.Location = new System.Drawing.Point(0, 0);
            this.actionsTable.MultiSelect = false;
            this.actionsTable.Name = "actionsTable";
            this.actionsTable.ReadOnly = true;
            this.actionsTable.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.actionsTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.actionsTable.RowTemplate.Height = 30;
            this.actionsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.actionsTable.Size = new System.Drawing.Size(800, 450);
            this.actionsTable.TabIndex = 0;
            // 
            // userCol
            // 
            this.userCol.DataPropertyName = "utilisateur";
            this.userCol.HeaderText = "Utilisateur";
            this.userCol.Name = "userCol";
            this.userCol.ReadOnly = true;
            // 
            // dateActionCol
            // 
            this.dateActionCol.DataPropertyName = "dateAction";
            this.dateActionCol.HeaderText = "Date ";
            this.dateActionCol.Name = "dateActionCol";
            this.dateActionCol.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "descriptionAction";
            this.description.HeaderText = "DescriptionAction";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // historiqueAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.actionsTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "historiqueAction";
            this.Text = "historique d\'Action";
            this.Load += new System.EventHandler(this.historiqueAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actionsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView actionsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateActionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}