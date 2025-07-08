namespace TAPTAGPOS
{
    partial class FormJournalVentes
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
            this.panelFilters = new System.Windows.Forms.Panel();
            this.btnValider = new System.Windows.Forms.Button();
            this.chkCheque = new System.Windows.Forms.CheckBox();
            this.chkCarteCredit = new System.Windows.Forms.CheckBox();
            this.chkEspece = new System.Windows.Forms.CheckBox();
            this.chkCredit = new System.Windows.Forms.CheckBox();
            this.chkTous = new System.Windows.Forms.CheckBox();
            this.cmbVendeur = new System.Windows.Forms.ComboBox();
            this.labelVendeur = new System.Windows.Forms.Label();
            this.btnPeriode = new System.Windows.Forms.Button();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.dgvJournal = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.txtTotalCarte = new System.Windows.Forms.TextBox();
            this.labelTotalCarte = new System.Windows.Forms.Label();
            this.txtTotalCredit = new System.Windows.Forms.TextBox();
            this.labelTotalCredit = new System.Windows.Forms.Label();
            this.txtTotalCheque = new System.Windows.Forms.TextBox();
            this.labelTotalCheque = new System.Windows.Forms.Label();
            this.txtTotalEspece = new System.Windows.Forms.TextBox();
            this.labelTotalEspece = new System.Windows.Forms.Label();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.btnValider);
            this.panelFilters.Controls.Add(this.chkCheque);
            this.panelFilters.Controls.Add(this.chkCarteCredit);
            this.panelFilters.Controls.Add(this.chkEspece);
            this.panelFilters.Controls.Add(this.chkCredit);
            this.panelFilters.Controls.Add(this.chkTous);
            this.panelFilters.Controls.Add(this.cmbVendeur);
            this.panelFilters.Controls.Add(this.labelVendeur);
            this.panelFilters.Controls.Add(this.btnPeriode);
            this.panelFilters.Controls.Add(this.dtpDateFin);
            this.panelFilters.Controls.Add(this.labelDateFin);
            this.panelFilters.Controls.Add(this.dtpDateDebut);
            this.panelFilters.Controls.Add(this.labelDateDebut);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilters.Location = new System.Drawing.Point(0, 0);
            this.panelFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(738, 81);
            this.panelFilters.TabIndex = 0;
            // 
            // btnValider
            // 
            this.btnValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(621, 37);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(90, 28);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // chkCheque
            // 
            this.chkCheque.AutoSize = true;
            this.chkCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkCheque.Location = new System.Drawing.Point(559, 42);
            this.chkCheque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCheque.Name = "chkCheque";
            this.chkCheque.Size = new System.Drawing.Size(69, 19);
            this.chkCheque.TabIndex = 11;
            this.chkCheque.Text = "Chèque";
            this.chkCheque.UseVisualStyleBackColor = true;
            // 
            // chkCarteCredit
            // 
            this.chkCarteCredit.AutoSize = true;
            this.chkCarteCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkCarteCredit.Location = new System.Drawing.Point(472, 42);
            this.chkCarteCredit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCarteCredit.Name = "chkCarteCredit";
            this.chkCarteCredit.Size = new System.Drawing.Size(90, 19);
            this.chkCarteCredit.TabIndex = 10;
            this.chkCarteCredit.Text = "Carte Crédit";
            this.chkCarteCredit.UseVisualStyleBackColor = true;
            // 
            // chkEspece
            // 
            this.chkEspece.AutoSize = true;
            this.chkEspece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkEspece.Location = new System.Drawing.Point(404, 42);
            this.chkEspece.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkEspece.Name = "chkEspece";
            this.chkEspece.Size = new System.Drawing.Size(67, 19);
            this.chkEspece.TabIndex = 9;
            this.chkEspece.Text = "Espèce";
            this.chkEspece.UseVisualStyleBackColor = true;
            // 
            // chkCredit
            // 
            this.chkCredit.AutoSize = true;
            this.chkCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkCredit.Location = new System.Drawing.Point(344, 42);
            this.chkCredit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCredit.Name = "chkCredit";
            this.chkCredit.Size = new System.Drawing.Size(58, 19);
            this.chkCredit.TabIndex = 8;
            this.chkCredit.Text = "Crédit";
            this.chkCredit.UseVisualStyleBackColor = true;
            // 
            // chkTous
            // 
            this.chkTous.AutoSize = true;
            this.chkTous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.chkTous.Location = new System.Drawing.Point(284, 42);
            this.chkTous.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTous.Name = "chkTous";
            this.chkTous.Size = new System.Drawing.Size(57, 19);
            this.chkTous.TabIndex = 7;
            this.chkTous.Text = "Tous";
            this.chkTous.UseVisualStyleBackColor = true;
            // 
            // cmbVendeur
            // 
            this.cmbVendeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbVendeur.FormattingEnabled = true;
            this.cmbVendeur.Location = new System.Drawing.Point(345, 10);
            this.cmbVendeur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbVendeur.Name = "cmbVendeur";
            this.cmbVendeur.Size = new System.Drawing.Size(214, 23);
            this.cmbVendeur.TabIndex = 6;
            // 
            // labelVendeur
            // 
            this.labelVendeur.AutoSize = true;
            this.labelVendeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelVendeur.Location = new System.Drawing.Point(282, 12);
            this.labelVendeur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVendeur.Name = "labelVendeur";
            this.labelVendeur.Size = new System.Drawing.Size(53, 15);
            this.labelVendeur.TabIndex = 5;
            this.labelVendeur.Text = "Vendeur";
            // 
            // btnPeriode
            // 
            this.btnPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnPeriode.Location = new System.Drawing.Point(172, 23);
            this.btnPeriode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPeriode.Name = "btnPeriode";
            this.btnPeriode.Size = new System.Drawing.Size(90, 28);
            this.btnPeriode.TabIndex = 4;
            this.btnPeriode.Text = "Période";
            this.btnPeriode.UseVisualStyleBackColor = true;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFin.Location = new System.Drawing.Point(75, 41);
            this.dtpDateFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(91, 21);
            this.dtpDateFin.TabIndex = 3;
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelDateFin.Location = new System.Drawing.Point(15, 43);
            this.labelDateFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(66, 15);
            this.labelDateFin.TabIndex = 2;
            this.labelDateFin.Text = "Date de fin";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDebut.Location = new System.Drawing.Point(75, 10);
            this.dtpDateDebut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(91, 21);
            this.dtpDateDebut.TabIndex = 1;
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelDateDebut.Location = new System.Drawing.Point(15, 12);
            this.labelDateDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(84, 15);
            this.labelDateDebut.TabIndex = 0;
            this.labelDateDebut.Text = "Date de début";
            // 
            // dgvJournal
            // 
            this.dgvJournal.AllowUserToAddRows = false;
            this.dgvJournal.AllowUserToDeleteRows = false;
            this.dgvJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJournal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJournal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJournal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colOperation,
            this.colClient,
            this.colMode,
            this.colMontant});
            this.dgvJournal.EnableHeadersVisualStyles = false;
            this.dgvJournal.Location = new System.Drawing.Point(9, 86);
            this.dgvJournal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvJournal.Name = "dgvJournal";
            this.dgvJournal.ReadOnly = true;
            this.dgvJournal.RowHeadersVisible = false;
            this.dgvJournal.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvJournal.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvJournal.RowTemplate.Height = 24;
            this.dgvJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJournal.Size = new System.Drawing.Size(718, 323);
            this.dgvJournal.TabIndex = 1;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colOperation
            // 
            this.colOperation.HeaderText = "N° d\'opération";
            this.colOperation.MinimumWidth = 6;
            this.colOperation.Name = "colOperation";
            this.colOperation.ReadOnly = true;
            // 
            // colClient
            // 
            this.colClient.FillWeight = 150F;
            this.colClient.HeaderText = "Client";
            this.colClient.MinimumWidth = 6;
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            // 
            // colMode
            // 
            this.colMode.HeaderText = "Mode Règlement";
            this.colMode.MinimumWidth = 6;
            this.colMode.Name = "colMode";
            this.colMode.ReadOnly = true;
            // 
            // colMontant
            // 
            this.colMontant.HeaderText = "Montant";
            this.colMontant.MinimumWidth = 6;
            this.colMontant.Name = "colMontant";
            this.colMontant.ReadOnly = true;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.btnImprimer);
            this.panelFooter.Controls.Add(this.txtTotal);
            this.panelFooter.Controls.Add(this.labelTotal);
            this.panelFooter.Controls.Add(this.txtTotalCarte);
            this.panelFooter.Controls.Add(this.labelTotalCarte);
            this.panelFooter.Controls.Add(this.txtTotalCredit);
            this.panelFooter.Controls.Add(this.labelTotalCredit);
            this.panelFooter.Controls.Add(this.txtTotalCheque);
            this.panelFooter.Controls.Add(this.labelTotalCheque);
            this.panelFooter.Controls.Add(this.txtTotalEspece);
            this.panelFooter.Controls.Add(this.labelTotalEspece);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 421);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(738, 35);
            this.panelFooter.TabIndex = 2;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnImprimer.Location = new System.Drawing.Point(640, 3);
            this.btnImprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(90, 28);
            this.btnImprimer.TabIndex = 10;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(532, 8);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(76, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelTotal.Location = new System.Drawing.Point(494, 11);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(36, 13);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Total";
            // 
            // txtTotalCarte
            // 
            this.txtTotalCarte.Location = new System.Drawing.Point(406, 8);
            this.txtTotalCarte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalCarte.Name = "txtTotalCarte";
            this.txtTotalCarte.ReadOnly = true;
            this.txtTotalCarte.Size = new System.Drawing.Size(76, 20);
            this.txtTotalCarte.TabIndex = 7;
            // 
            // labelTotalCarte
            // 
            this.labelTotalCarte.AutoSize = true;
            this.labelTotalCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelTotalCarte.Location = new System.Drawing.Point(338, 11);
            this.labelTotalCarte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalCarte.Name = "labelTotalCarte";
            this.labelTotalCarte.Size = new System.Drawing.Size(70, 13);
            this.labelTotalCarte.TabIndex = 6;
            this.labelTotalCarte.Text = "Total Carte";
            // 
            // txtTotalCredit
            // 
            this.txtTotalCredit.Location = new System.Drawing.Point(258, 8);
            this.txtTotalCredit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalCredit.Name = "txtTotalCredit";
            this.txtTotalCredit.ReadOnly = true;
            this.txtTotalCredit.Size = new System.Drawing.Size(76, 20);
            this.txtTotalCredit.TabIndex = 5;
            // 
            // labelTotalCredit
            // 
            this.labelTotalCredit.AutoSize = true;
            this.labelTotalCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelTotalCredit.Location = new System.Drawing.Point(187, 11);
            this.labelTotalCredit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalCredit.Name = "labelTotalCredit";
            this.labelTotalCredit.Size = new System.Drawing.Size(73, 13);
            this.labelTotalCredit.TabIndex = 4;
            this.labelTotalCredit.Text = "Total Crédit";
            // 
            // txtTotalCheque
            // 
            this.txtTotalCheque.Location = new System.Drawing.Point(107, 8);
            this.txtTotalCheque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalCheque.Name = "txtTotalCheque";
            this.txtTotalCheque.ReadOnly = true;
            this.txtTotalCheque.Size = new System.Drawing.Size(76, 20);
            this.txtTotalCheque.TabIndex = 3;
            // 
            // labelTotalCheque
            // 
            this.labelTotalCheque.AutoSize = true;
            this.labelTotalCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelTotalCheque.Location = new System.Drawing.Point(28, 11);
            this.labelTotalCheque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalCheque.Name = "labelTotalCheque";
            this.labelTotalCheque.Size = new System.Drawing.Size(83, 13);
            this.labelTotalCheque.TabIndex = 2;
            this.labelTotalCheque.Text = "Total Chèque";
            // 
            // txtTotalEspece
            // 
            this.txtTotalEspece.Location = new System.Drawing.Point(-59, 8);
            this.txtTotalEspece.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalEspece.Name = "txtTotalEspece";
            this.txtTotalEspece.ReadOnly = true;
            this.txtTotalEspece.Size = new System.Drawing.Size(76, 20);
            this.txtTotalEspece.TabIndex = 1;
            // 
            // labelTotalEspece
            // 
            this.labelTotalEspece.AutoSize = true;
            this.labelTotalEspece.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelTotalEspece.Location = new System.Drawing.Point(-140, 11);
            this.labelTotalEspece.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalEspece.Name = "labelTotalEspece";
            this.labelTotalEspece.Size = new System.Drawing.Size(82, 13);
            this.labelTotalEspece.TabIndex = 0;
            this.labelTotalEspece.Text = "Total Espèce";
            // 
            // FormJournalVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 456);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dgvJournal);
            this.Controls.Add(this.panelFilters);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(754, 495);
            this.Name = "FormJournalVentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal des Ventes";
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.DataGridView dgvJournal;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Button btnPeriode;
        private System.Windows.Forms.Label labelVendeur;
        private System.Windows.Forms.ComboBox cmbVendeur;
        private System.Windows.Forms.CheckBox chkTous;
        private System.Windows.Forms.CheckBox chkCredit;
        private System.Windows.Forms.CheckBox chkEspece;
        private System.Windows.Forms.CheckBox chkCarteCredit;
        private System.Windows.Forms.CheckBox chkCheque;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label labelTotalEspece;
        private System.Windows.Forms.TextBox txtTotalEspece;
        private System.Windows.Forms.TextBox txtTotalCredit;
        private System.Windows.Forms.Label labelTotalCredit;
        private System.Windows.Forms.TextBox txtTotalCheque;
        private System.Windows.Forms.Label labelTotalCheque;
        private System.Windows.Forms.TextBox txtTotalCarte;
        private System.Windows.Forms.Label labelTotalCarte;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontant;
    }
}