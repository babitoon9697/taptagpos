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
    public partial class Changement_Tarifs : Form
    {
        public Changement_Tarifs()
        {
            InitializeComponent();
        }
        public Action<string> OnTarifSelected { get; set; }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            // Save the selected tarif (you can change the string to whatever value you need)
            string selectedTarif = "Gros";

            // Invoke the callback to send the selected tarif to the parent form
            OnTarifSelected?.Invoke(selectedTarif);

            // Close the child form after selecting the tarif
            this.Close();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            // Save the selected tarif (you can change the string to whatever value you need)
            string selectedTarif = "Detail";

            // Invoke the callback to send the selected tarif to the parent form
            OnTarifSelected?.Invoke(selectedTarif);

            // Close the child form after selecting the tarif
            this.Close();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            // Save the selected tarif (you can change the string to whatever value you need)
            string selectedTarif = "Semi Gros";

            // Invoke the callback to send the selected tarif to the parent form
            OnTarifSelected?.Invoke(selectedTarif);

            // Close the child form after selecting the tarif
            this.Close();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            // Save the selected tarif (you can change the string to whatever value you need)
            string selectedTarif = "special";

            // Invoke the callback to send the selected tarif to the parent form
            OnTarifSelected?.Invoke(selectedTarif);

            // Close the child form after selecting the tarif
            this.Close();
        }
    }
}
