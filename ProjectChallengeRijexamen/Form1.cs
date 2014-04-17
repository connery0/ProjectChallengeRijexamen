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

        public Form1()
        {
            InitializeComponent();
            StartMC = new MC_Start();
            setScherm("Menu");
        }

        private void button1_Click(object sender, EventArgs e)
        {


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

            StartMC.ParentForm = this;
            StartMC.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
