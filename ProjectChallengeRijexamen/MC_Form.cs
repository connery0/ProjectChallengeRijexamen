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
    public partial class MC_Form : Form
    {
        private Form1 ParentForm;
        private String Naam;
        private MultipleChoice Vragen;
        private int Antwoord;


        public MC_Form(Form1 ParentForm, String Naam)
        {
            InitializeComponent();
            Vragen = new MultipleChoice(this, Naam) ;
            this.ParentForm = ParentForm;
            this.Naam = Naam;
            MC_picture.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void MC_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm.Location = this.Location;
            ParentForm.Show();
        }

        public void setVraag(String Vraag)
        {
            MC_tekst.Text = Vraag;
        }
        public void setAntwoord(String Antwoord, int Nr)
        {
            switch (Nr)
            {
                case 1:
                    MC_Radio1.Text = Antwoord;
                    break;

                case 2:
                    MC_Radio2.Text = Antwoord;
                    break;

                case 3:
                    MC_Radio3.Text = Antwoord;
                    break;
            }
        }
        public void setUitleg(String uitleg)
        {
            MC_tekst.Text = MC_tekst.Text + Environment.NewLine + "uitleg: " + uitleg;
            if (MC_tekst.Text.Split('\n').Length > 4)
            {
                MC_tekst.ScrollBars = ScrollBars.Vertical;
            }

        }
        public void setImage(String Doel)
        {
            MC_picture.Image = Image.FromFile(Doel);
        }

        public void VraagJuist()
        {
            MC_tekst.BackColor = Color.LightGreen;
        }
        public void VraagFout(String Uitleg)
        {
            MC_tekst.BackColor = Color.IndianRed;
            setUitleg(Uitleg);
        }




        public void ShowMessage(string a)
        {
            MessageBox.Show(a);
        }


        private void MC_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (button1.Text)
            {
                case "Antwoord":
                    if (Antwoord > 0)
                    {
                        button1.Text = "Volgende";
                        Vragen.ControleerVraag(Antwoord);
                    }
                    else
                    {
                        MessageBox.Show("gelieve eerst een antwoord te kiezen");
                    }
                    break;
                case "Volgende":
                    button1.Text = "Antwoord";
                    MC_tekst.BackColor = Color.Empty;
                    MC_tekst.ScrollBars = ScrollBars.None;
                    Vragen.VolgendeVraag();
                    MC_Radio1.Checked = false;
                    MC_Radio2.Checked = false;
                    MC_Radio3.Checked = false;
                    Antwoord = 0;
                    break;
            }
        }

        private void MC_Radio1_CheckedChanged(object sender, EventArgs e)
        {
            if (MC_Radio1.Checked)
            {
                Antwoord = 1;
            }
        }

        private void MC_Radio2_CheckedChanged(object sender, EventArgs e)
        {
            if (MC_Radio2.Checked)
            {
                Antwoord = 2;
            }
        }

        private void MC_Radio3_CheckedChanged(object sender, EventArgs e)
        {
            if (MC_Radio3.Checked)
            {
                Antwoord = 3;
            }
        }
    }
}
