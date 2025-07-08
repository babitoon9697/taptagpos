
namespace TAPTAGPOS
{
    partial class AddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // Note: Using standard controls for layout generation.
            // You can replace these with your Bunifu controls.
            this.lblCode = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblSalesperson = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTariff = new System.Windows.Forms.Label();
            this.lblCreditAllowed = new System.Windows.Forms.Label();
            this.lblDebtCeiling = new System.Windows.Forms.Label();
            this.lblCheckCeiling = new System.Windows.Forms.Label();
            this.lblPaymentTerm = new System.Windows.Forms.Label();
            this.lblIF = new System.Windows.Forms.Label();
            this.lblICE = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblCIN = new System.Windows.Forms.Label();

            this.txt_idcustomer = new System.Windows.Forms.TextBox();
            this.dropdown_Area = new System.Windows.Forms.ComboBox();
            this.dropdown_Salesperson = new System.Windows.Forms.ComboBox();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.txt_addresse = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_fax = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.dropdown_Tarifs = new System.Windows.Forms.ComboBox();
            this.chk_CreditAllowed = new System.Windows.Forms.CheckBox();
            this.txt_DebtCeiling = new System.Windows.Forms.TextBox();
            this.txt_CheckCeiling = new System.Windows.Forms.TextBox();
            this.txt_PaymentTerm = new System.Windows.Forms.TextBox();
            this.txt_IF = new System.Windows.Forms.TextBox();
            this.txt_ICE = new System.Windows.Forms.TextBox();
            this.txt_patente = new System.Windows.Forms.TextBox();
            this.txt_CIN = new System.Windows.Forms.TextBox();

            this.btn_AddCode = new System.Windows.Forms.Button();
            this.btn_TariffDetail = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();

            this.pnlCode = new System.Windows.Forms.Panel();
            this.pnlTariff = new System.Windows.Forms.Panel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            this.pnlButtons = new System.Windows.Forms.Panel();

