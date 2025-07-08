using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class ArticleControlCafe : UserControl
    {
        public Article ArticleData { get; set; }

        public event EventHandler<Article> ArticleClicked;
        public Article CurrentArticle { get; private set; }

        public ArticleControlCafe()
        {
            InitializeComponent();
            // --- Main UserControl Events ---

            // Wires up the main UserControl's click, mouse enter, and mouse leave events.
            this.Click += new System.EventHandler(this.ArticleControl_Click);
            this.MouseEnter += new System.EventHandler(this.ArticleUserControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ArticleUserControl_MouseLeave);


            // --- Child Control Events ---

            // It's recommended to call your "WireUpClickEvents(this)" method from your
            // constructor to handle all clicks uniformly, including for the new PictureBox.
            // However, the explicit links from your code are shown below.

            // Links for the main panel within the control
            // Note: Calling InitializeTagLabel() on hover will create memory leaks.
            // This should be corrected to avoid creating a new label on every hover.
            this.tableLayoutPanel1.MouseHover += new System.EventHandler(this.tableLayoutPanel1_MouseHover);
            // To make the panel clickable, you would add:
            this.tableLayoutPanel1.Click += new System.EventHandler(this.HandleClick);

            // Links for the article name label
            this.lblNameArticle.MouseEnter += new System.EventHandler(this.lblNameArticle_MouseEnter);
            this.lblNameArticle.MouseLeave += new System.EventHandler(this.lblNameArticle_MouseLeave);
            this.lblNameArticle.MouseHover += new System.EventHandler(this.lblNameArticle_MouseHover);
            this.lblNameArticle.Click += new System.EventHandler(this.HandleClick);

            // Links for the new ArticleImage PictureBox
            this.ArticleImage.Click += new System.EventHandler(this.HandleClick);
            this.ArticleImage.MouseEnter += new System.EventHandler(this.ArticleUserControl_MouseEnter);
            this.ArticleImage.MouseLeave += new System.EventHandler(this.ArticleUserControl_MouseLeave);

            // You would repeat the .Click, .MouseEnter, and .MouseLeave links for other controls
            // like lblQuantityStock, lblBuyPrice, lblSellPrice, and ico_stockindicateur.
            InitializeTagLabel();
        }
        private void ArticleControl_Click(object sender, EventArgs e)
        {
            // Trigger the event when the control is clicked
            ArticleClicked?.Invoke(this, ArticleData);
            InitializeTagLabel();
            tagLabel.Visible = true;
            tagLabel.Location = new Point(this.Width - tagLabel.Width, 0);
        }
        private void HandleClick(object sender, EventArgs e)
        {
            ArticleClicked?.Invoke(this, this.CurrentArticle);
        }

        private void WireUpClickEvents(Control container)
        {
            container.Click += HandleClick;
            foreach (Control ctl in container.Controls)
            {
                WireUpClickEvents(ctl);
            }
        }
        public void SetArticleData(Article article)
        {
            ArticleData = article;
            lblNameArticle.Text = article.ArticleCode;
            lblQuantityStock.Text = $"{article.QuantityStock:N2}";
            lblBuyPrice.Text = article.BuyPrice.ToString("C2");   // Formats as currency
            lblSellPrice.Text = article.SellPrice.ToString("C2"); // Formats as currency            
            if (article.QuantityStock <= 0)
            {
                // Set indicator to RED if out of stock
                ico_stockindicateur.BackgroundColor = Color.Red;
                ico_stockindicateur.BorderColor = Color.Red;
            }
            else
            {
                // Set indicator to GREEN if in stock
                ico_stockindicateur.BackgroundColor = Color.LimeGreen;
                ico_stockindicateur.BorderColor = Color.LimeGreen;
            }
            if (!string.IsNullOrEmpty(article.ImagePath) && System.IO.File.Exists(article.ImagePath))
            {
                try
                {
                    // Load the image. Using a temporary bitmap prevents locking the file.
                    using (var bmpTemp = new Bitmap(article.ImagePath))
                    {
                        this.ArticleImage.Image = new Bitmap(bmpTemp);
                    }
                }
                catch
                {
                    // If loading fails, show a default "not found" image
                    // (You should add a placeholder image to your project's Resources)
                    //this.ArticleImage.Image = Properties.Resources.ImageNotFound;
                }
            }
            else
            {
                // If no path is provided or the file doesn't exist, show the placeholder
                //this.ArticleImage.Image = Properties.Resources.ImageNotFound;
            }
        }
        private Label tagLabel;
        private void InitializeTagLabel()
        {
            tagLabel = new Label
            {
                Visible = false,
                AutoSize = false,
                Width = 120,
                Height = 50,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(255, 255, 255),
                BorderStyle = BorderStyle.FixedSingle,
                Image = Properties.Resources.icons8_clock_100,
                ImageAlign = ContentAlignment.MiddleCenter,
            };
            this.Controls.Add(tagLabel);
            this.MouseEnter += new EventHandler(ArticleUserControl_MouseEnter);
            this.MouseLeave += new EventHandler(ArticleUserControl_MouseLeave);
        }
        private void ArticleUserControl_MouseEnter(object sender, EventArgs e)
        {
            tagLabel.Visible = true;
            tagLabel.Location = new Point(this.Width - tagLabel.Width, 0);
        }
        private void ArticleUserControl_MouseLeave(object sender, EventArgs e)
        {
            tagLabel.Visible = false;
        }

        private void tableLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
            InitializeTagLabel();
        }

        private void lblNameArticle_MouseHover(object sender, EventArgs e)
        {
            InitializeTagLabel();
        }

        private void lblNameArticle_MouseEnter(object sender, EventArgs e)
        {
            tagLabel.Visible = true;
            tagLabel.Location = new Point(this.Width - tagLabel.Width, 0);
        }

        private void lblNameArticle_MouseLeave(object sender, EventArgs e)
        {
            tagLabel.Visible = false;
        }
    }

}
