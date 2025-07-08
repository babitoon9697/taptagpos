namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class PopupArticlesVente
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
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.colRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.numQte = new System.Windows.Forms.NumericUpDown();
            this.labelQte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticles
            // 
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToDeleteRows = false;
            this.dgvArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticles.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRef,
            this.colDesignation,
            this.colPVente,
            this.colStock});
            this.dgvArticles.EnableHeadersVisualStyles = false;
            this.dgvArticles.Location = new System.Drawing.Point(12, 12);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.RowHeadersVisible = false;
            this.dgvArticles.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvArticles.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticles.RowTemplate.Height = 24;
            this.dgvArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticles.Size = new System.Drawing.Size(598, 429);
            this.dgvArticles.TabIndex = 2;
            // 
            // colRef
            // 
            this.colRef.HeaderText = "Référence";
            this.colRef.MinimumWidth = 6;
            this.colRef.Name = "colRef";
            this.colRef.ReadOnly = true;
            // 
            // colDesignation
            // 
            this.colDesignation.FillWeight = 150F;
            this.colDesignation.HeaderText = "Désignation";
            this.colDesignation.MinimumWidth = 6;
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.ReadOnly = true;
            // 
            // colPVente
            // 
            this.colPVente.HeaderText = "P. Vente";
            this.colPVente.MinimumWidth = 6;
            this.colPVente.Name = "colPVente";
            this.colPVente.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.btnAjouter);
            this.panelRight.Controls.Add(this.numQte);
            this.panelRight.Controls.Add(this.labelQte);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(622, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(160, 453);
            this.panelRight.TabIndex = 3;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(15, 100);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(130, 40);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "F1 Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            // 
            // numQte
            // 
            this.numQte.DecimalPlaces = 2;
            this.numQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQte.Location = new System.Drawing.Point(15, 55);
            this.numQte.Name = "numQte";
            this.numQte.Size = new System.Drawing.Size(130, 24);
            this.numQte.TabIndex = 1;
            // 
            // labelQte
            // 
            this.labelQte.AutoSize = true;
            this.labelQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQte.Location = new System.Drawing.Point(12, 34);
            this.labelQte.Name = "labelQte";
            this.labelQte.Size = new System.Drawing.Size(70, 18);
            this.labelQte.TabIndex = 0;
            this.labelQte.Text = "Quantité";
            // 
            // PopupArticlesVente
            // 
            this.AcceptButton = this.btnAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.dgvArticles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "PopupArticlesVente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choisir article";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQte)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelQte;
        private System.Windows.Forms.NumericUpDown numQte;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
    }
}