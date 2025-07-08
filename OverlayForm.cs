using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;

namespace TAPTAGPOS
{
    public partial class OverlayForm : Form
    {
        public OverlayForm(Form owner)
        {
            InitializeComponent();
            this.Owner = owner; // Set the owner form
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.Opacity = 0.3;
            this.StartPosition = FormStartPosition.Manual;

            // Make the overlay size match the owner form's bounds
            this.Bounds = owner.Bounds;
        }
    }
}
