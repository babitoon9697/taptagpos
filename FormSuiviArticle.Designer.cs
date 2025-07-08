namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class FormSuiviArticle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbFiltrer = new System.Windows.Forms.ToolStripButton();
            this.tsbAfficherTous = new System.Windows.Forms.ToolStripButton();
            this.dgvSuivi = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.txtSumQte = new System.Windows.Forms.TextBox();
            this.labelSumQte = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuivi)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFiltrer,
            this.tsbAfficherTous});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(930, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbFiltrer
            // 
            this.tsbFiltrer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbFiltrer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFiltrer.Name = "tsbFiltrer";
            this.tsbFiltrer.Size = new System.Drawing.Size(45, 22);
            this.tsbFiltrer.Text = "Filtrer";
            this.tsbFiltrer.Click += new System.EventHandler(this.tsbFiltrer_Click);
            // 
            // tsbAfficherTous
            // 
            this.tsbAfficherTous.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbAfficherTous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAfficherTous.Name = "tsbAfficherTous";
            this.tsbAfficherTous.Size = new System.Drawing.Size(84, 22);
            this.tsbAfficherTous.Text = "Afficher tous";
            this.tsbAfficherTous.Click += new System.EventHandler(this.tsbAfficherTous_Click);
            // 
            // dgvSuivi
            // 
            this.dgvSuivi.AllowUserToAddRows = false;
            this.dgvSuivi.AllowUserToDeleteRows = false;
            this.dgvSuivi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuivi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuivi.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuivi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSuivi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuivi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colBL,
            this.colReference,
            this.colLibelle,
            this.colQte,
            this.colPrix,
            this.colClient});
            this.dgvSuivi.EnableHeadersVisualStyles = false;
            this.dgvSuivi.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvSuivi.Location = new System.Drawing.Point(0, 23);
            this.dgvSuivi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSuivi.Name = "dgvSuivi";
            this.dgvSuivi.ReadOnly = true;
            this.dgvSuivi.RowHeadersVisible = false;
            this.dgvSuivi.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dgvSuivi.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSuivi.RowTemplate.Height = 24;
            this.dgvSuivi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuivi.Size = new System.Drawing.Size(930, 467);
            this.dgvSuivi.TabIndex = 1;
            // 
            // colDate
            // 
            this.colDate.FillWeight = 80F;
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colBL
            // 
            this.colBL.HeaderText = "N° B.L.";
            this.colBL.MinimumWidth = 6;
            this.colBL.Name = "colBL";
            this.colBL.ReadOnly = true;
            // 
            // colReference
            // 
            this.colReference.FillWeight = 80F;
            this.colReference.HeaderText = "Référence";
            this.colReference.MinimumWidth = 6;
            this.colReference.Name = "colReference";
            this.colReference.ReadOnly = true;
            // 
            // colLibelle
            // 
            this.colLibelle.FillWeight = 150F;
            this.colLibelle.HeaderText = "Libelle";
            this.colLibelle.MinimumWidth = 6;
            this.colLibelle.Name = "colLibelle";
            this.colLibelle.ReadOnly = true;
            // 
            // colQte
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N3";
            dataGridViewCellStyle6.NullValue = null;
            this.colQte.DefaultCellStyle = dataGridViewCellStyle6;
            this.colQte.FillWeight = 70F;
            this.colQte.HeaderText = "Qte";
            this.colQte.MinimumWidth = 6;
            this.colQte.Name = "colQte";
            this.colQte.ReadOnly = true;
            // 
            // colPrix
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N4";
            dataGridViewCellStyle7.NullValue = null;
            this.colPrix.DefaultCellStyle = dataGridViewCellStyle7;
            this.colPrix.HeaderText = "Prix s";
            this.colPrix.MinimumWidth = 6;
            this.colPrix.Name = "colPrix";
            this.colPrix.ReadOnly = true;
            // 
            // colClient
            // 
            this.colClient.FillWeight = 120F;
            this.colClient.HeaderText = "Client";
            this.colClient.MinimumWidth = 6;
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.txtSumQte);
            this.panelBottom.Controls.Add(this.labelSumQte);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 489);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(2);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(930, 35);
            this.panelBottom.TabIndex = 2;
            // 
            // txtSumQte
            // 
            this.txtSumQte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSumQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumQte.Location = new System.Drawing.Point(809, 7);
            this.txtSumQte.Margin = new System.Windows.Forms.Padding(2);
            this.txtSumQte.Name = "txtSumQte";
            this.txtSumQte.ReadOnly = true;
            this.txtSumQte.Size = new System.Drawing.Size(114, 21);
            this.txtSumQte.TabIndex = 1;
            this.txtSumQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelSumQte
            // 
            this.labelSumQte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSumQte.AutoSize = true;
            this.labelSumQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumQte.Location = new System.Drawing.Point(646, 11);
            this.labelSumQte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSumQte.Name = "labelSumQte";
            this.labelSumQte.Size = new System.Drawing.Size(148, 15);
            this.labelSumQte.TabIndex = 0;
            this.labelSumQte.Text = "Somme des Quantités";
            // 
            // FormSuiviArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 524);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.dgvSuivi);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(604, 373);
            this.Name = "FormSuiviArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suivi d\'article";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuivi)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbFiltrer;
        private System.Windows.Forms.ToolStripButton tsbAfficherTous;
        private System.Windows.Forms.DataGridView dgvSuivi;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TextBox txtSumQte;
        private System.Windows.Forms.Label labelSumQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
    }
}