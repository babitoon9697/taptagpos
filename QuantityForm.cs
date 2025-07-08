// In QuantityForm.cs

using System;
using System.Globalization; // For NumberStyles and CultureInfo
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public enum InputDialogMode
    {
        Quantity,
        Price
    }

    public partial class QuantityForm : Form
    {
        public decimal Quantity { get; private set; }      // Changed to int
        public decimal Price { get; private set; }     // Added for price

        private InputDialogMode currentMode;
        // Assume txt_quantity is your main TextBox for input.
        // Assume you add a Label named lblPrompt to your form designer for dynamic text.

        // Default constructor (can be made private if you always require a mode)
        public QuantityForm()
        {
            InitializeComponent();
            // Default to Quantity mode if no specific constructor is called.
            // However, it's better to always call one of the specific constructors.
            if (this.Tag == null) // Check if mode has been set by other constructors
            {
                InitializeForMode(InputDialogMode.Quantity, 1); // Default to quantity 1
            }
        }

        // Constructor for Quantity input
        public QuantityForm(int initialQuantity) : this() // Calls the default constructor first
        {
            InitializeForMode(InputDialogMode.Quantity, initialQuantity);
        }

        // Constructor for Price input
        public QuantityForm(decimal initialPrice) : this() // Calls the default constructor first
        {
            InitializeForMode(InputDialogMode.Price, initialPrice);
        }

        private void InitializeForMode(InputDialogMode mode, object initialValue)
        {
            currentMode = mode;
            this.Tag = mode; // Store mode if needed elsewhere, or just use currentMode

            if (mode == InputDialogMode.Quantity)
            {
                this.Text = "Modifier Quantité";
                if (lblPrompt != null) lblPrompt.Text = "Nouvelle Quantité:"; // Add lblPrompt to your form
                // Disable comma button for integer quantity
            }
            else // InputDialogMode.Price
            {
                this.Text = "Modifier Prix d'Achat";
                if (lblPrompt != null) lblPrompt.Text = "Nouveau Prix d'Achat:"; // Add lblPrompt to your form
                // Enable comma button for decimal price
            }
            txt_quantity.SelectAll();
            txt_quantity.Focus();
        }

        // Numpad button handlers (0-9) - these are fine as they append text
        private void bunifuButton21_Click(object sender, EventArgs e) { txt_quantity.Text += "1"; } // Assuming this is Button 1
        private void btn2_Click(object sender, EventArgs e) { txt_quantity.Text += "2"; }
        private void btn3_Click(object sender, EventArgs e) { txt_quantity.Text += "3"; }
        private void btn4_Click(object sender, EventArgs e) { txt_quantity.Text += "4"; }
        private void btn5_Click(object sender, EventArgs e) { txt_quantity.Text += "5"; }
        private void btn6_Click(object sender, EventArgs e) { txt_quantity.Text += "6"; }
        private void btn7_Click(object sender, EventArgs e) { txt_quantity.Text += "7"; }
        private void btn8_Click(object sender, EventArgs e) { txt_quantity.Text += "8"; }
        private void btn9_Click(object sender, EventArgs e) { txt_quantity.Text += "9"; }
        private void btn0_Click(object sender, EventArgs e) { txt_quantity.Text += "0"; }

        // Comma button
        private void bunifuButton22_Click(object sender, EventArgs e)
        {

                // Append culture-specific decimal separator if not already present
                string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                if (!txt_quantity.Text.Contains(decimalSeparator))
                {
                    txt_quantity.Text += decimalSeparator;
                }
            
        }

        // Delete/Clear button
        private void btn_del_Click(object sender, EventArgs e)
        {
            txt_quantity.Text = "";
        }

        // Validate button
        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (currentMode == InputDialogMode.Quantity)
            {
                if (decimal.TryParse(txt_quantity.Text, out decimal quantityValue))
                {
                    if (quantityValue <= 0) // Or >= 0 depending on if 0 is allowed
                    {
                        MessageBox.Show("La quantité doit être un nombre entier positif.", "Entrée Invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    this.Quantity = quantityValue;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Veuillez entrer une quantité valide (nombre entier).", "Entrée Invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else // currentMode == InputDialogMode.Price
            {
                // Try parsing with current culture, then invariant if needed
                if (decimal.TryParse(txt_quantity.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal priceValue) ||
                    decimal.TryParse(txt_quantity.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out priceValue))
                {
                    if (priceValue < 0)
                    {
                        MessageBox.Show("Le prix ne peut pas être négatif.", "Entrée Invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    this.Price = priceValue;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un prix valide.", "Entrée Invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Make sure you have a Label control in your designer named 'lblPrompt'
        // and your TextBox is named 'txt_quantity'.
        // The bunifuButton21 should be your button for "1".
        // The bunifuButton22 should be your button for "," (comma/decimal separator).
    }
}