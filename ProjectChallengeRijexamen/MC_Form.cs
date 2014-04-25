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


        public MC_Form(Form1 ParentForm, String Naam, Boolean NieuwBestand)
        {
            InitializeComponent();
            Vragen = new MultipleChoice(this, Naam, NieuwBestand);
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
            MC_tekst.Text = MC_tekst.Text + Environment.NewLine+"uitleg: " + uitleg;


        }
        public void setImage(String Doel)
        {
            MC_picture.Image = Image.FromFile(Doel);
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
       
        }
    }
}
