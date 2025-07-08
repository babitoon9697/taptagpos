using System;
using System.Globalization;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class DiscountForm : Form
    {
        // Public properties to return the result to the Caisse form
        public decimal DiscountValue { get; private set; }
        public bool IsPercentage { get; private set; }

        public DiscountForm()
        {
            InitializeComponent();
            InitializeNumpadEvents();
        }

        private void InitializeNumpadEvents()
        {
            // Connect all number buttons to a single handler
            btn1.Click += Numpad_Click;
            btn2.Click += Numpad_Click;
            btn3.Click += Numpad_Click;
            btn4.Click += Numpad_Click;
            btn5.Click += Numpad_Click;
            btn6.Click += Numpad_Click;
            btn7.Click += Numpad_Click;
            btn8.Click += Numpad_Click;
            btn9.Click += Numpad_Click;
            btn0.Click += Numpad_Click;
            btn_del.Click += (s, e) => { txt_pourcentage.Clear(); };
            btn_dot.Click += (s, e) =>
            {
                if (!txt_pourcentage.Text.Contains(","))
                    txt_pourcentage.Text += ",";
            };
            btn_valider.Click += btn_valider_Click;
        }

        private void Numpad_Click(object sender, EventArgs e)
        {
         
            var button = sender as Bunifu.UI.WinForms.BunifuButton.BunifuButton2;
            // --- END OF FIX ---

            if (button != null) // Add a safety check
            {
                txt_pourcentage.Text += button.Text;
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_pourcentage.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal value))
            {
                this.DiscountValue = value;
                this.IsPercentage = radio_discountpourcentage.Checked;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("الرجاء إدخال قيمة صحيحة.", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}