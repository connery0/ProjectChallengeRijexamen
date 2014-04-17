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
        public MC_Start()
        {
            InitializeComponent();

        }

        private void MC_Start_Load(object sender, EventArgs e)
        {

        }

        private void MC_Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm.StartMC= new MC_Start();

        }
    }
}
