using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using static Bunifu.UI.WinForms.Helpers.Transitions.Transition;

namespace TAPTAGPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void bunifuPictureBox12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            CaisseCafe c = new CaisseCafe();
            c.Show();
        }
        public Caisse cais;
        int lhala = 0; //0 bla ma thal, 1 hal
        private void btn_facture_Click(object sender, EventArgs e)
        {
            LISTTICKET art = new LISTTICKET();
            art.Show();
        }



        private void btnAchat_Click(object sender, EventArgs e)
        {
            ListeTicketPurchase art = new ListeTicketPurchase();
            
        
            art.Show();
           
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
           
            stock.StartPosition = FormStartPosition.CenterScreen;
            stock.Show();
        }

        private void btn_fournisseurs_Click(object sender, EventArgs e)
        {
            SupplierTableForm supp = new SupplierTableForm();
            supp.StartPosition = FormStartPosition.CenterScreen;
            supp.Show();
           
        }

        private void Btn_Credit_Click(object sender, EventArgs e)
        {

            frmAddCustomerPayment articlesForm = new frmAddCustomerPayment();
            articlesForm.StartPosition = FormStartPosition.CenterScreen;
            articlesForm.Show();
           
        }

        private void btnArticles_Click(object sender, EventArgs e)
        {
            ListArticles articlesForm = new ListArticles();
            articlesForm.StartPosition = FormStartPosition.CenterScreen;
            articlesForm.Show();

           
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            FormImpressionBarcode frm = new FormImpressionBarcode();
            frm.ShowDialog(this);
        }

        private void btn_Statistic_Click(object sender, EventArgs e)
        {
            FormStatistiquesVentes frm = new FormStatistiquesVentes();
            frm.ShowDialog(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            DirectoryAdmin adm = new DirectoryAdmin();
            adm.Show();
;
        }

        private void Btn_ListePosSession_Click(object sender, EventArgs e)
        {
            FormPosSession frm = new FormPosSession();
            frm.ShowDialog(this);
        }
    }
}
