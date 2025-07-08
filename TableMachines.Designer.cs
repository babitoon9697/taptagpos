namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class TableMachines
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
            this.dgvMachines = new System.Windows.Forms.DataGridView();
            this.colMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateAcquisition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMachines
            // 
            this.dgvMachines.AllowUserToAddRows = false;
            this.dgvMachines.AllowUserToDeleteRows = false;
            this.dgvMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMachines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMachines.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMachines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMachine,
            this.colMarque,
            this.colDateAcquisition,
            this.colCapacite});
            this.dgvMachines.EnableHeadersVisualStyles = false;
            this.dgvMachines.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvMachines.Location = new System.Drawing.Point(9, 10);
            this.dgvMachines.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMachines.Name = "dgvMachines";
            this.dgvMachines.ReadOnly = true;
            this.dgvMachines.RowHeadersVisible = false;
            this.dgvMachines.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvMachines.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMachines.RowTemplate.Height = 24;
            this.dgvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMachines.Size = new System.Drawing.Size(570, 430);
            this.dgvMachines.TabIndex = 0;
            // 
            // colMachine
            // 
            this.colMachine.HeaderText = "Machine";
            this.colMachine.MinimumWidth = 6;
            this.colMachine.Name = "colMachine";
            this.colMachine.ReadOnly = true;
            // 
            // colMarque
            // 
            this.colMarque.HeaderText = "Marque";
            this.colMarque.MinimumWidth = 6;
            this.colMarque.Name = "colMarque";
            this.colMarque.ReadOnly = true;
            // 
            // colDateAcquisition
            // 
            this.colDateAcquisition.HeaderText = "Date d\'acquisition";
            this.colDateAcquisition.MinimumWidth = 6;
            this.colDateAcquisition.Name = "colDateAcquisition";
            this.colDateAcquisition.ReadOnly = true;
            // 
            // colCapacite
            // 
            this.colCapacite.HeaderText = "Capacité";
            this.colCapacite.MinimumWidth = 6;
            this.colCapacite.Name = "colCapacite";
            this.colCapacite.ReadOnly = true;
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
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(590, 141);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(98, 32);
            this.btnFermer.TabIndex = 4;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // TableMachines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 449);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.dgvMachines);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(604, 373);
            this.Name = "TableMachines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des Machines";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMachines;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateAcquisition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacite;
    }
}