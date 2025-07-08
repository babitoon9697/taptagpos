using System;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class DirectoryAdmin : Form
    {
        public DirectoryAdmin()
        {
            InitializeComponent();
        }

        private void bunifuButton221_Click(object sender, EventArgs e)
        {
            ListeTicketPurchase art = new ListeTicketPurchase();
            art.Show();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Category stock = new Category();
            this.Hide();
            stock.StartPosition = FormStartPosition.CenterScreen;
            stock.Show();
            stock.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            stock.Resize += (s, args) =>
            {
                if (stock.WindowState == FormWindowState.Minimized)
                {
                    this.Show();
                }
                else if (stock.WindowState == FormWindowState.Maximized || stock.WindowState == FormWindowState.Normal)
                {
                    this.Hide();
                }
            };
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            this.Hide();
            stock.StartPosition = FormStartPosition.CenterScreen;
            stock.Show();
            stock.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            stock.Resize += (s, args) =>
            {
                if (stock.WindowState == FormWindowState.Minimized)
                {
                    this.Show();
                }
                else if (stock.WindowState == FormWindowState.Maximized || stock.WindowState == FormWindowState.Normal)
                {
                    this.Hide();
                }
            };
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            frmStockMovement stock = new frmStockMovement();
            this.Hide();
            stock.StartPosition = FormStartPosition.CenterScreen;
            stock.Show();
            stock.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            stock.Resize += (s, args) =>
            {
                if (stock.WindowState == FormWindowState.Minimized)
                {
                    this.Show();
                }
                else if (stock.WindowState == FormWindowState.Maximized || stock.WindowState == FormWindowState.Normal)
                {
                    this.Hide();
                }
            };
        }

        private void btn_articles_Click(object sender, EventArgs e)
        {
            ListArticles art = new ListArticles();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            frmCustomersList art = new frmCustomersList();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }

        private void btn_CustomerStates_Click(object sender, EventArgs e)
        {
            frmCustomerStatus art = new frmCustomerStatus();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();

        }

        private void bunifuButton219_Click(object sender, EventArgs e)
        {
            SupplierTableForm art = new SupplierTableForm();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }

        private void btn_cheque_Click(object sender, EventArgs e)
        {
            ClientChecksForm art = new ClientChecksForm();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }

        private void bunifuButton215_Click(object sender, EventArgs e)
        {
            frmAddCustomerPayment art = new frmAddCustomerPayment();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_expensesList_Click(object sender, EventArgs e)
        {
            frmExpensesList art = new frmExpensesList();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }



        private void btn_listusers_Click(object sender, EventArgs e)
        {
            frmUsersList art = new frmUsersList();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }

        private void bunifuButton220_Click(object sender, EventArgs e)
        {
            // افترض أن لديك طريقة لمعرفة ما إذا كان المستخدم الحالي هو مدير
            // bool isAdmin = CurrentUser.Role == "Admin"; // مثال

            bool isAdmin = true; // سنفترض مؤقتاً أنه مدير لأغراض الاختبار

            if (isAdmin)
            {
                // إذا كان المستخدم مديراً، اطلب منه الرمز السري
                using (frmIdentification identificationForm = new frmIdentification())
                {
                    // إذا أدخل المستخدم الرمز الصحيح وضغط "OK"
                    if (identificationForm.ShowDialog() == DialogResult.OK)
                    {
                        // فقط في هذه الحالة، قم بفتح شاشة الأرباح
                        using (frmProfits profitsForm = new frmProfits())
                        {
                            profitsForm.ShowDialog();
                        }
                    }
                    // إذا أغلق النافذة أو أدخل رمزاً خاطئاً، لن يحدث شيء
                }
            }
            else
            {
                MessageBox.Show("ليس لديك الصلاحيات الكافية للوصول إلى هذا التقرير.", "وصول مرفوض", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_allstockage_Click(object sender, EventArgs e)
        {
            frmInventoryStatus art = new frmInventoryStatus();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            frmStockMovement art = new frmStockMovement();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }

        private void bunifuButton225_Click(object sender, EventArgs e)
        {
            frmAddSupplierPayment art = new frmAddSupplierPayment();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }

        private void btn_fournisseurStat_Click(object sender, EventArgs e)
        {

            GlobalSupplierSituationForm art = new GlobalSupplierSituationForm();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }

        private void bunifuButton212_Click(object sender, EventArgs e)
        {
            ClientSituationByItemForm art = new ClientSituationByItemForm();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }

        private void bunifuButton227_Click(object sender, EventArgs e)
        {
            SupplierSituationForm art = new SupplierSituationForm();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }

        private void bunifuButton229_Click(object sender, EventArgs e)
        {
            SupplierChecksForm art = new SupplierChecksForm();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
            
        }

        private void bunifuButton210_Click(object sender, EventArgs e)
        {
            LISTTICKET attForm = new LISTTICKET();
            attForm.ShowDialog();
        }

        private void bunifuButton224_Click(object sender, EventArgs e)
        {
            InvoicesForm art = new InvoicesForm();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }

        private void bunifuButton222_Click(object sender, EventArgs e)
        {
            frmProfitsByCustomer art = new frmProfitsByCustomer();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }

        private void bunifuButton211_Click(object sender, EventArgs e)
        {

        }

        private void btn_situtationcustomer_Click(object sender, EventArgs e)
        {
            ClientSituationForm art = new ClientSituationForm();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }

        private void btn_taptagSett_Click(object sender, EventArgs e)
        {
            TapTagAdministration art = new TapTagAdministration();

            art.FormClosed += (s, args) =>
            {
                this.Show();        // Bring main form back to focus
            };
            this.Hide();
            art.Show();
        }
    }
}
