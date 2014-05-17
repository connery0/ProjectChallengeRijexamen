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
    // het formulier waar je een tijdslimiet kiest en je kan kiezen om opnieuw te beginnen of je foute vragen te oefenen
    // aangemaakt op: 18/04/2014
    // gemaakt door: Tom Partoens
    public partial class MC_Start : Form
    {
        private Form1 parentForm;
        private Boolean openMainMenu = true;
        private String naam;
        private int tijdsLimiet = 3;

        public MC_Start(Form1 parentForm, string naam)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.naam = naam;
            button1.Text = "Volgende";
        }

        // Als op volgende word geklikt word gecontroleerd of de gebruiker een bestand heeft met foute vragen.
        //      Als er geen bestand gevonden word begint de vraag.
        //      Als er wel een bestand gevonden word kan de gebruiker kiezen om opnieuw te beginnen of de fouten in te oefenen.
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

        // Met de radio buttons kiest de gebruiker de tijdslimiet
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                tijdsLimiet = 3;
            }
        }

        // Gaat terug naar het hoofmenu als het formulier niet sluit om mc_form te openen.
        private void MC_Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (openMainMenu)
            {
                parentForm.Location = this.Location;
                parentForm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
