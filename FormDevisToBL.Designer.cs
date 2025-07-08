namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class FormDevisToBL
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
            this.groupDevis = new System.Windows.Forms.GroupBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.cmbClientCode = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.dtpDevisDate = new System.Windows.Forms.DateTimePicker();
            this.labelDevisDate = new System.Windows.Forms.Label();
            this.txtNumDevis = new System.Windows.Forms.TextBox();
            this.labelNumDevis = new System.Windows.Forms.Label();
            this.groupBL = new System.Windows.Forms.GroupBox();
            this.dtpBlDate = new System.Windows.Forms.DateTimePicker();
            this.labelBlDate = new System.Windows.Forms.Label();
            this.txtNumBL = new System.Windows.Forms.TextBox();
            this.labelNumBL = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.groupDevis.SuspendLayout();
            this.groupBL.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDevis
            // 
            this.groupDevis.Controls.Add(this.txtClientName);
            this.groupDevis.Controls.Add(this.cmbClientCode);
            this.groupDevis.Controls.Add(this.labelClient);
            this.groupDevis.Controls.Add(this.dtpDevisDate);
            this.groupDevis.Controls.Add(this.labelDevisDate);
            this.groupDevis.Controls.Add(this.txtNumDevis);
            this.groupDevis.Controls.Add(this.labelNumDevis);
            this.groupDevis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDevis.Location = new System.Drawing.Point(20, 20);
            this.groupDevis.Name = "groupDevis";
            this.groupDevis.Size = new System.Drawing.Size(540, 140);
            this.groupDevis.TabIndex = 0;
            this.groupDevis.TabStop = false;
            this.groupDevis.Text = "Devis";
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(260, 95);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.ReadOnly = true;
            this.txtClientName.Size = new System.Drawing.Size(260, 24);
            this.txtClientName.TabIndex = 6;
            // 
            // cmbClientCode
            // 
            this.cmbClientCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientCode.FormattingEnabled = true;
            this.cmbClientCode.Location = new System.Drawing.Point(120, 95);
            this.cmbClientCode.Name = "cmbClientCode";
            this.cmbClientCode.Size = new System.Drawing.Size(134, 26);
            this.cmbClientCode.TabIndex = 5;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.Location = new System.Drawing.Point(20, 98);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(84, 18);
            this.labelClient.TabIndex = 4;
            this.labelClient.Text = "Code Client";
            // 
            // dtpDevisDate
            // 
            this.dtpDevisDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevisDate.Location = new System.Drawing.Point(320, 45);
            this.dtpDevisDate.Name = "dtpDevisDate";
            this.dtpDevisDate.Size = new System.Drawing.Size(200, 24);
            this.dtpDevisDate.TabIndex = 3;
            // 
            // labelDevisDate
            // 
            this.labelDevisDate.AutoSize = true;
            this.labelDevisDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevisDate.Location = new System.Drawing.Point(275, 48);
            this.labelDevisDate.Name = "labelDevisDate";
            this.labelDevisDate.Size = new System.Drawing.Size(39, 18);
            this.labelDevisDate.TabIndex = 2;
            this.labelDevisDate.Text = "Date";
            // 
            // txtNumDevis
            // 
            this.txtNumDevis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDevis.Location = new System.Drawing.Point(120, 45);
            this.txtNumDevis.Name = "txtNumDevis";
            this.txtNumDevis.Size = new System.Drawing.Size(140, 24);
            this.txtNumDevis.TabIndex = 1;
            // 
            // labelNumDevis
            // 
            this.labelNumDevis.AutoSize = true;
            this.labelNumDevis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumDevis.Location = new System.Drawing.Point(20, 48);
            this.labelNumDevis.Name = "labelNumDevis";
            this.labelNumDevis.Size = new System.Drawing.Size(60, 18);
            this.labelNumDevis.TabIndex = 0;
            this.labelNumDevis.Text = "N° Devis";
            // 
            // groupBL
            // 
            this.groupBL.Controls.Add(this.dtpBlDate);
            this.groupBL.Controls.Add(this.labelBlDate);
            this.groupBL.Controls.Add(this.txtNumBL);
            this.groupBL.Controls.Add(this.labelNumBL);
            this.groupBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBL.Location = new System.Drawing.Point(20, 170);
            this.groupBL.Name = "groupBL";
            this.groupBL.Size = new System.Drawing.Size(540, 80);
            this.groupBL.TabIndex = 1;
            this.groupBL.TabStop = false;
            this.groupBL.Text = "Bon de Livraison";
            // 
            // dtpBlDate
            // 
            this.dtpBlDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBlDate.Location = new System.Drawing.Point(320, 35);
            this.dtpBlDate.Name = "dtpBlDate";
            this.dtpBlDate.Size = new System.Drawing.Size(200, 24);
            this.dtpBlDate.TabIndex = 7;
            // 
            // labelBlDate
            // 
            this.labelBlDate.AutoSize = true;
            this.labelBlDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlDate.Location = new System.Drawing.Point(247, 38);
            this.labelBlDate.Name = "labelBlDate";
            this.labelBlDate.Size = new System.Drawing.Size(63, 18);
            this.labelBlDate.TabIndex = 6;
            this.labelBlDate.Text = "Date BL";
            // 
            // txtNumBL
            // 
            this.txtNumBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumBL.Location = new System.Drawing.Point(120, 35);
            this.txtNumBL.Name = "txtNumBL";
            this.txtNumBL.ReadOnly = true;
            this.txtNumBL.Size = new System.Drawing.Size(121, 24);
            this.txtNumBL.TabIndex = 5;
            // 
            // labelNumBL
            // 
            this.labelNumBL.AutoSize = true;
            this.labelNumBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumBL.Location = new System.Drawing.Point(20, 38);
            this.labelNumBL.Name = "labelNumBL";
            this.labelNumBL.Size = new System.Drawing.Size(46, 18);
            this.labelNumBL.TabIndex = 4;
            this.labelNumBL.Text = "N° BL";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(160, 270);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 40);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(291, 270);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(125, 40);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormDevisToBL
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(582, 333);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBL);
            this.Controls.Add(this.groupDevis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDevisToBL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Devis à Bon de Livraison";
            this.groupDevis.ResumeLayout(false);
            this.groupDevis.PerformLayout();
            this.groupBL.ResumeLayout(false);
            this.groupBL.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox groupDevis;
        private System.Windows.Forms.GroupBox groupBL;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label labelNumDevis;
        private System.Windows.Forms.TextBox txtNumDevis;
        private System.Windows.Forms.DateTimePicker dtpDevisDate;
        private System.Windows.Forms.Label labelDevisDate;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox cmbClientCode;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtNumBL;
        private System.Windows.Forms.Label labelNumBL;
        private System.Windows.Forms.DateTimePicker dtpBlDate;
        private System.Windows.Forms.Label labelBlDate;
    }
}