namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class FicheBanque
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
            this.labelNumCompte = new System.Windows.Forms.Label();
            this.txtNumCompte = new System.Windows.Forms.TextBox();
            this.txtBanque = new System.Windows.Forms.TextBox();
            this.labelBanque = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumCompte
            // 
            this.labelNumCompte.AutoSize = true;
            this.labelNumCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumCompte.Location = new System.Drawing.Point(22, 30);
            this.labelNumCompte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumCompte.Name = "labelNumCompte";
            this.labelNumCompte.Size = new System.Drawing.Size(67, 15);
            this.labelNumCompte.TabIndex = 0;
            this.labelNumCompte.Text = "N° Compte";
            // 
            // txtNumCompte
            // 
            this.txtNumCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCompte.Location = new System.Drawing.Point(98, 28);
            this.txtNumCompte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumCompte.Name = "txtNumCompte";
            this.txtNumCompte.Size = new System.Drawing.Size(188, 21);
            this.txtNumCompte.TabIndex = 1;
            // 
            // txtBanque
            // 
            this.txtBanque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanque.Location = new System.Drawing.Point(98, 60);
            this.txtBanque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBanque.Name = "txtBanque";
            this.txtBanque.Size = new System.Drawing.Size(188, 21);
            this.txtBanque.TabIndex = 2;
            // 
            // labelBanque
            // 
            this.labelBanque.AutoSize = true;
            this.labelBanque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBanque.Location = new System.Drawing.Point(22, 63);
            this.labelBanque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBanque.Name = "labelBanque";
            this.labelBanque.Size = new System.Drawing.Size(50, 15);
            this.labelBanque.TabIndex = 2;
            this.labelBanque.Text = "Banque";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(304, 28);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 32);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(304, 65);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(94, 32);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FicheBanque
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(414, 108);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBanque);
            this.Controls.Add(this.labelBanque);
            this.Controls.Add(this.txtNumCompte);
            this.Controls.Add(this.labelNumCompte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FicheBanque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche Banque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label labelNumCompte;
        private System.Windows.Forms.TextBox txtNumCompte;
        private System.Windows.Forms.TextBox txtBanque;
        private System.Windows.Forms.Label labelBanque;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}