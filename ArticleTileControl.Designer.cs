namespace TAPTAGPOS
{
    partial class ArticleTileControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.picArticle = new System.Windows.Forms.PictureBox();
            this.lblArticleName = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // picArticle
            // 
            this.picArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picArticle.Location = new System.Drawing.Point(3, 3);
            this.picArticle.Name = "picArticle";
            this.picArticle.Size = new System.Drawing.Size(222, 109);
            this.picArticle.TabIndex = 0;
            this.picArticle.TabStop = false;
            // 
            // lblArticleName
            // 
            this.lblArticleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArticleName.AutoSize = true;
            this.lblArticleName.Location = new System.Drawing.Point(17, 115);
            this.lblArticleName.Name = "lblArticleName";
            this.lblArticleName.Size = new System.Drawing.Size(35, 13);
            this.lblArticleName.TabIndex = 1;
            this.lblArticleName.Text = "label1";
            // 
            // lblStock
            // 
            this.lblStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(172, 115);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "label2";
            // 
            // ArticleTileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblArticleName);
            this.Controls.Add(this.picArticle);
            this.Name = "ArticleTileControl";
            this.Size = new System.Drawing.Size(228, 136);
            ((System.ComponentModel.ISupportInitialize)(this.picArticle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picArticle;
        private System.Windows.Forms.Label lblArticleName;
        private System.Windows.Forms.Label lblStock;
    }
}
