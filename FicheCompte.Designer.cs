namespace TAPTAGPOS
{
    partial class FicheCompte
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
            this.labelCompte = new System.Windows.Forms.Label();
            this.cmbCompte = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.labelPJ = new System.Windows.Forms.Label();
            this.txtPJ = new System.Windows.Forms.TextBox();
            this.labelCredit = new System.Windows.Forms.Label();
            this.numCredit = new System.Windows.Forms.NumericUpDown();
            this.numDebit = new System.Windows.Forms.NumericUpDown();
            this.labelDebit = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDebit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCompte
            // 
            this.labelCompte.AutoSize = true;
            this.labelCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompte.Location = new System.Drawing.Point(30, 37);
            this.labelCompte.Name = "labelCompte";
            this.labelCompte.Size = new System.Drawing.Size(83, 18);
            this.labelCompte.TabIndex = 0;
            this.labelCompte.Text = "N° Compte";
            // 
            // cmbCompte
            // 
            this.cmbCompte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompte.FormattingEnabled = true;
            this.cmbCompte.Location = new System.Drawing.Point(140, 34);
            this.cmbCompte.Name = "cmbCompte";
            this.cmbCompte.Size = new System.Drawing.Size(300, 26);
            this.cmbCompte.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(30, 77);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(39, 18);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(140, 74);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(300, 24);
            this.dtpDate.TabIndex = 2;
            // 
            // labelLibelle
            // 
            this.labelLibelle.AutoSize = true;
            this.labelLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibelle.Location = new System.Drawing.Point(30, 117);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(50, 18);
            this.labelLibelle.TabIndex = 4;
            this.labelLibelle.Text = "Libelle";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibelle.Location = new System.Drawing.Point(140, 114);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(300, 24);
            this.txtLibelle.TabIndex = 3;
            // 
            // labelPJ
            // 
            this.labelPJ.AutoSize = true;
            this.labelPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPJ.Location = new System.Drawing.Point(30, 157);
            this.labelPJ.Name = "labelPJ";
            this.labelPJ.Size = new System.Drawing.Size(46, 18);
            this.labelPJ.TabIndex = 6;
            this.labelPJ.Text = "N° PJ";
            // 
            // txtPJ
            // 
            this.txtPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPJ.Location = new System.Drawing.Point(140, 154);
            this.txtPJ.Name = "txtPJ";
            this.txtPJ.Size = new System.Drawing.Size(300, 24);
            this.txtPJ.TabIndex = 4;
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredit.Location = new System.Drawing.Point(30, 197);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(48, 18);
            this.labelCredit.TabIndex = 8;
            this.labelCredit.Text = "Crédit";
            // 
            // numCredit
            // 
            this.numCredit.DecimalPlaces = 2;
            this.numCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCredit.Location = new System.Drawing.Point(140, 195);
            this.numCredit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCredit.Name = "numCredit";
            this.numCredit.Size = new System.Drawing.Size(150, 24);
            this.numCredit.TabIndex = 5;
            // 
            // numDebit
            // 
            this.numDebit.DecimalPlaces = 2;
            this.numDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDebit.Location = new System.Drawing.Point(140, 235);
            this.numDebit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDebit.Name = "numDebit";
            this.numDebit.Size = new System.Drawing.Size(150, 24);
            this.numDebit.TabIndex = 6;
            // 
            // labelDebit
            // 
            this.labelDebit.AutoSize = true;
            this.labelDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebit.Location = new System.Drawing.Point(30, 237);
            this.labelDebit.Name = "labelDebit";
            this.labelDebit.Size = new System.Drawing.Size(42, 18);
            this.labelDebit.TabIndex = 10;
            this.labelDebit.Text = "Débit";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(470, 50);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 40);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(470, 96);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(120, 40);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FicheCompte
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(612, 283);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numDebit);
            this.Controls.Add(this.labelDebit);
            this.Controls.Add(this.numCredit);
            this.Controls.Add(this.labelCredit);
            this.Controls.Add(this.txtPJ);
            this.Controls.Add(this.labelPJ);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.labelLibelle);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.cmbCompte);
            this.Controls.Add(this.labelCompte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FicheCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche Compte";
            ((System.ComponentModel.ISupportInitialize)(this.numCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDebit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label labelCompte;
        private System.Windows.Forms.ComboBox cmbCompte;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label labelLibelle;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label labelPJ;
        private System.Windows.Forms.TextBox txtPJ;
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.NumericUpDown numCredit;
        private System.Windows.Forms.NumericUpDown numDebit;
        private System.Windows.Forms.Label labelDebit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}