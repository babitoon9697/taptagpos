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
    public partial class TableFacture : Form
    {
        public TableFacture()
        {
            InitializeComponent();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            FicheFacture editorForm = new FicheFacture();
            editorForm.ShowDialog();
        }
    }
}
