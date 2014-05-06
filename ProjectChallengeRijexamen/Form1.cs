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
    public partial class Form1 : Form
    {
       // private String Scherm;
        public MC_Form MultipleChoice;
        public MC_Start StartMC;
        public DnD_Form DragnDrop;
        public DnD_Start StartDnD;

        public Form1()
        {
            InitializeComponent();
            setScherm("Menu");
        }

        private void setScherm(String Scherm)
        {
            switch (Scherm)
            {
                case "Menu":
                    break;

                case "MultipleChoice":
                    break;

                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void M_knop1_Click(object sender, EventArgs e)
        {
            StartMC = new MC_Start(this);
            StartMC.Show();
            StartMC.Location = this.Location;
            this.Hide();           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StartMC = new MC_Start(this);
            StartMC.Show();
            StartMC.Location = this.Location;
            this.Hide();
        }

        private void M_knop2_Click(object sender, EventArgs e)
        {
            StartDnD = new DnD_Start(this);
            StartDnD.Show();
            StartDnD.Location = this.Location;
            this.Hide(); 
        }
    }
}
