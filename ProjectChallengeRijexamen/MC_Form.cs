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
        private Boolean tijdPerVraag;
        private int maxTijd = 0;
        private int VraagNummer = 0;


        public MC_Form(Form1 ParentForm, String Naam, int tijdslimiet)
        {
            InitializeComponent();
            Vragen = new MultipleChoice(this, Naam);
            this.ParentForm = ParentForm;
            this.Naam = Naam;
            MC_picture.SizeMode = PictureBoxSizeMode.CenterImage;
            if (tijdslimiet > 0)
            {
                MC_Progres.Visible = true;
                ProgresLabel.Visible = true;
                SetTijdsLimiet(tijdslimiet);
            }
            TelVraag();
        }

        private void ProgresTijd()
        {
            double tijdOver = MC_Progres.Maximum - MC_Progres.Value;
            int tijdMin;
            ProgresLabel.Text = "";
            if (tijdOver > 60)
            {
                tijdMin = Convert.ToInt32(Math.Floor(tijdOver / 60));
                tijdOver = tijdOver - tijdMin * 60;
                ProgresLabel.Text = tijdMin + "M ";
            }
            ProgresLabel.Text = ProgresLabel.Text + tijdOver + "S";

        }
        private void SetTijdsLimiet(int tijdsL)
        {
            switch (tijdsL)
            {
                case 1:
                    tijdPerVraag = true;
                    maxTijd = 60;
                    break;
                case 2:
                    tijdPerVraag = false;
                    maxTijd = 3600;
                    break;
            }

            MC_Progres.Value = 0;
            MC_Progres.Maximum = maxTijd;
            ProgresTijd();
            timer1.Start();
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
            MC_tekst.Text = MC_tekst.Text + Environment.NewLine + uitleg;
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
                        timer1.Stop();
                        button1.Text = "Volgende";
                        Vragen.ControleerVraag(Antwoord);

                    }
                    else
                    {
                        MessageBox.Show("gelieve eerst een antwoord te kiezen");
                    }
                    break;
                case "Volgende":

                    if (maxTijd != 0) { timer1.Start(); }
                    button1.Text = "Antwoord";
                    MC_tekst.BackColor = Color.Empty;
                    MC_tekst.ScrollBars = ScrollBars.None;
                    Vragen.VolgendeVraag();
                    TelVraag();
                    MC_Radio1.Checked = false;
                    MC_Radio2.Checked = false;
                    MC_Radio3.Checked = false;
                    Antwoord = 0;
                    if (tijdPerVraag)
                    {
                        MC_Progres.Value = 0;
                        ProgresTijd();
                    }
                    break;
            }
        }
        private void TelVraag()
        {
            VraagNummer++;
            VraagTeller.Text = VraagNummer + "/" + Vragen.getAantalVragen();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            MC_Progres.Value += 1;
            ProgresTijd();
            if (MC_Progres.Value >= MC_Progres.Maximum)
            {
                timer1.Stop();
                ProgresTijd();
                VraagFout("De tijd is om");

                if (!tijdPerVraag)
                {
                    Vragen.EindeVraag();
                }
                else
                {
                    button1.Text = "Volgende";
                }
            }
        }
    }
}
