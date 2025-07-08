namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class TablePda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPda = new System.Windows.Forms.DataGridView();
            this.colNomPda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCouleur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPda
            // 
            this.dgvPda.AllowUserToAddRows = false;
            this.dgvPda.AllowUserToDeleteRows = false;
            this.dgvPda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPda.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomPda,
            this.colVendeur,
            this.colCouleur});
            this.dgvPda.EnableHeadersVisualStyles = false;
            this.dgvPda.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvPda.Location = new System.Drawing.Point(9, 10);
            this.dgvPda.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPda.Name = "dgvPda";
            this.dgvPda.ReadOnly = true;
            this.dgvPda.RowHeadersVisible = false;
            this.dgvPda.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPda.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPda.RowTemplate.Height = 24;
            this.dgvPda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPda.Size = new System.Drawing.Size(570, 430);
            this.dgvPda.TabIndex = 1;
            // 
            // colNomPda
            // 
            this.colNomPda.HeaderText = "Nom PDA";
            this.colNomPda.MinimumWidth = 6;
            this.colNomPda.Name = "colNomPda";
            this.colNomPda.ReadOnly = true;
            // 
            // colVendeur
            // 
            this.colVendeur.HeaderText = "Vendeur";
            this.colVendeur.MinimumWidth = 6;
            this.colVendeur.Name = "colVendeur";
            this.colVendeur.ReadOnly = true;
            // 
            // colCouleur
            // 
            this.colCouleur.HeaderText = "Couleur";
            this.colCouleur.MinimumWidth = 6;
            this.colCouleur.Name = "colCouleur";
            this.colCouleur.ReadOnly = true;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(590, 29);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(2);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(98, 32);
            this.btnNouveau.TabIndex = 2;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(590, 67);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 32);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(590, 104);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 32);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // TablePda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 449);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.dgvPda);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(566, 332);
            this.Name = "TablePda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table PDA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPda;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomPda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCouleur;
    }
}