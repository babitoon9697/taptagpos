namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class TableCommerciaux
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
            this.dgvCommerciaux = new System.Windows.Forms.DataGridView();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommerciaux)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommerciaux
            // 
            this.dgvCommerciaux.AllowUserToAddRows = false;
            this.dgvCommerciaux.AllowUserToDeleteRows = false;
            this.dgvCommerciaux.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCommerciaux.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommerciaux.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCommerciaux.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCommerciaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommerciaux.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNom,
            this.colAdresse,
            this.colTelephone,
            this.colEmail});
            this.dgvCommerciaux.EnableHeadersVisualStyles = false;
            this.dgvCommerciaux.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvCommerciaux.Location = new System.Drawing.Point(9, 10);
            this.dgvCommerciaux.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCommerciaux.Name = "dgvCommerciaux";
            this.dgvCommerciaux.ReadOnly = true;
            this.dgvCommerciaux.RowHeadersVisible = false;
            this.dgvCommerciaux.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvCommerciaux.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCommerciaux.RowTemplate.Height = 24;
            this.dgvCommerciaux.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommerciaux.Size = new System.Drawing.Size(570, 430);
            this.dgvCommerciaux.TabIndex = 0;
            // 
            // colNom
            // 
            this.colNom.FillWeight = 120F;
            this.colNom.HeaderText = "Nom et Prénom";
            this.colNom.MinimumWidth = 6;
            this.colNom.Name = "colNom";
            this.colNom.ReadOnly = true;
            // 
            // colAdresse
            // 
            this.colAdresse.FillWeight = 150F;
            this.colAdresse.HeaderText = "Adresse";
            this.colAdresse.MinimumWidth = 6;
            this.colAdresse.Name = "colAdresse";
            this.colAdresse.ReadOnly = true;
            // 
            // colTelephone
            // 
            this.colTelephone.HeaderText = "Téléphone";
            this.colTelephone.MinimumWidth = 6;
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.FillWeight = 120F;
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(590, 29);
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
            this.btnModifier.Location = new System.Drawing.Point(590, 67);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 32);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(590, 104);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 32);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // TableCommerciaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 449);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.dgvCommerciaux);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TableCommerciaux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Commerciaux";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommerciaux)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCommerciaux;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    }
}