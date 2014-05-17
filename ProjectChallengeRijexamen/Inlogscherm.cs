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
    public partial class Inlogscherm : Form
    {
        private Boolean sluiten = false;

        public Inlogscherm()
        {
            InitializeComponent();
        }


        Form1 parentForm;

        public Inlogscherm(Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;           
        }

        private void BtnAanmelden_Click(object sender, EventArgs e)
        {
            Aanmelden();   
        }

        private void BtnAnnuleren_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Inlogscherm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Update zodat men een waarschuwing krijgt, wanneer men wil sluiten.
            // Author Stef Jansens, Bram Zabot
            if (!sluiten) { 
            DialogResult test = MessageBox.Show("Weet u zeker dat u wilt afsluiten?", "OPPASSEN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (test == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;               
                }
            }
        }


        private void TextboxNaam_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Update zodat men alleen karakters kan ingeven in de tekstboxen.
            //Author: Bram Zabot
            if (e.KeyChar == (char)Keys.Enter)
            {
                Aanmelden();
            }
            else if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void Aanmelden()
        {
            string naam = TextboxNaam.Text.Trim();
            string achternaam = TextboxAchternaam.Text.Trim();

            if (naam != "" && achternaam != "")
            {
                parentForm.Tag = naam + " " + achternaam;
                sluiten = true;
                parentForm.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Gelieve uw voor- en achternaam in te geven.", "ERROR");
            } 
        }
    }
}
