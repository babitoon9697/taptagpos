using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace TAPTAGPOS
{
    public partial class ChequePaiement : Form
    {
        private decimal amountDue = 0;

        // --- خصائص عامة لإرجاع البيانات للفورم الأب ---
        public decimal AmountPaid { get; private set; }
        public string BankName { get; private set; }
        public string CheckNumber { get; private set; }
        public DateTime DueDate { get; private set; }
        public string PayerName { get; private set; }

        public ChequePaiement(decimal totalToPay)
        {

            InitializeComponent();
            this.amountDue = totalToPay;
        }
        string bankn = "";
        public ChequePaiement(decimal totalToPay, string ChequeNumber, string bankName)
        {

            InitializeComponent();
            this.amountDue = totalToPay;
            this.txt_NumCheque.Text = ChequeNumber;
            this.bankn = bankName;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ChequePaiement_Load(object sender, EventArgs e)
        {
            lbl_montant.Text = this.amountDue.ToString("N2");
            Date_Echeance.Value = DateTime.Now.AddDays(30); // تاريخ استحقاق افتراضي بعد شهر
            if (bankn == "" || bankn== string.Empty) 
                drop_banque.SelectedIndex = 0; // اختيار أول بنك في القائمة
            else drop_banque.Text = bankn;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            // --- التحقق من المدخلات ---
            if (string.IsNullOrWhiteSpace(txt_NumCheque.Text))
            {
                MessageBox.Show("الرجاء إدخال رقم الشيك.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_Nom.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم صاحب الشيك.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- تعبئة الخصائص بالبيانات المدخلة ---
            this.AmountPaid = Convert.ToDecimal(lbl_montant.Text);
            this.BankName = drop_banque.Text;
            this.CheckNumber = txt_NumCheque.Text;
            this.DueDate = Date_Echeance.Value;
            this.PayerName = txt_Nom.Text;

            this.DialogResult = DialogResult.OK; // إشارة إلى أن العملية نجحت
            this.Close();
        }
        bool changed=false;
        private void lbl_montant_Click(object sender, EventArgs e)
        {
            // استخدام فورم إدخال الأرقام لتغيير المبلغ
            using (QuantityForm numpad = new QuantityForm(Convert.ToDecimal(lbl_montant.Text)))
            {
                if (numpad.ShowDialog() == DialogResult.OK)
                {
                    if (numpad.Price > this.amountDue)
                    {
                        MessageBox.Show("المبلغ المدفوع لا يمكن أن يكون أكبر من المبلغ المتبقي.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lbl_montant.Text = this.amountDue.ToString("N2");
                    }
                    else
                    {
                        lbl_montant.Text = numpad.Price.ToString("N2");
                    }
                }
            }
        }
    }
}
