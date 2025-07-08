namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class FicheDepot
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
            this.labelDepot = new System.Windows.Forms.Label();
            this.txtDepot = new System.Windows.Forms.TextBox();
            this.chkImprimerTicketSepare = new System.Windows.Forms.CheckBox();
            this.labelImprimante = new System.Windows.Forms.Label();
            this.cmbImprimante = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDepot
            // 
            this.labelDepot.AutoSize = true;
            this.labelDepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepot.Location = new System.Drawing.Point(30, 35);
            this.labelDepot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDepot.Name = "labelDepot";
            this.labelDepot.Size = new System.Drawing.Size(40, 15);
            this.labelDepot.TabIndex = 0;
            this.labelDepot.Text = "Dépôt";
            // 
            // txtDepot
            // 
            this.txtDepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepot.Location = new System.Drawing.Point(112, 32);
            this.txtDepot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDepot.Name = "txtDepot";
            this.txtDepot.Size = new System.Drawing.Size(211, 21);
            this.txtDepot.TabIndex = 1;
            // 
            // chkImprimerTicketSepare
            // 
            this.chkImprimerTicketSepare.AutoSize = true;
            this.chkImprimerTicketSepare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImprimerTicketSepare.Location = new System.Drawing.Point(112, 65);
            this.chkImprimerTicketSepare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkImprimerTicketSepare.Name = "chkImprimerTicketSepare";
            this.chkImprimerTicketSepare.Size = new System.Drawing.Size(152, 19);
            this.chkImprimerTicketSepare.TabIndex = 2;
            this.chkImprimerTicketSepare.Text = "Imprimer Ticket séparé";
            this.chkImprimerTicketSepare.UseVisualStyleBackColor = true;
            // 
            // labelImprimante
            // 
            this.labelImprimante.AutoSize = true;
            this.labelImprimante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImprimante.Location = new System.Drawing.Point(30, 96);
            this.labelImprimante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImprimante.Name = "labelImprimante";
            this.labelImprimante.Size = new System.Drawing.Size(70, 15);
            this.labelImprimante.TabIndex = 3;
            this.labelImprimante.Text = "Imprimante";
            // 
            // cmbImprimante
            // 
            this.cmbImprimante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImprimante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbImprimante.FormattingEnabled = true;
            this.cmbImprimante.Location = new System.Drawing.Point(112, 93);
            this.cmbImprimante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbImprimante.Name = "cmbImprimante";
            this.cmbImprimante.Size = new System.Drawing.Size(211, 23);
            this.cmbImprimante.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(64, 138);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 32);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(162, 138);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(94, 32);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FicheDepot
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(346, 189);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbImprimante);
            this.Controls.Add(this.labelImprimante);
            this.Controls.Add(this.chkImprimerTicketSepare);
            this.Controls.Add(this.txtDepot);
            this.Controls.Add(this.labelDepot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FicheDepot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dépôt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDepot;
        private System.Windows.Forms.TextBox txtDepot;
        private System.Windows.Forms.CheckBox chkImprimerTicketSepare;
        private System.Windows.Forms.Label labelImprimante;
        private System.Windows.Forms.ComboBox cmbImprimante;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}