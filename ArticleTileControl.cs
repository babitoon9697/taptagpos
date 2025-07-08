using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class ArticleTileControl : UserControl
    {
        public int ArticleID { get; private set; }
        public string ArticleCode { get; private set; }

        public ArticleTileControl(int id, string code, string name, decimal stock, Image image)
        {
            InitializeComponent();
            this.ArticleID = id;
            this.ArticleCode = code;
            this.lblArticleName.Text = name;
            this.lblStock.Text = $"Stock: {stock:N2}";
            this.picArticle.Image = image ?? Properties.Resources.icons8_cashier_100; // Use a default image if none exists

            // Wire up click events to bubble up to the parent
            this.Click += (s, e) => OnClick(e);
            foreach (Control control in this.Controls)
            {
                control.Click += (s, e) => OnClick(e);
            }
        }
    }
}