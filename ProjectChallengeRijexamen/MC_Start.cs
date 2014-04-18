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
        }

        private void MC_Start_Load(object sender, EventArgs e)
        {

        }

        private void MC_Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (OpenMainMenu) { 
            ParentForm.Location = this.Location;
            ParentForm.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenMainMenu = false;
            Naam = Naam1.Text + Naam2.Text;
            ParentForm.MultipleChoice = new MC_Form(ParentForm, Naam,true);
            ParentForm.MultipleChoice.Show();
            this.Close();
        }
    }
}
