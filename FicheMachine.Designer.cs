namespace TAPTAGPOS // <-- Change this to your project's namespace
{
    partial class FicheMachine
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
            this.labelMachine = new System.Windows.Forms.Label();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.labelMarque = new System.Windows.Forms.Label();
            this.labelDateAcquisition = new System.Windows.Forms.Label();
            this.dtpDateAcquisition = new System.Windows.Forms.DateTimePicker();
            this.txtCapacite = new System.Windows.Forms.TextBox();
            this.labelCapacite = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMachine
            // 
            this.labelMachine.AutoSize = true;
            this.labelMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMachine.Location = new System.Drawing.Point(30, 37);
            this.labelMachine.Name = "labelMachine";
            this.labelMachine.Size = new System.Drawing.Size(64, 18);
            this.labelMachine.TabIndex = 0;
            this.labelMachine.Text = "Machine";
            // 
            // txtMachine
            // 
            this.txtMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachine.Location = new System.Drawing.Point(170, 34);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(280, 24);
            this.txtMachine.TabIndex = 1;
            // 
            // txtMarque
            // 
            this.txtMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarque.Location = new System.Drawing.Point(170, 74);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(280, 24);
            this.txtMarque.TabIndex = 2;
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarque.Location = new System.Drawing.Point(30, 77);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(58, 18);
            this.labelMarque.TabIndex = 2;
            this.labelMarque.Text = "Marque";
            // 
            // labelDateAcquisition
            // 
            this.labelDateAcquisition.AutoSize = true;
            this.labelDateAcquisition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateAcquisition.Location = new System.Drawing.Point(30, 117);
            this.labelDateAcquisition.Name = "labelDateAcquisition";
            this.labelDateAcquisition.Size = new System.Drawing.Size(123, 18);
            this.labelDateAcquisition.TabIndex = 4;
            this.labelDateAcquisition.Text = "Date d\'acquisition";
            // 
            // dtpDateAcquisition
            // 
            this.dtpDateAcquisition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateAcquisition.Location = new System.Drawing.Point(170, 114);
            this.dtpDateAcquisition.Name = "dtpDateAcquisition";
            this.dtpDateAcquisition.Size = new System.Drawing.Size(280, 24);
            this.dtpDateAcquisition.TabIndex = 3;
            // 
            // txtCapacite
            // 
            this.txtCapacite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacite.Location = new System.Drawing.Point(170, 154);
            this.txtCapacite.Name = "txtCapacite";
            this.txtCapacite.Size = new System.Drawing.Size(280, 24);
            this.txtCapacite.TabIndex = 4;
            // 
            // labelCapacite
            // 
            this.labelCapacite.AutoSize = true;
            this.labelCapacite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacite.Location = new System.Drawing.Point(30, 157);
            this.labelCapacite.Name = "labelCapacite";
            this.labelCapacite.Size = new System.Drawing.Size(65, 18);
            this.labelCapacite.TabIndex = 6;
            this.labelCapacite.Text = "Capacité";
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(85, 210);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(125, 40);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            // 
            // btnFermer
            // 
            this.btnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(216, 210);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(125, 40);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // FicheMachine
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFermer;
            this.ClientSize = new System.Drawing.Size(482, 273);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtCapacite);
            this.Controls.Add(this.labelCapacite);
            this.Controls.Add(this.dtpDateAcquisition);
            this.Controls.Add(this.labelDateAcquisition);
            this.Controls.Add(this.txtMarque);
            this.Controls.Add(this.labelMarque);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.labelMachine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FicheMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Machine";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelMachine;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.Label labelMarque;
        private System.Windows.Forms.Label labelDateAcquisition;
        private System.Windows.Forms.DateTimePicker dtpDateAcquisition;
        private System.Windows.Forms.TextBox txtCapacite;
        private System.Windows.Forms.Label labelCapacite;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnFermer;
    }
}