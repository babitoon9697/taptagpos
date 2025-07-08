namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class TableImpression
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvImpression = new System.Windows.Forms.DataGridView();
            this.colService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImprimante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpression)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImpression
            // 
            this.dgvImpression.AllowUserToAddRows = false;
            this.dgvImpression.AllowUserToDeleteRows = false;
            this.dgvImpression.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvImpression.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImpression.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImpression.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvImpression.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpression.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colService,
            this.colImprimante});
            this.dgvImpression.EnableHeadersVisualStyles = false;
            this.dgvImpression.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvImpression.Location = new System.Drawing.Point(9, 10);
            this.dgvImpression.Margin = new System.Windows.Forms.Padding(2);
            this.dgvImpression.Name = "dgvImpression";
            this.dgvImpression.ReadOnly = true;
            this.dgvImpression.RowHeadersVisible = false;
            this.dgvImpression.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvImpression.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvImpression.RowTemplate.Height = 24;
            this.dgvImpression.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImpression.Size = new System.Drawing.Size(535, 459);
            this.dgvImpression.TabIndex = 0;
            // 
            // colService
            // 
            this.colService.HeaderText = "Service";
            this.colService.MinimumWidth = 6;
            this.colService.Name = "colService";
            this.colService.ReadOnly = true;
            // 
            // colImprimante
            // 
            this.colImprimante.HeaderText = "Imprimante";
            this.colImprimante.MinimumWidth = 6;
            this.colImprimante.Name = "colImprimante";
            this.colImprimante.ReadOnly = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(553, 29);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 32);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(553, 75);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(98, 32);
            this.btnFermer.TabIndex = 4;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // TableImpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 478);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.dgvImpression);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(416, 332);
            this.Name = "TableImpression";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impression";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpression)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImpression;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImprimante;
    }
}