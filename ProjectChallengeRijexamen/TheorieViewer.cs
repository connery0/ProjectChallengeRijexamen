//Theorieviewer om theorie te kunnen lezen en in te leren.
//Author: Thibaut Vandeput
//Date : ma 5/5/2014
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
        private Form1 parentForm;

        public TheorieViewer(Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            
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
                    }
                    while (regel != "------"& regel != null);
                }
            }
            catch 
            {
                MessageBox.Show("fout");
            }
        }

        private void TheorieViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Location = this.Location;
            parentForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void theorie_MouseEnter(object sender, EventArgs e)
        {
            panel1.Focus();
        }
    }
}   