            this.pnlCode.SuspendLayout();
            this.pnlTariff.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpBottom.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Padding = new System.Windows.Forms.Padding(10);
            this.tlpMain.RowCount = 11;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lblCode, 1, 0);
            this.tlpMain.Controls.Add(this.pnlCode, 0, 0);
            this.tlpMain.Controls.Add(this.lblArea, 1, 1);
            this.tlpMain.Controls.Add(this.dropdown_Area, 0, 1);
            this.tlpMain.Controls.Add(this.lblSalesperson, 1, 2);
            this.tlpMain.Controls.Add(this.dropdown_Salesperson, 0, 2);
            this.tlpMain.Controls.Add(this.lblCustomerName, 1, 3);
            this.tlpMain.Controls.Add(this.txt_customerName, 0, 3);
            this.tlpMain.Controls.Add(this.lblAddress, 1, 4);
            this.tlpMain.Controls.Add(this.txt_addresse, 0, 4);
            this.tlpMain.Controls.Add(this.lblCity, 1, 5);
            this.tlpMain.Controls.Add(this.txt_city, 0, 5);
            this.tlpMain.Controls.Add(this.lblPhone, 1, 6);
            this.tlpMain.Controls.Add(this.txt_phone, 0, 6);
            this.tlpMain.Controls.Add(this.lblFax, 1, 7);
            this.tlpMain.Controls.Add(this.txt_fax, 0, 7);
            this.tlpMain.Controls.Add(this.lblEmail, 1, 8);
            this.tlpMain.Controls.Add(this.txt_email, 0, 8);
            this.tlpMain.Controls.Add(this.lblTariff, 1, 9);
            this.tlpMain.Controls.Add(this.pnlTariff, 0, 9);
            this.tlpMain.Controls.Add(this.tlpBottom, 0, 10);

            // 
            // Labels
            // 
            this.lblCode.Text = "الكود";
            this.lblArea.Text = "المنطقة";
            this.lblSalesperson.Text = "البائع";
            this.lblCustomerName.Text = "إسم الزبون";
            this.lblAddress.Text = "العنوان";
            this.lblCity.Text = "المدينة";
            this.lblPhone.Text = "الهاتف";
            this.lblFax.Text = "الفاكس";
            this.lblEmail.Text = "البريد الإلكتروني";
            this.lblTariff.Text = "التسعيرة";
            this.lblCreditAllowed.Text = "متاح للسلف";
            this.lblDebtCeiling.Text = "سقف الدين";
            this.lblCheckCeiling.Text = "سقف الشيكات";
            this.lblPaymentTerm.Text = "أجل الدفع (بالأيام)";
            this.lblIF.Text = "I.F";
            this.lblICE.Text = "I.C.E";
            this.lblPatente.Text = "Patente";
            this.lblCIN.Text = "C.I.N";

            foreach (System.Windows.Forms.Control ctrl in this.tlpMain.Controls)
            {
                if (ctrl is System.Windows.Forms.Label)
                {
                    ((System.Windows.Forms.Label)ctrl).Anchor = System.Windows.Forms.AnchorStyles.Right;
                    ((System.Windows.Forms.Label)ctrl).AutoSize = true;
                    ((System.Windows.Forms.Label)ctrl).Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

            // 
            // pnlCode
            // 
            this.pnlCode.Controls.Add(this.txt_idcustomer);
            this.pnlCode.Controls.Add(this.btn_AddCode);
            this.pnlCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AddCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_AddCode.Size = new System.Drawing.Size(35, 29);
            this.btn_AddCode.Text = "+";
            this.txt_idcustomer.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // pnlTariff
            // 
            this.pnlTariff.Controls.Add(this.dropdown_Tarifs);
            this.pnlTariff.Controls.Add(this.btn_TariffDetail);
            this.pnlTariff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_TariffDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_TariffDetail.Size = new System.Drawing.Size(75, 29);
            this.btn_TariffDetail.Text = "Détail";
            this.dropdown_Tarifs.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // tlpBottom
            // 
            this.tlpMain.SetColumnSpan(this.tlpBottom, 2);
            this.tlpBottom.ColumnCount = 4;
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBottom.RowCount = 5;
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottom.Controls.Add(this.lblCreditAllowed, 3, 0);
            this.tlpBottom.Controls.Add(this.chk_CreditAllowed, 2, 0);
            this.tlpBottom.Controls.Add(this.lblDebtCeiling, 1, 0);
            this.tlpBottom.Controls.Add(this.txt_DebtCeiling, 0, 0);
            this.tlpBottom.Controls.Add(this.lblCheckCeiling, 3, 1);
            this.tlpBottom.Controls.Add(this.txt_CheckCeiling, 2, 1);
            this.tlpBottom.Controls.Add(this.lblIF, 1, 1);
            this.tlpBottom.Controls.Add(this.txt_IF, 0, 1);
            this.tlpBottom.Controls.Add(this.lblPaymentTerm, 3, 2);
            this.tlpBottom.Controls.Add(this.txt_PaymentTerm, 2, 2);
            this.tlpBottom.Controls.Add(this.lblCIN, 1, 2);
            this.tlpBottom.Controls.Add(this.txt_CIN, 0, 2);
            this.tlpBottom.Controls.Add(this.lblPatente, 3, 3);
            this.tlpBottom.Controls.Add(this.txt_patente, 2, 3);
            this.tlpBottom.Controls.Add(this.lblICE, 1, 3);
            this.tlpBottom.Controls.Add(this.txt_ICE, 0, 3);
            this.tlpBottom.Controls.Add(this.pnlButtons, 0, 4);

            foreach (System.Windows.Forms.Control ctrl in this.tlpBottom.Controls)
            {
                if (ctrl is System.Windows.Forms.Label)
                {
                    ((System.Windows.Forms.Label)ctrl).Anchor = System.Windows.Forms.AnchorStyles.Right;
                    ((System.Windows.Forms.Label)ctrl).AutoSize = true;
                    ((System.Windows.Forms.Label)ctrl).Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

            // 
            // pnlButtons
            // 
            this.tlpBottom.SetColumnSpan(this.pnlButtons, 4);
            this.pnlButtons.Controls.Add(this.Btn_Save);
            this.pnlButtons.Controls.Add(this.Btn_Cancel);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.Size = new System.Drawing.Size(120, 40);
            this.Btn_Save.Location = new System.Drawing.Point(360, 5);
            this.Btn_Save.Text = "تأكيد";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Cancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Cancel.Size = new System.Drawing.Size(120, 40);
            this.Btn_Cancel.Location = new System.Drawing.Point(490, 5);
            this.Btn_Cancel.Text = "إلغاء";

            //
            // Input Controls Docking
            //
            foreach (System.Windows.Forms.Control ctrl in this.tlpMain.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox || ctrl is System.Windows.Forms.ComboBox || ctrl is System.Windows.Forms.Panel)
                {
                    ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
                }
            }
            foreach (System.Windows.Forms.Control ctrl in this.tlpBottom.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox || ctrl is System.Windows.Forms.ComboBox || ctrl is System.Windows.Forms.CheckBox)
                {
                    ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
                }
            }

            // 
            // Fiche_Client
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(700, 580);
            this.Controls.Add(this.tlpMain);
            this.Name = "Fiche_Client";
            this.Text = "Fiche Client";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.pnlCode.ResumeLayout(false);
            this.pnlTariff.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpBottom.ResumeLayout(false);
            this.tlpBottom.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Declare controls as private fields to match your existing code
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpBottom;
        private System.Windows.Forms.Panel pnlCode;
        private System.Windows.Forms.Panel pnlTariff;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblSalesperson;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTariff;
        private System.Windows.Forms.Label lblCreditAllowed;
        private System.Windows.Forms.Label lblDebtCeiling;
        private System.Windows.Forms.Label lblCheckCeiling;
        private System.Windows.Forms.Label lblPaymentTerm;
        private System.Windows.Forms.Label lblIF;
        private System.Windows.Forms.Label lblICE;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblCIN;
        private System.Windows.Forms.TextBox txt_idcustomer;
        private System.Windows.Forms.ComboBox dropdown_Area;
        private System.Windows.Forms.ComboBox dropdown_Salesperson;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.TextBox txt_addresse;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_fax;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ComboBox dropdown_Tarifs;
        private System.Windows.Forms.CheckBox chk_CreditAllowed;
        private System.Windows.Forms.TextBox txt_DebtCeiling;
        private System.Windows.Forms.TextBox txt_CheckCeiling;
        private System.Windows.Forms.TextBox txt_PaymentTerm;
        private System.Windows.Forms.TextBox txt_IF;
        private System.Windows.Forms.TextBox txt_ICE;
        private System.Windows.Forms.TextBox txt_patente;
        private System.Windows.Forms.TextBox txt_CIN;
        private System.Windows.Forms.Button btn_AddCode;
        private System.Windows.Forms.Button btn_TariffDetail;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}