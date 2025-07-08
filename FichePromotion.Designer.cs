namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class FichePromotion
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
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.labelPromotion = new System.Windows.Forms.Label();
            this.txtPromotion = new System.Windows.Forms.TextBox();
            this.labelRemise = new System.Windows.Forms.Label();
            this.numRemise = new System.Windows.Forms.NumericUpDown();
            this.labelObservations = new System.Windows.Forms.Label();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouterArticles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRemise)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDebut.Location = new System.Drawing.Point(30, 37);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(83, 18);
            this.labelDateDebut.TabIndex = 0;
            this.labelDateDebut.Text = "Date Début";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateDebut.Location = new System.Drawing.Point(140, 32);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(280, 24);
            this.dtpDateDebut.TabIndex = 1;
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFin.Location = new System.Drawing.Point(30, 77);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(63, 18);
            this.labelDateFin.TabIndex = 2;
            this.labelDateFin.Text = "Date Fin";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFin.Location = new System.Drawing.Point(140, 72);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(280, 24);
            this.dtpDateFin.TabIndex = 2;
            // 
            // labelPromotion
            // 
            this.labelPromotion.AutoSize = true;
            this.labelPromotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromotion.Location = new System.Drawing.Point(30, 117);
            this.labelPromotion.Name = "labelPromotion";
            this.labelPromotion.Size = new System.Drawing.Size(78, 18);
            this.labelPromotion.TabIndex = 4;
            this.labelPromotion.Text = "Promotion";
            // 
            // txtPromotion
            // 
            this.txtPromotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromotion.Location = new System.Drawing.Point(140, 114);
            this.txtPromotion.Name = "txtPromotion";
            this.txtPromotion.Size = new System.Drawing.Size(280, 24);
            this.txtPromotion.TabIndex = 3;
            // 
            // labelRemise
            // 
            this.labelRemise.AutoSize = true;
            this.labelRemise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemise.Location = new System.Drawing.Point(30, 157);
            this.labelRemise.Name = "labelRemise";
            this.labelRemise.Size = new System.Drawing.Size(76, 18);
            this.labelRemise.TabIndex = 6;
            this.labelRemise.Text = "T. Remise";
            // 
            // numRemise
            // 
            this.numRemise.DecimalPlaces = 1;
            this.numRemise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRemise.Location = new System.Drawing.Point(140, 155);
            this.numRemise.Name = "numRemise";
            this.numRemise.Size = new System.Drawing.Size(120, 24);
            this.numRemise.TabIndex = 4;
            this.numRemise.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelObservations
            // 
            this.labelObservations.AutoSize = true;
            this.labelObservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservations.Location = new System.Drawing.Point(30, 197);
            this.labelObservations.Name = "labelObservations";
            this.labelObservations.Size = new System.Drawing.Size(94, 18);
            this.labelObservations.TabIndex = 8;
            this.labelObservations.Text = "Observations";
            // 
            // txtObservations
            // 
            this.txtObservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservations.Location = new System.Drawing.Point(140, 194);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(280, 80);
            this.txtObservations.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(460, 50);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(140, 40);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(460, 96);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(140, 40);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjouterArticles
            // 
            this.btnAjouterArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterArticles.Location = new System.Drawing.Point(460, 142);
            this.btnAjouterArticles.Name = "btnAjouterArticles";
            this.btnAjouterArticles.Size = new System.Drawing.Size(140, 40);
            this.btnAjouterArticles.TabIndex = 8;
            this.btnAjouterArticles.Text = "Ajouter Articles";
            this.btnAjouterArticles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouterArticles.UseVisualStyleBackColor = true;
            // 
            // FichePromotion
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(622, 293);
            this.Controls.Add(this.btnAjouterArticles);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtObservations);
            this.Controls.Add(this.labelObservations);
            this.Controls.Add(this.numRemise);
            this.Controls.Add(this.labelRemise);
            this.Controls.Add(this.txtPromotion);
            this.Controls.Add(this.labelPromotion);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.labelDateFin);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.labelDateDebut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FichePromotion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche Promotion";
            ((System.ComponentModel.ISupportInitialize)(this.numRemise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label labelPromotion;
        private System.Windows.Forms.TextBox txtPromotion;
        private System.Windows.Forms.Label labelRemise;
        private System.Windows.Forms.NumericUpDown numRemise;
        private System.Windows.Forms.Label labelObservations;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouterArticles;
    }
}