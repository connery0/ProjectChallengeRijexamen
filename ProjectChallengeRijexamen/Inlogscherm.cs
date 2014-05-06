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
<<<<<<< HEAD
<<<<<<< HEAD
        public Inlogscherm()
        {
            InitializeComponent();
        }

       
=======
=======
>>>>>>> eed6130300deb272cd2d6ab3c13007ae3a27e81e
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
<<<<<<< HEAD
>>>>>>> eed6130300deb272cd2d6ab3c13007ae3a27e81e
=======
>>>>>>> eed6130300deb272cd2d6ab3c13007ae3a27e81e
    }
}
