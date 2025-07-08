namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class TableEchantillons
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
            this.dgvEchantillons = new System.Windows.Forms.DataGridView();
            this.colReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEchantillon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillons)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEchantillons
            // 
            this.dgvEchantillons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEchantillons.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEchantillons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEchantillons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEchantillons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReference,
            this.colDesignation,
            this.colEchantillon});
            this.dgvEchantillons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEchantillons.EnableHeadersVisualStyles = false;
            this.dgvEchantillons.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvEchantillons.Location = new System.Drawing.Point(0, 0);
            this.dgvEchantillons.Name = "dgvEchantillons";
            this.dgvEchantillons.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEchantillons.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEchantillons.RowTemplate.Height = 24;
            this.dgvEchantillons.Size = new System.Drawing.Size(782, 553);
            this.dgvEchantillons.TabIndex = 0;
            // 
            // colReference
            // 
            this.colReference.FillWeight = 80F;
            this.colReference.HeaderText = "Reference";
            this.colReference.MinimumWidth = 6;
            this.colReference.Name = "colReference";
            // 
            // colDesignation
            // 
            this.colDesignation.FillWeight = 200F;
            this.colDesignation.HeaderText = "Désignation";
            this.colDesignation.MinimumWidth = 6;
            this.colDesignation.Name = "colDesignation";
            // 
            // colEchantillon
            // 
            this.colEchantillon.HeaderText = "Echantillon";
            this.colEchantillon.MinimumWidth = 6;
            this.colEchantillon.Name = "colEchantillon";
            this.colEchantillon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEchantillon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TableEchantillons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.dgvEchantillons);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "TableEchantillons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table échantillons";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEchantillons)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEchantillons;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEchantillon;
    }
}