namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class TableDevis
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
            this.dgvDevis = new System.Windows.Forms.DataGridView();
            this.colNumDevis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNouveauDevis = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnDevisToBL = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnNouveauProformat = new System.Windows.Forms.Button();
            this.btnConsulter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDevis
            // 
            this.dgvDevis.AllowUserToAddRows = false;
            this.dgvDevis.AllowUserToDeleteRows = false;
            this.dgvDevis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDevis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevis.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumDevis,
            this.colDate,
            this.colCat,
            this.colClient,
            this.colTotal});
            this.dgvDevis.EnableHeadersVisualStyles = false;
            this.dgvDevis.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDevis.Location = new System.Drawing.Point(9, 10);
            this.dgvDevis.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDevis.Name = "dgvDevis";
            this.dgvDevis.ReadOnly = true;
            this.dgvDevis.RowHeadersVisible = false;
            this.dgvDevis.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvDevis.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDevis.RowTemplate.Height = 24;
            this.dgvDevis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevis.Size = new System.Drawing.Size(570, 430);
            this.dgvDevis.TabIndex = 0;
            // 
            // colNumDevis
            // 
            this.colNumDevis.HeaderText = "N° Devis";
            this.colNumDevis.MinimumWidth = 6;
            this.colNumDevis.Name = "colNumDevis";
            this.colNumDevis.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colCat
            // 
            this.colCat.FillWeight = 50F;
            this.colCat.HeaderText = "Cat";
            this.colCat.MinimumWidth = 6;
            this.colCat.Name = "colCat";
            this.colCat.ReadOnly = true;
            // 
            // colClient
            // 
            this.colClient.FillWeight = 200F;
            this.colClient.HeaderText = "Client";
            this.colClient.MinimumWidth = 6;
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total TTC";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // btnNouveauDevis
            // 
            this.btnNouveauDevis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveauDevis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveauDevis.Location = new System.Drawing.Point(590, 16);
            this.btnNouveauDevis.Margin = new System.Windows.Forms.Padding(2);
            this.btnNouveauDevis.Name = "btnNouveauDevis";
            this.btnNouveauDevis.Size = new System.Drawing.Size(98, 46);
            this.btnNouveauDevis.TabIndex = 1;
            this.btnNouveauDevis.Text = "Nouveau Devis";
            this.btnNouveauDevis.UseVisualStyleBackColor = true;
            this.btnNouveauDevis.Click += new System.EventHandler(this.btnNouveauDevis_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(590, 67);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 32);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnDevisToBL
            // 
            this.btnDevisToBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevisToBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevisToBL.Location = new System.Drawing.Point(590, 104);
            this.btnDevisToBL.Margin = new System.Windows.Forms.Padding(2);
            this.btnDevisToBL.Name = "btnDevisToBL";
            this.btnDevisToBL.Size = new System.Drawing.Size(98, 32);
            this.btnDevisToBL.TabIndex = 3;
            this.btnDevisToBL.Text = "Devis à BL";
            this.btnDevisToBL.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(590, 141);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 32);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(590, 179);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(98, 32);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnNouveauProformat
            // 
            this.btnNouveauProformat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveauProformat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveauProformat.Location = new System.Drawing.Point(590, 216);
            this.btnNouveauProformat.Margin = new System.Windows.Forms.Padding(2);
            this.btnNouveauProformat.Name = "btnNouveauProformat";
            this.btnNouveauProformat.Size = new System.Drawing.Size(98, 62);
            this.btnNouveauProformat.TabIndex = 6;
            this.btnNouveauProformat.Text = "Nouveau Facture ProFormat";
            this.btnNouveauProformat.UseVisualStyleBackColor = true;
            this.btnNouveauProformat.Click += new System.EventHandler(this.btnNouveauProformat_Click);
            // 
            // btnConsulter
            // 
            this.btnConsulter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsulter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulter.Location = new System.Drawing.Point(590, 282);
            this.btnConsulter.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsulter.Name = "btnConsulter";
            this.btnConsulter.Size = new System.Drawing.Size(98, 32);
            this.btnConsulter.TabIndex = 7;
            this.btnConsulter.Text = "Consulter";
            this.btnConsulter.UseVisualStyleBackColor = true;
            // 
            // TableDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 449);
            this.Controls.Add(this.btnConsulter);
            this.Controls.Add(this.btnNouveauProformat);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnDevisToBL);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveauDevis);
            this.Controls.Add(this.dgvDevis);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(604, 373);
            this.Name = "TableDevis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Devis";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDevis;
        private System.Windows.Forms.Button btnNouveauDevis;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnDevisToBL;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnNouveauProformat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumDevis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Button btnConsulter;
    }
}