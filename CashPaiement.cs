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
    public partial class CashPaiement : Form
    {
        public decimal paid { get; private set; }
        public decimal reste { get; private set; }
        public decimal Total { get; private set; }
        public CashPaiement(decimal total)
        {
            InitializeComponent();
            this.Total = total;
            txt_total.Text = Total.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            txt_keyboard.Text = "";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_keyboard.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_keyboard.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_keyboard.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_keyboard.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_keyboard.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_keyboard.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_keyboard.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_keyboard.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_keyboard.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_keyboard.Text += "0";
        }

        private void btn_virgule_Click(object sender, EventArgs e)
        {
            txt_keyboard.Text += ",";
        }

        private void btn_confirmer_Click(object sender, EventArgs e)
        {
            if(txt_keyboard.Text != string.Empty)
            {
                paid = decimal.Parse(txt_keyboard.Text);
                reste = decimal.Parse(txt_total.Text) - paid;
                this.DialogResult = DialogResult.OK;

                // Close the dialog form
                this.Close();
            }
            else if(txt_keyboard.Text == string.Empty)
            {
                paid = decimal.Parse(txt_total.Text);
                reste = 0;
                this.DialogResult = DialogResult.OK;

                // Close the dialog form
                this.Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
