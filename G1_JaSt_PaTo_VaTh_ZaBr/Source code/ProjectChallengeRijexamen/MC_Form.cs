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
    // Het formulier waar je theorie kunt oefenen met multiple choice vragen
    // aangemaakt op: 18/04/2014
    // gemaakt door: Tom Partoens

    public partial class MC_Form : Form
    {
        private Form1 parentForm;
        private String naam;
        private MultipleChoice vragen;
        private int antwoord;
        private Boolean tijdPerVraag;
        private int maxTijd = 0;
        private int vraagNummer = 0;
        private Boolean closing = false;

        //constructor voor oefen vragen
        public MC_Form(Form1 parentForm, String naam, int tijdslimiet)
        {
            InitializeComponent();
            vragen = new MultipleChoice(this, naam);
            this.parentForm = parentForm;
            this.naam = naam;
            MC_picture.SizeMode = PictureBoxSizeMode.CenterImage;
            if (tijdslimiet > 0)
            {
                MC_Progres.Visible = true;
                ProgresLabel.Visible = true;
                SetTijdsLimiet(tijdslimiet);
            }
            TelVraag();
        }

        //constructor voor het examen
        public MC_Form(Form1 parentForm)
        {
            InitializeComponent();
            vragen = new MultipleChoice(this);
            this.parentForm = parentForm;
            MC_picture.SizeMode = PictureBoxSizeMode.CenterImage;
            MC_Progres.Visible = true;
            ProgresLabel.Visible = true;
            SetTijdsLimiet(3);
            TelVraag();
        }

        //Deze functie wordt aangeroepen door de klok en past de progresbar en het label met de tijd aan
        private void ProgresTijd()
        {
            double tijdOver = Math.Ceiling((MC_Progres.Maximum - MC_Progres.Value) / (double)10);// het wordt gedeeld door 10 omdat de klok een interval van 100 heeft
            if (tijdOver == 0 && (MC_Progres.Maximum - MC_Progres.Value) > 1)
            {
                tijdOver = 1;
            }
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

        //indien er een tijdslimiet werd gekozen in mc_start stelt deze functie de limiet in en maakt de progresbar en tijdslabel zichtbaar
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
                case 3:
                    tijdPerVraag = true;
                    maxTijd = 15;
                    break;
            }

            MC_Progres.Value = 0;
            MC_Progres.Maximum = maxTijd * 10;
            ProgresTijd();
            timer1.Start();
        }

        // sluit de vragen af als het formulier sluit
        private void MC_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closing)
            {
                closing = true;
                vragen.EindeVraag();
            }
            parentForm.Location = this.Location;
            parentForm.Show();
        }

        // Vraagt de gebruiker of deze wel zeker is dat het programma gesloten moet worden.
        private void MC_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closing)
            {
                DialogResult test = MessageBox.Show("Weet u zeker dat u wilt afsluiten?", "OPPASSEN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (test == DialogResult.Yes)
                {
                    String formtext = "U behaalde een score van ";
                    int teller = 0;
                    for (int i = 0; i < vragen.getAantalVragen; i++)
                    {
                        if (!vragen.vraag(i).Overgeslagen && vragen.vraag(i).VraagJuist)
                        {
                            teller++;
                        }
                    }
                    formtext = formtext + teller + "/" + vragen.getAantalVragen + ".";
                    MessageBox.Show(formtext);
                    parentForm.Location = this.Location;
                    parentForm.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                parentForm.Location = this.Location;
                parentForm.Show();
            }
        }

        public void setVraag(String Vraag)
        {
            MC_Label.Text = Vraag;
        }

        public void setAntwoord(String antwoord, int Nr)
        {
            switch (Nr)
            {
                case 1:
                    MC_Radio1.Text = antwoord;
                    break;

                case 2:
                    MC_Radio2.Text = antwoord;
                    break;

                case 3:
                    MC_Radio3.Text = antwoord;
                    break;
            }
        }

        public void setUitleg(String uitleg)
        {
            MC_Label.Text = MC_Label.Text + Environment.NewLine + Environment.NewLine + uitleg;
        }
        public void setImage(String Doel)
        {
            MC_picture.Image = Image.FromFile(Doel);
        }

        public void VraagJuist()
        {
            MC_Label.BackColor = Color.LightGreen;
            MC_Label.ForeColor = Color.Black;
        }
        public void VraagFout(String Uitleg)
        {
            MC_Label.BackColor = Color.IndianRed;
            MC_Label.ForeColor = Color.Black;
            setUitleg(Uitleg);
        }

        // Een functie zodat andere klassen zoals memory een mesagebox kunnen oproepen
        public void ShowMessage(string tekst)
        {
            MessageBox.Show(tekst);
        }

        // de ShowMessage functie als memory een fout heeft bij het lezen van een bestand
        public void ShowMessage()
        {
            MessageBox.Show("Het bestand is niet gevonden." + Environment.NewLine + "Gelieve te herinstalleren", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    
        }
        
        //De eerste keer dat men op de knop klikt word de vraag gecontroleerd en de tijd gepauzeerd.
        //De tweede keer dat men op de knop klikt word de volgende vraag getoond en de tijd gereset of gewoon opnieuw gestart.
        private void button1_Click(object sender, EventArgs e)
        {
            switch (button1.Text)
            {
                case "Antwoord":
                    if (antwoord > 0)
                    {
                        timer1.Stop();
                        button1.Text = "Volgende";
                        vragen.ControleerVraag(antwoord);
                    }
                    else
                    {
                        MessageBox.Show("Gelieve eerst een antwoord te kiezen!");
                    }
                    break;
                case "Volgende":

                    if (maxTijd != 0) { timer1.Start(); }
                    button1.Text = "Antwoord";
                    MC_Label.BackColor = Color.Transparent;
                    MC_Label.ForeColor = Color.White;

                    vragen.VolgendeVraag();
                    TelVraag();
                    MC_Radio1.Checked = false;
                    MC_Radio2.Checked = false;
                    MC_Radio3.Checked = false;
                    antwoord = 0;
                    if (tijdPerVraag)
                    {
                        MC_Progres.Value = 0;
                        ProgresTijd();
                    }
                    break;
            }
        }

        //Word gebruikt om het label met de vraag nummers bij te werken.
        private void TelVraag()
        {
            vraagNummer++;
            VraagTeller.Text = vraagNummer + "/" + vragen.getAantalVragen;
        }

        private void MC_Radio1_CheckedChanged(object sender, EventArgs e)
        {
            if (MC_Radio1.Checked)
            {
                antwoord = 1;
            }
        }

        private void MC_Radio2_CheckedChanged(object sender, EventArgs e)
        {
            if (MC_Radio2.Checked)
            {
                antwoord = 2;
            }
        }

        private void MC_Radio3_CheckedChanged(object sender, EventArgs e)
        {
            if (MC_Radio3.Checked)
            {
                antwoord = 3;
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
                VraagFout("De tijd is op.");

                if (!tijdPerVraag)
                {
                    vragen.EindeVraag();
                }
                else
                {
                    button1.Text = "Volgende";
                }
            }
        }
    }
}
