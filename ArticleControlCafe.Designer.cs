namespace TAPTAGPOS
{
    partial class ArticleControlCafe
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
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.lblBuyPrice = new System.Windows.Forms.Label();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.lblQuantityStock = new System.Windows.Forms.Label();
            this.lblNameArticle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ico_stockindicateur = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.ArticleImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArticleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBuyPrice.Location = new System.Drawing.Point(4, 0);
            this.lblBuyPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(70, 19);
            this.lblBuyPrice.TabIndex = 4;
            this.lblBuyPrice.Text = "5.00 DH";
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellPrice.ForeColor = System.Drawing.Color.Green;
            this.lblSellPrice.Location = new System.Drawing.Point(4, 175);
            this.lblSellPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(55, 38);
            this.lblSellPrice.TabIndex = 1;
            this.lblSellPrice.Text = "10.00 DH";
            // 
            // lblQuantityStock
            // 
            this.lblQuantityStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantityStock.AutoSize = true;
            this.lblQuantityStock.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityStock.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityStock.Location = new System.Drawing.Point(269, 194);
            this.lblQuantityStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityStock.Name = "lblQuantityStock";
            this.lblQuantityStock.Size = new System.Drawing.Size(27, 19);
            this.lblQuantityStock.TabIndex = 2;
            this.lblQuantityStock.Text = "22";
            // 
            // lblNameArticle
            // 
            this.lblNameArticle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameArticle.AutoSize = true;
            this.lblNameArticle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblNameArticle.Location = new System.Drawing.Point(131, 175);
            this.lblNameArticle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameArticle.Name = "lblNameArticle";
            this.lblNameArticle.Size = new System.Drawing.Size(65, 22);
            this.lblNameArticle.TabIndex = 0;
            this.lblNameArticle.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.66667F));
            this.tableLayoutPanel1.Controls.Add(this.lblBuyPrice, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSellPrice, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantityStock, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ico_stockindicateur, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNameArticle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ArticleImage, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.73709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.84977F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.88263F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 213);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ico_stockindicateur
            // 
            this.ico_stockindicateur.AllowAnimations = true;
            this.ico_stockindicateur.AllowBorderColorChanges = true;
            this.ico_stockindicateur.AllowMouseEffects = true;
            this.ico_stockindicateur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ico_stockindicateur.AnimationSpeed = 200;
            this.ico_stockindicateur.BackColor = System.Drawing.Color.Transparent;
            this.ico_stockindicateur.BackgroundColor = System.Drawing.Color.Red;
            this.ico_stockindicateur.BorderColor = System.Drawing.Color.Red;
            this.ico_stockindicateur.BorderRadius = 1;
            this.ico_stockindicateur.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.ico_stockindicateur.BorderThickness = 1;
            this.ico_stockindicateur.ColorContrastOnClick = 30;
            this.ico_stockindicateur.ColorContrastOnHover = 30;
            this.ico_stockindicateur.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.ico_stockindicateur.CustomizableEdges = borderEdges2;
            this.ico_stockindicateur.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ico_stockindicateur.Image = null;
            this.ico_stockindicateur.ImageMargin = new System.Windows.Forms.Padding(0);
            this.ico_stockindicateur.Location = new System.Drawing.Point(276, 4);
            this.ico_stockindicateur.Margin = new System.Windows.Forms.Padding(4);
            this.ico_stockindicateur.Name = "ico_stockindicateur";
            this.ico_stockindicateur.RoundBorders = true;
            this.ico_stockindicateur.ShowBorders = true;
            this.ico_stockindicateur.Size = new System.Drawing.Size(20, 20);
            this.ico_stockindicateur.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.ico_stockindicateur.TabIndex = 5;
            // 
            // ArticleImage
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ArticleImage, 3);
            this.ArticleImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArticleImage.Location = new System.Drawing.Point(3, 27);
            this.ArticleImage.Name = "ArticleImage";
            this.ArticleImage.Size = new System.Drawing.Size(294, 129);
            this.ArticleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ArticleImage.TabIndex = 6;
            this.ArticleImage.TabStop = false;
            // 
            // ArticleControlCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ArticleControlCafe";
            this.Size = new System.Drawing.Size(300, 213);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArticleImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBuyPrice;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.Label lblQuantityStock;
        private System.Windows.Forms.Label lblNameArticle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton ico_stockindicateur;
        private System.Windows.Forms.PictureBox ArticleImage;
    }
}
