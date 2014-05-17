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
            String hfdstk = Convert.ToString(listBox1.SelectedIndex + 1);               //kijkt naar welk hoofdstuk geselecteerd is in de listbox
            theorie.Text = "";

            try
            {
                using (StreamReader sr = new StreamReader("../../Theorie.txt"))
                {
                    do{
                        regel = sr.ReadLine();                                          //streamreader zoekt in deze lus naar het juiste hoofdstuk
                    }while (regel != ("--"+ hfdstk + "----") && regel != null);         //en negeert de rest. eens hij het heeft gevonden,
                                                                                        //stopt de lus
                    do{
                        regel = sr.ReadLine();
                        if (regel != "------") {                                        //streamreader plaats regel per regel van de theorie
                            theorie.Text = theorie.Text + regel + Environment.NewLine;  //in de label, tot hij aan het einde van het hoofd-
                        }                                                               //stuk komt. het eidne is aangeduid met 6 liggende                
                    }                                                                   //streepjes en wordt niet meer afgedrukt("------")
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
            parentForm.Location = this.Location;                                         //bij het sluiten wordt het hoofdmenu terug getoond
            parentForm.Show();      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();                                                               //knop om te slutien en naar het hoofdmenu te gaan
        }

        private void theorie_MouseEnter(object sender, EventArgs e)
        {
            panel1.Focus();                         //door te focussen op de panel, kan de scrollbar bedient woden met het scroll-
        }                                          //wiel van de muis. anders moet de scrollbar gesleept worden.
    }                                          
}   