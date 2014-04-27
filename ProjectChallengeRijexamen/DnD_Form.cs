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
    public partial class DnD_Form : Form
    {
        private Form1 ParentForm;
        private String Naam;

        public DnD_Form(Form1 ParentForm, String Naam)
        {
            InitializeComponent();
            
            this.ParentForm = ParentForm;
            this.Naam = Naam;
        }

        private void DnD_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm.Location = this.Location;
            ParentForm.Show();
        }

    }
}
