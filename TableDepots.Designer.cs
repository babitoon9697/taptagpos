namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class TableDepots
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
            this.dgvDepots = new System.Windows.Forms.DataGridView();
            this.colDepot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImpression = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepots)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepots
            // 
            this.dgvDepots.AllowUserToAddRows = false;
            this.dgvDepots.AllowUserToDeleteRows = false;
            this.dgvDepots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepots.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDepot,
            this.colImpression});
            this.dgvDepots.EnableHeadersVisualStyles = false;
            this.dgvDepots.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDepots.Location = new System.Drawing.Point(9, 10);
            this.dgvDepots.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDepots.Name = "dgvDepots";
            this.dgvDepots.ReadOnly = true;
            this.dgvDepots.RowHeadersVisible = false;
            this.dgvDepots.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvDepots.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDepots.RowTemplate.Height = 24;
            this.dgvDepots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepots.Size = new System.Drawing.Size(345, 349);
            this.dgvDepots.TabIndex = 0;
            // 
            // colDepot
            // 
            this.colDepot.FillWeight = 200F;
            this.colDepot.HeaderText = "Dépôt";
            this.colDepot.MinimumWidth = 6;
            this.colDepot.Name = "colDepot";
            this.colDepot.ReadOnly = true;
            // 
            // colImpression
            // 
            this.colImpression.HeaderText = "Impression";
            this.colImpression.MinimumWidth = 6;
            this.colImpression.Name = "colImpression";
            this.colImpression.ReadOnly = true;
            this.colImpression.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colImpression.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(365, 29);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(98, 32);
            this.btnNouveau.TabIndex = 1;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(365, 67);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 32);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(365, 104);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 32);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(365, 141);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(98, 32);
            this.btnFermer.TabIndex = 4;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // TableDepots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 368);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.dgvDepots);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(416, 332);
            this.Name = "TableDepots";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des Dépôts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepots)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepots;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepot;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colImpression;
    }
}