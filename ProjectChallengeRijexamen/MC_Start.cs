using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectChallengeRijexamen
{
    public partial class MC_Start : Form
    {
        public Form1 ParentForm;
        private Boolean OpenMainMenu = true;
        private String Naam;
        private int TijdsLimiet = 0;
        public MC_Start(Form1 ParentForm)
        {
            InitializeComponent();
            this.ParentForm = ParentForm;
            button1.Text = "Volgende";
        }

        private void MC_Start_Load(object sender, EventArgs e)
        {

        }

        private void MC_Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (OpenMainMenu)
            {
                ParentForm.Location = this.Location;
                ParentForm.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Volgende")
            {
                Naam = Naam1.Text + "_" + Naam2.Text;
                String FileName = "..\\..\\Vragen/" + Naam + ".txt";
                if (System.IO.File.Exists(FileName) == false)
                {
                    
                    System.IO.File.Copy("..\\..\\Vragen/Vragen.txt", ("..\\..\\Vragen/" + Naam + ".txt"));
                    VolgendScherm();
                }
                else
                {
                    Text_Label.Text = "U hebt deze test al eerder gemaakt, wilt U de vragen die U fout had opnieuw proberen. Of wilt U opnieuw beginnen?";
                    button1.Text = "Opnieuw beginen";
                    button2.Visible = true;
                }


            }
            else
            {

                try
                {
                    System.IO.File.Delete("Vragen\\" + Naam + ".txt");
                }
                catch (System.IO.IOException f)
                {
                    Console.WriteLine(f.Message);
                    return;
                }



                System.IO.File.Copy("..\\..\\Vragen\\Vragen.txt", ("Vragen\\" + Naam + ".txt"));
                VolgendScherm();
            }
        }

        private void VolgendScherm()
        {
            OpenMainMenu = false;
            ParentForm.MultipleChoice = new MC_Form(ParentForm, Naam,TijdsLimiet);
            ParentForm.MultipleChoice.Show();
            ParentForm.MultipleChoice.Location = this.Location;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VolgendScherm();
        }

        private void Box_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !IsValidCharacter(e.KeyChar);
        }

        private bool IsValidCharacter(char c)
        {
            bool isValid = false;

            // (char)8 = backspace
            if (c == (char)8 || c == 'a' || c == 'b' || c == 'c' || c == 'd' || c == 'e' || c == 'f' || c == 'g' || c == 'h' || c == 'i' || c == 'j' || c == 'k' || c == 'l' || c == 'm' || c == 'n' || c == 'o' || c == 'p' || c == 'q' || c == 'r' || c == 's' || c == 't' || c == 'u' || c == 'v' || c == 'w' || c == 'x' || c == 'y' || c == 'z' || c == 'A' || c == 'B' || c == 'C' || c == 'D' || c == 'E' || c == 'F' || c == 'G' || c == 'H' || c == 'I' || c == 'J' || c == 'K' || c == 'L' || c == 'M' || c == 'N' || c == 'O' || c == 'P' || c == 'Q' || c == 'R' || c == 'S' || c == 'T' || c == 'U' || c == 'V' || c == 'W' || c == 'X' || c == 'Y' || c == 'Z')
            {
                isValid = true;
            }

            return isValid;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                TijdsLimiet = 0;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                TijdsLimiet = 1;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                TijdsLimiet = 2;
            }
        }
    }
}
