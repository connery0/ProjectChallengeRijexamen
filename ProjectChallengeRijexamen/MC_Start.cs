using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ProjectChallengeRijexamen
{
    public partial class MC_Start : Form
    {
        private Form1 parentForm;
        private Boolean openMainMenu = true;
        private String naam;
        private int tijdsLimiet = 0;
        public MC_Start(Form1 parentForm, string naam)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.naam = naam;
            button1.Text = "Volgende";
        }

        private void MC_Start_Load(object sender, EventArgs e)
        {

        }

        private void MC_Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (openMainMenu)
            {
                ParentForm.Location = this.Location;
                ParentForm.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Volgende")
            {
                String fileName = "..\\..\\Vragen\\Persoon\\" + naam + ".txt";
                if (File.Exists(fileName) == false)
                {
                    
                    File.Copy("..\\..\\Vragen\\Vragen.txt", ("..\\..\\Vragen\\Persoon\\" + naam + ".txt"));
                    VolgendScherm();
                }
                else
                {
                    Text_Label.Text = "U hebt deze test al eerder gemaakt, wilt U de vragen die U fout had opnieuw proberen of wilt U opnieuw beginnen?";
                    button1.Text = "Opnieuw beginen";
                    button2.Visible = true;
                }


            }
            else
            {

                try
                {
                    File.Delete("..\\..\\Vragen\\Persoon\\" + naam + ".txt");
                }
                catch (IOException f)
                {
                    Console.WriteLine(f.Message);
                    return;
                }



                File.Copy("..\\..\\Vragen\\Vragen.txt", ("..\\..\\Vragen\\Persoon\\" + naam + ".txt"));
                VolgendScherm();
            }
        }

        private void VolgendScherm()
        {
            openMainMenu = false;
            parentForm.multipleChoice = new MC_Form(parentForm, naam, tijdsLimiet);
            parentForm.multipleChoice.Show();
            parentForm.multipleChoice.Location = this.Location;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VolgendScherm();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                tijdsLimiet = 0;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                tijdsLimiet = 1;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                tijdsLimiet = 2;
            }
        }
    }
}
