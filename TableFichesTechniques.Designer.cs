namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class TableFichesTechniques
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
            this.dgvFiches = new System.Windows.Forms.DataGridView();
            this.colReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrixRevient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnConsulter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiches)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiches
            // 
            this.dgvFiches.AllowUserToAddRows = false;
            this.dgvFiches.AllowUserToDeleteRows = false;
            this.dgvFiches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFiches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiches.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFiches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReference,
            this.colDesignation,
            this.colPrixRevient});
            this.dgvFiches.EnableHeadersVisualStyles = false;
            this.dgvFiches.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvFiches.Location = new System.Drawing.Point(9, 10);
            this.dgvFiches.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFiches.Name = "dgvFiches";
            this.dgvFiches.ReadOnly = true;
            this.dgvFiches.RowHeadersVisible = false;
            this.dgvFiches.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvFiches.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFiches.RowTemplate.Height = 24;
            this.dgvFiches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiches.Size = new System.Drawing.Size(762, 510);
            this.dgvFiches.TabIndex = 0;
            // 
            // colReference
            // 
            this.colReference.FillWeight = 80F;
            this.colReference.HeaderText = "Référence";
            this.colReference.MinimumWidth = 6;
            this.colReference.Name = "colReference";
            this.colReference.ReadOnly = true;
            // 
            // colDesignation
            // 
            this.colDesignation.FillWeight = 200F;
            this.colDesignation.HeaderText = "Désignation";
            this.colDesignation.MinimumWidth = 6;
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.ReadOnly = true;
            // 
            // colPrixRevient
            // 
            this.colPrixRevient.HeaderText = "Prix de revient";
            this.colPrixRevient.MinimumWidth = 6;
            this.colPrixRevient.Name = "colPrixRevient";
            this.colPrixRevient.ReadOnly = true;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(782, 29);
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
            this.btnModifier.Location = new System.Drawing.Point(782, 67);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 32);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnConsulter
            // 
            this.btnConsulter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsulter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulter.Location = new System.Drawing.Point(782, 104);
            this.btnConsulter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsulter.Name = "btnConsulter";
            this.btnConsulter.Size = new System.Drawing.Size(98, 32);
            this.btnConsulter.TabIndex = 3;
            this.btnConsulter.Text = "Consulter";
            this.btnConsulter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(782, 141);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 32);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(782, 179);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(98, 32);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // TableFichesTechniques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 529);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnConsulter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.dgvFiches);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(604, 373);
            this.Name = "TableFichesTechniques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des fiches techniques";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiches;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnConsulter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrixRevient;
    }
}