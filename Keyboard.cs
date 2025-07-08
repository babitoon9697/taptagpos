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
    public partial class Keyboard : Form
    {
        string langue = "fr";
        public Keyboard()
        {
            InitializeComponent();
        }
        public string EnteredText
        {
            get { return textBoxKeyboard.Text; }  // Assuming textBoxKeyboard is the TextBox where input is stored
            set { textBoxKeyboard.Text = value; }  // Optional, if you want to set the value from outside
        }
        private void MoveCursor(int offset)
        {
            int currentPos = textBoxKeyboard.SelectionStart + offset;
            if (currentPos >= 0 && currentPos <= textBoxKeyboard.Text.Length)
            {
                textBoxKeyboard.SelectionStart = currentPos;
                textBoxKeyboard.Focus();
            }
        }
        private void LetterButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Text.Length > 0)
            {
                InsertCharacter(btn.Text);
            }
        }
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if(langue=="fr")
            InsertCharacter("A");
            else
            InsertCharacter("ض");
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            if (langue == "fr")

            InsertCharacter("Z");


            else
            InsertCharacter("ص");

        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("E");
            else
                InsertCharacter("ث");
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("R");
            else
                InsertCharacter("ق");
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("T");
            else
                InsertCharacter("ف");
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("Y");
            else
                InsertCharacter("غ");
        }

        private void bunifuButton27_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("U");
            else
                InsertCharacter("ع");
        }

        private void bunifuButton28_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("I");
            else
                InsertCharacter("ه");
        }

        private void bunifuButton29_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("O");
            else
                InsertCharacter("خ");
        }

        private void bunifuButton210_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("P");
            else
                InsertCharacter("ح");
        }

        private void bunifuButton213_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("Q");
            else
                InsertCharacter("ش");
        }

        private void bunifuButton214_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("S");
            else
                InsertCharacter("س");
        }

        private void bunifuButton215_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("D");
            else
                InsertCharacter("ي");
        }

        private void bunifuButton216_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("F");
            else
                InsertCharacter("ب");
        }


        private void bunifuButton217_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("G");
            else
                InsertCharacter("ل");
        }

        private void bunifuButton218_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("H");
            else
                InsertCharacter("ا");
        }

        private void bunifuButton219_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("J");
            else
                InsertCharacter("ت");
        }

        private void bunifuButton220_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("K");
            else
                InsertCharacter("ن");
        }

        private void bunifuButton221_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("L");
            else
                InsertCharacter("م");
        }

        private void bunifuButton222_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("M");
            else
                InsertCharacter("ك");
        }

        private void bunifuButton225_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("W");
            else
                InsertCharacter("ئ");
        }

        private void bunifuButton226_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("X");
            else
                InsertCharacter("ء");
        }

        private void bunifuButton227_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("C");
            else
                InsertCharacter("ؤ");
        }

        private void bunifuButton228_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("V");
            else
                InsertCharacter("ر");
        }

        private void bunifuButton229_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("B");
            else
                InsertCharacter("لا");
        }

        private void bunifuButton230_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("N");
            else
                InsertCharacter("ى");
        }

        private void bunifuButton211_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("'");
            else
                InsertCharacter("ج");
        }

        private void bunifuButton212_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("£");
            else
                InsertCharacter("د");
        }


        private void bunifuButton223_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("%");
            else
                InsertCharacter("ط");
        }

        private void bunifuButton224_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("/");
            else
                InsertCharacter("ذ");
        }

        private void bunifuButton231_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("?");
            else
                InsertCharacter("ة");
        }

        private void bunifuButton232_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter(".");
            else
                InsertCharacter("و");
        }

        private void bunifuButton233_Click(object sender, EventArgs e)
        {
            InsertCharacter("0"); // Always insert "0"
        }


        private void bunifuButton237_Click(object sender, EventArgs e)
        {
            InsertCharacter("1");
        }
        private void InsertCharacter(string character)
        {
            int currentPos = textBoxKeyboard.SelectionStart;

            // Insert the character at the current position
            textBoxKeyboard.Text = textBoxKeyboard.Text.Insert(currentPos, character);

            // Move the cursor to the position after the inserted character
            textBoxKeyboard.SelectionStart = currentPos + character.Length;

            // Refocus the TextBox without selecting text
            textBoxKeyboard.Focus();
            textBoxKeyboard.Select(textBoxKeyboard.SelectionStart, 0);
        }

        private void bunifuButton238_Click(object sender, EventArgs e)
        {
            InsertCharacter("2");
        }

        private void bunifuButton239_Click(object sender, EventArgs e)
        {
            InsertCharacter("3");
        }

        private void bunifuButton240_Click(object sender, EventArgs e)
        {
            InsertCharacter("4");
        }

        private void bunifuButton245_Click(object sender, EventArgs e)
        {
            InsertCharacter("5");
        }

        private void bunifuButton246_Click(object sender, EventArgs e)
        {
            InsertCharacter("6");
        }

        private void bunifuButton247_Click(object sender, EventArgs e)
        {
             InsertCharacter("7");
        }

        private void bunifuButton248_Click(object sender, EventArgs e)
        {
            InsertCharacter("8");
        }

        private void bunifuButton234_Click(object sender, EventArgs e)
        {
            InsertCharacter("9");
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
           
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void bunifuButton243_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("!");
            else
                InsertCharacter("ظ");
        }

        private void bunifuButton249_Click(object sender, EventArgs e)
        {
            if (langue == "fr")
                InsertCharacter("µ");
            else
                InsertCharacter("ز");
        }


        private void bunifuButton212_Click_1(object sender, EventArgs e)
        {
            if (langue == "fr")
            {
                langue = "ar";
                btn_langue.Text = "FR";
                btn_A.Text = "ض";
                btn_Z.Text = "ص";
                btn_E.Text = "ث";
                btn_R.Text = "ق";
                btn_T.Text = "ف";
                btn_Y.Text = "غ";
                btn_U.Text = "ع";
                btn_i.Text = "ه";
                btn_O.Text = "خ";
                btn_P.Text = "ح";
                btn_Q.Text = "ش";
                btn_S.Text = "س";
                btn_D.Text = "ي";
                btn_F.Text = "ب";
                btn_G.Text = "ل";
                btn_H.Text = "ا";
                btn_J.Text = "ت";
                btn_K.Text = "ن";
                btn_L.Text = "م";
                btn_M.Text = "ك";
                btn_W.Text = "ئ";
                btn_X.Text = "ء";
                btn_C.Text = "ؤ";
                btn_V.Text = "ر";
                btn_b.Text = "لا";
                btn_N.Text = "ى";
                btn_apostro.Text = "ج";
                btn_pourcentage.Text = "ط";
                Btn_µ.Text = "ز";
                btn_Quest.Text = "ة";
                btn_point.Text = "و";
                btn_Slash.Text = "ذ";
                btn_exclam.Text = "ظ";
                btn_clear.Text = "د";
            }
            else if(langue == "ar")
            {
                langue = "fr";
                btn_langue.Text = "AR";
                btn_A.Text = "A";
                btn_Z.Text = "Z";
                btn_E.Text = "E";
                btn_R.Text = "R";
                btn_T.Text = "T";
                btn_Y.Text = "Y";
                btn_U.Text = "U";
                btn_i.Text = "I";
                btn_O.Text = "O";
                btn_P.Text = "P";
                btn_Q.Text = "Q";
                btn_S.Text = "S";
                btn_D.Text = "D";
                btn_F.Text = "F";
                btn_G.Text = "G";
                btn_H.Text = "H";
                btn_J.Text = "J";
                btn_K.Text = "K";
                btn_L.Text = "L";
                btn_M.Text = "M";
                btn_W.Text = "W";
                btn_X.Text = "X";
                btn_C.Text = "C";
                btn_V.Text = "V";
                btn_b.Text = "B";
                btn_N.Text = "N";
                btn_apostro.Text = "'";
                btn_pourcentage.Text = "%";
                Btn_µ.Text = "ذ";
                btn_Quest.Text = "?";
                btn_point.Text = ".";
                btn_Slash.Text = "/";
                btn_exclam.Text = "!";
                btn_clear.Text = "CL";
            }
        }

        private void Btn_left_Click(object sender, EventArgs e)
        {
           MoveCursor(-1);
        }

        private void Keyboard_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxKeyboard;
            textBoxKeyboard.Focus();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            // Get the current position of the cursor in the TextBox
            int currentPos = textBoxKeyboard.SelectionStart;

            // Check if the cursor is at the beginning, do nothing if there's nothing to delete
            if (currentPos > 0)
            {
                // Delete the character before the cursor position
                textBoxKeyboard.Text = textBoxKeyboard.Text.Remove(currentPos - 1, 1);

                // Move the cursor one position to the left
                textBoxKeyboard.SelectionStart = currentPos - 1;

                // Keep the focus on the TextBox
                textBoxKeyboard.Focus();
            }
        }

        private void Btn_Right_Click(object sender, EventArgs e)
        {
            MoveCursor(+1);
        }
        private readonly Dictionary<string, string[]> layouts = new Dictionary<string, string[]>
{
    {
        "fr", new[]
        {
            "A", "Z", "E", "R", "T", "Y", "U", "I", "O", "P",
            "Q", "S", "D", "F", "G", "H", "J", "K", "L", "M",
            "W", "X", "C", "V", "B", "N"
        }
    },
    {
        "ar", new[]
        {
            "ض", "ص", "ث", "ق", "ف", "غ", "ع", "ه", "خ", "ح",
            "ش", "س", "ي", "ب", "ل", "ا", "ت", "ن", "م", "ك",
            "ئ", "ء", "ؤ", "ر", "لا", "ى"
        }
    }
};
        private void Btn_Space_Click(object sender, EventArgs e)
        {
            InsertCharacter(" ");
        }
    }
}
