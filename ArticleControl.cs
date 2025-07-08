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
    public partial class ArticleControl : UserControl
    {
        public Article ArticleData { get; set; }

        public event EventHandler<Article> ArticleClicked;
        public Article CurrentArticle { get; private set; }

        public ArticleControl()
        {
            InitializeComponent();
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
                                                                  // 
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
        private void ArticleUserControl_MouseEnter(object sender , EventArgs e)
        {
            tagLabel.Visible = true;
            tagLabel.Location = new Point(this.Width - tagLabel.Width,0);
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
