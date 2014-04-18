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
    public partial class MC_Form : Form
    {
        private Form1 ParentForm;
        private String Naam;
        private MultipleChoice Vragen;

        public MC_Form(Form1 ParentForm,String Naam,Boolean NieuwBestand)
        {
            Vragen = new MultipleChoice(this ,Naam, NieuwBestand);
            this.ParentForm = ParentForm;
            this.Naam = Naam;
            InitializeComponent();
            
        }

        private void MC_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            
                ParentForm.Location = this.Location;
                ParentForm.Show();
            

        }


        public void ShowMessage(string a)
        {
            MessageBox.Show(a);

        }


        private void MC_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
