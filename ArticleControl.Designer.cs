namespace TAPTAGPOS
{
    partial class ArticleControl
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
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.lblNameArticle = new System.Windows.Forms.Label();
            this.lblQuantityStock = new System.Windows.Forms.Label();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.lblBuyPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ico_stockindicateur = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNameArticle
            // 
            this.lblNameArticle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameArticle.AutoSize = true;
            this.lblNameArticle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblNameArticle.Location = new System.Drawing.Point(113, 29);
            this.lblNameArticle.Name = "lblNameArticle";
            this.lblNameArticle.Size = new System.Drawing.Size(50, 18);
            this.lblNameArticle.TabIndex = 0;
            this.lblNameArticle.Text = "label1";
            this.lblNameArticle.Click += new System.EventHandler(this.ArticleControl_Click);
            this.lblNameArticle.MouseEnter += new System.EventHandler(this.lblNameArticle_MouseEnter);
            this.lblNameArticle.MouseLeave += new System.EventHandler(this.lblNameArticle_MouseLeave);
            this.lblNameArticle.MouseHover += new System.EventHandler(this.lblNameArticle_MouseHover);
            // 
            // lblQuantityStock
            // 
            this.lblQuantityStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantityStock.AutoSize = true;
            this.lblQuantityStock.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityStock.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityStock.Location = new System.Drawing.Point(254, 61);
            this.lblQuantityStock.Name = "lblQuantityStock";
            this.lblQuantityStock.Size = new System.Drawing.Size(21, 16);
            this.lblQuantityStock.TabIndex = 2;
            this.lblQuantityStock.Text = "22";
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellPrice.ForeColor = System.Drawing.Color.Green;
            this.lblSellPrice.Location = new System.Drawing.Point(3, 61);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(61, 16);
            this.lblSellPrice.TabIndex = 1;
            this.lblSellPrice.Text = "10.00 DH";
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBuyPrice.Location = new System.Drawing.Point(3, 0);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(54, 16);
            this.lblBuyPrice.TabIndex = 4;
            this.lblBuyPrice.Text = "5.00 DH";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.Controls.Add(this.lblBuyPrice, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSellPrice, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantityStock, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNameArticle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ico_stockindicateur, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 77);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.ArticleControl_Click);
            this.tableLayoutPanel1.MouseHover += new System.EventHandler(this.tableLayoutPanel1_MouseHover);
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ico_stockindicateur.CustomizableEdges = borderEdges1;
            this.ico_stockindicateur.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ico_stockindicateur.Image = null;
            this.ico_stockindicateur.ImageMargin = new System.Windows.Forms.Padding(0);
            this.ico_stockindicateur.Location = new System.Drawing.Point(260, 3);
            this.ico_stockindicateur.Name = "ico_stockindicateur";
            this.ico_stockindicateur.RoundBorders = true;
            this.ico_stockindicateur.ShowBorders = true;
            this.ico_stockindicateur.Size = new System.Drawing.Size(15, 15);
            this.ico_stockindicateur.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.ico_stockindicateur.TabIndex = 5;
            // 
            // ArticleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ArticleControl";
            this.Size = new System.Drawing.Size(278, 77);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNameArticle;
        private System.Windows.Forms.Label lblQuantityStock;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.Label lblBuyPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton ico_stockindicateur;
    }
}
