namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class FichePda
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
            this.labelNomPda = new System.Windows.Forms.Label();
            this.txtNomPda = new System.Windows.Forms.TextBox();
            this.labelCouleur = new System.Windows.Forms.Label();
            this.txtCouleur = new System.Windows.Forms.TextBox();
            this.btnSelectCouleur = new System.Windows.Forms.Button();
            this.labelVendeur = new System.Windows.Forms.Label();
            this.cmbVendeur = new System.Windows.Forms.ComboBox();
            this.labelCommission = new System.Windows.Forms.Label();
            this.numCommission = new System.Windows.Forms.NumericUpDown();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCommission)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomPda
            // 
            this.labelNomPda.AutoSize = true;
            this.labelNomPda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomPda.Location = new System.Drawing.Point(40, 43);
            this.labelNomPda.Name = "labelNomPda";
            this.labelNomPda.Size = new System.Drawing.Size(74, 18);
            this.labelNomPda.TabIndex = 0;
            this.labelNomPda.Text = "Nom PDA";
            // 
            // txtNomPda
            // 
            this.txtNomPda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomPda.Location = new System.Drawing.Point(170, 40);
            this.txtNomPda.Name = "txtNomPda";
            this.txtNomPda.Size = new System.Drawing.Size(280, 24);
            this.txtNomPda.TabIndex = 1;
            // 
            // labelCouleur
            // 
            this.labelCouleur.AutoSize = true;
            this.labelCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCouleur.Location = new System.Drawing.Point(40, 88);
            this.labelCouleur.Name = "labelCouleur";
            this.labelCouleur.Size = new System.Drawing.Size(61, 18);
            this.labelCouleur.TabIndex = 2;
            this.labelCouleur.Text = "Couleur";
            // 
            // txtCouleur
            // 
            this.txtCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCouleur.Location = new System.Drawing.Point(170, 85);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.ReadOnly = true;
            this.txtCouleur.Size = new System.Drawing.Size(155, 24);
            this.txtCouleur.TabIndex = 3;
            // 
            // btnSelectCouleur
            // 
            this.btnSelectCouleur.Location = new System.Drawing.Point(331, 85);
            this.btnSelectCouleur.Name = "btnSelectCouleur";
            this.btnSelectCouleur.Size = new System.Drawing.Size(119, 24);
            this.btnSelectCouleur.TabIndex = 4;
            this.btnSelectCouleur.Text = "select";
            this.btnSelectCouleur.UseVisualStyleBackColor = true;
            // 
            // labelVendeur
            // 
            this.labelVendeur.AutoSize = true;
            this.labelVendeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendeur.Location = new System.Drawing.Point(40, 133);
            this.labelVendeur.Name = "labelVendeur";
            this.labelVendeur.Size = new System.Drawing.Size(63, 18);
            this.labelVendeur.TabIndex = 5;
            this.labelVendeur.Text = "Vendeur";
            // 
            // cmbVendeur
            // 
            this.cmbVendeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVendeur.FormattingEnabled = true;
            this.cmbVendeur.Location = new System.Drawing.Point(170, 130);
            this.cmbVendeur.Name = "cmbVendeur";
            this.cmbVendeur.Size = new System.Drawing.Size(280, 26);
            this.cmbVendeur.TabIndex = 6;
            // 
            // labelCommission
            // 
            this.labelCommission.AutoSize = true;
            this.labelCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommission.Location = new System.Drawing.Point(40, 178);
            this.labelCommission.Name = "labelCommission";
            this.labelCommission.Size = new System.Drawing.Size(106, 18);
            this.labelCommission.TabIndex = 7;
            this.labelCommission.Text = "commission %";
            // 
            // numCommission
            // 
            this.numCommission.DecimalPlaces = 3;
            this.numCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCommission.Location = new System.Drawing.Point(170, 176);
            this.numCommission.Name = "numCommission";
            this.numCommission.Size = new System.Drawing.Size(155, 24);
            this.numCommission.TabIndex = 8;
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(489, 75);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(125, 40);
            this.btnValider.TabIndex = 9;
            this.btnValider.Text = "Valider";
            this.btnValider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(489, 121);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(125, 40);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FichePda
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(642, 233);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.numCommission);
            this.Controls.Add(this.labelCommission);
            this.Controls.Add(this.cmbVendeur);
            this.Controls.Add(this.labelVendeur);
            this.Controls.Add(this.btnSelectCouleur);
            this.Controls.Add(this.txtCouleur);
            this.Controls.Add(this.labelCouleur);
            this.Controls.Add(this.txtNomPda);
            this.Controls.Add(this.labelNomPda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FichePda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PDA";
            ((System.ComponentModel.ISupportInitialize)(this.numCommission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label labelNomPda;
        private System.Windows.Forms.TextBox txtNomPda;
        private System.Windows.Forms.Label labelCouleur;
        private System.Windows.Forms.TextBox txtCouleur;
        private System.Windows.Forms.Button btnSelectCouleur;
        private System.Windows.Forms.Label labelVendeur;
        private System.Windows.Forms.ComboBox cmbVendeur;
        private System.Windows.Forms.Label labelCommission;
        private System.Windows.Forms.NumericUpDown numCommission;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}