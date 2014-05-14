using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProjectChallengeRijexamen;

namespace WindowsFormsApplication1
{
    public partial class TheorieViewer : Form
    {
        public Form1 ParentForm;

        public TheorieViewer(Form1 ParentForm)
        {
            InitializeComponent();
            this.ParentForm = ParentForm;
            
        }         

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)     
        {
            
            String regel = "";
            String hfdstk = Convert.ToString(listBox1.SelectedIndex + 1);
            theorie.Text = "";

            try
            {
                using (StreamReader sr = new StreamReader("../../Theorie.txt"))
                {
                    do{
                        regel = sr.ReadLine();
                    }while (regel != ("--"+ hfdstk + "----") && regel != null);


                    do{
                        regel = sr.ReadLine();
                        if (regel != "------") { 
                            theorie.Text = theorie.Text + regel + Environment.NewLine;
                        }            
                    }while (regel != "------"& regel != null);
                }

            }
            catch 
            {
                MessageBox.Show("fout");
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void TheorieViewer_FormClosed(object sender, FormClosedEventArgs e)
        {

            ParentForm.Location = this.Location;
            ParentForm.Show();
        }

            
    }
}   