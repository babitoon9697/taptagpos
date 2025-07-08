using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TAPTAGPOS
{
    public partial class CategoryControl : UserControl
    {
        private bool _isSelected;
        private Color _originalColor = Color.MidnightBlue;

        // --- NEW: Properties to hold the ID and Name ---
        public int? CategoryID { get; private set; }
        public string CategoryName { get; private set; }

        public event EventHandler CategoryClicked;

        public CategoryControl()
        {
            InitializeComponent();
            WireMouseEvents(this);
        }

        public void SetData(int? id, string name)
        {
            this.CategoryID = id;
            this.CategoryName = name;
            this.lblCategoryName.Text = name;
        }

        [Category("Custom Props")]
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                // --- FIX: Change color based on selection ---
                this.lblCategoryName.BackColor = _isSelected ? Color.Red : _originalColor;
            }
        }

        private void WireMouseEvents(Control container)
        {
            foreach (Control ctl in container.Controls)
            {
                ctl.Click += (s, e) => this.OnClick(e);
                ctl.MouseEnter += (s, e) => this.OnMouseEnter(e);
                ctl.MouseLeave += (s, e) => this.OnMouseLeave(e);
                if (ctl.HasChildren)
                {
                    WireMouseEvents(ctl);
                }
            }
        }

        // Raise the custom event when the control is clicked
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            CategoryClicked?.Invoke(this, e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (!IsSelected) { this.lblCategoryName.BackColor = Color.RoyalBlue; }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (!IsSelected) { this.lblCategoryName.BackColor = _originalColor; }
        }
    }
}