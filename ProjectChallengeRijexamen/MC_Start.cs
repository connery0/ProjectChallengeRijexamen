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
                Naam = Naam1.Text +"_"+ Naam2.Text;
                String FileName = "..\\..\\Vragen\\" + Naam + ".txt";
                if (System.IO.File.Exists(FileName) == false)
                {
                    MessageBox.Show("file not found");
                    System.IO.File.Copy("..\\..\\Vragen\\Vragen.txt", ("..\\..\\Vragen\\" + Naam + ".txt"));
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
                // Use a try block to catch IOExceptions, to 
                // handle the case of the file already being 
                // opened by another process. 
               // try
                //{
                    System.IO.File.Delete("..\\..\\Vragen\\" + Naam + ".txt");
                //}
                //catch (System.IO.IOException e)
                //{
                //    Console.WriteLine(e.Message);
                //    return;
                //}



                System.IO.File.Copy("..\\..\\Vragen\\Vragen.txt", ("..\\..\\Vragen\\" + Naam + ".txt"));
                VolgendScherm();
            }
        }

        private void VolgendScherm()
        {
            OpenMainMenu = false;
            ParentForm.MultipleChoice = new MC_Form(ParentForm, Naam, true);
            ParentForm.MultipleChoice.Show();
            ParentForm.MultipleChoice.Location = this.Location;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VolgendScherm();
        }
    }
}
