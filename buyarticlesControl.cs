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
    public partial class buyarticlesControl : UserControl
    {
        public Article ArticleData { get; set; }
        public event EventHandler<Article> ArticleClicked;
        private Label tagLabel;


        public buyarticlesControl()
        {
            InitializeComponent();
            InitializeTagLabel();
            InitializeStyle();
            SubscribeEvents();

        }
        private void SubscribeEvents()
        {
            this.Click += OnControlClick;
            lblNameArticle.Click += OnControlClick;
            lblBuyPrice.Click += OnControlClick;
            lblQuantityStock.Click += OnControlClick;
            tableLayoutPanel1.Click += OnControlClick;

            this.MouseEnter += OnMouseEnterHandler;
            this.MouseLeave += OnMouseLeaveHandler;
        }
        private void InitializeStyle()
        {
            this.Cursor = Cursors.Hand;
            this.Padding = new Padding(5);
            this.BackColor = Color.White;
        }

        private void InitializeTagLabel()
        {
            if (tagLabel != null) return;

            tagLabel = new Label
            {
                Text = "Quick Add",
                Width = 100,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.LightBlue,
                ForeColor = Color.Black,
                Visible = false
            };

            Controls.Add(tagLabel);
        }

        private void ShowTagLabel()
        {
            if (tagLabel == null) return;
            tagLabel.Visible = true;
            tagLabel.Location = new Point(Width - tagLabel.Width - 5, 5);
        }

        private void HideTagLabel()
        {
            if (tagLabel != null)
                tagLabel.Visible = false;
        }
        private void OnControlClick(object sender, EventArgs e)
        {
            ArticleClicked?.Invoke(this, ArticleData);
            ShowTagLabel();
        }

        public void SetArticleData(Article article)
        {
            ArticleData = article;
            lblNameArticle.Text = article.ArticleCode;
            lblQuantityStock.Text = $"Stock: {article.QuantityStock:N2}";
            lblBuyPrice.Text = $"{article.BuyPrice:C2}";
        
        }

        private void OnMouseEnterHandler(object sender, EventArgs e)
        {
            ShowTagLabel();
        }

        private void OnMouseLeaveHandler(object sender, EventArgs e)
        {
            HideTagLabel();
        }

        private void BuyArticleControl_Click(object sender, EventArgs e)
        {
            // Trigger the event when the control is clicked
            ArticleClicked?.Invoke(this, ArticleData);
            InitializeTagLabel();
            tagLabel.Visible = true;
            tagLabel.Location = new Point(this.Width - tagLabel.Width, 0);
        }

        private void buyarticlesControl_MouseEnter(object sender, EventArgs e)
        {
            tagLabel.Visible = true;
            tagLabel.Location = new Point(this.Width - tagLabel.Width, 0);
        }

        private void buyarticlesControl_MouseLeave(object sender, EventArgs e)
        {
            tagLabel.Visible = false;
        }

        private void buyarticlesControl_MouseHover(object sender, EventArgs e)
        {
            InitializeTagLabel();
        }

        private void lblNameArticle_Click(object sender, EventArgs e)
        {
            ArticleClicked?.Invoke(this, ArticleData);
        }

        private void lblBuyPrice_Click(object sender, EventArgs e)
        {
            ArticleClicked?.Invoke(this, ArticleData);
        }

        private void lblQuantityStock_Click(object sender, EventArgs e)
        {
            ArticleClicked?.Invoke(this, ArticleData);
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            ArticleClicked?.Invoke(this, ArticleData);
        }
    }
}
