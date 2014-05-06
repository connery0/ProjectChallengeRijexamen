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
            string naam = TextboxNaam.Text;
            string achternaam = TextboxAchternaam.Text;
            
            if (naam != "" && achternaam != "")
            {
                parentForm.Tag =  naam + " " + achternaam;
                parentForm.Show();
                this.Close();
            }
           
        }

    }
}
