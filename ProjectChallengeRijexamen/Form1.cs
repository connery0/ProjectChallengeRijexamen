using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace ProjectChallengeRijexamen
{
    public partial class Form1 : Form
    {
        // private String Scherm;
        public MC_Form multipleChoice;
        public MC_Start startMC;
        public DnD dragAndDrop;
        public Memory memory;

        private string naam;

        public Form1()
        {
            InitializeComponent();
            OmAantemelden();

        }
        
      private void M_knop1_Click(object sender, EventArgs e)
        {

            startMC = new MC_Start(this, naam);
            startMC.Show();
            startMC.Location = this.Location;
            this.Hide();
        }

        private void M_knop2_Click(object sender, EventArgs e)
        {
            dragAndDrop = new DnD(this);
            dragAndDrop.Show();
            this.Hide();
        }

        private void M_knop3_Click(object sender, EventArgs e)
        {
            memory = new Memory(this);
            memory.Show();
            memory.Location = this.Location;
            this.Hide();
        }

        private void M_knop4_Click(object sender, EventArgs e)
        {
            TheorieViewer theorieviewer = new TheorieViewer(this);
            theorieviewer.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            OmAantemelden();
            e.Cancel = true;
        }

        private void OmAantemelden()
        {
            Inlogscherm inloggen = new Inlogscherm(this);

            DialogResult button = inloggen.ShowDialog();

            naam = this.Tag.ToString();

            this.Text = "Welkom, " + this.Tag;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            multipleChoice = new MC_Form(this);
            multipleChoice.Show();
            multipleChoice.Location = this.Location;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
