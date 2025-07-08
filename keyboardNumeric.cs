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
    public partial class keyboardNumeric : Form
    {
        public keyboardNumeric()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            txt_quantity.Text = txt_quantity.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt_quantity.Text = txt_quantity.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt_quantity.Text = txt_quantity.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt_quantity.Text = txt_quantity.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt_quantity.Text = txt_quantity.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt_quantity.Text = txt_quantity.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt_quantity.Text = txt_quantity.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt_quantity.Text = txt_quantity.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt_quantity.Text = txt_quantity.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt_quantity.Text = txt_quantity.Text + "0";
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            txt_quantity.Text = txt_quantity.Text + ",";
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            txt_quantity.Text = "";
        }
        public float Montant { get; private set; }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            // Validate the input
            if (float.TryParse(txt_quantity.Text, out float quantity) && quantity > 0)
            {
                Montant = quantity; // Save the quantity
                this.DialogResult = DialogResult.OK; // Set the DialogResult
                this.Close(); // Close the form
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
