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
    public partial class Memory : Form
    {
        private PictureBox[] Box;
        private PictureBox laatsteKeuze=null;



        public Memory()
        {
            InitializeComponent();
            PictureBox[] Box = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18 };
            this.Box = Box;

            for (int i = 0; i < this.Box.Length; i++)
            {
                Box[i].Image = Image.FromFile("..\\..\\img\\Verkeersborden\\ico.png");
                Box[i].Tag = "..\\..\\img\\Verkeersborden\\a1b.png";

            }
            Box[0].Tag = "..\\..\\img\\Verkeersborden\\a1c.png"; // iedere picture box krijgt (random) in zijn tag welk bord het moet zijn
            Box[2].Tag = "..\\..\\img\\Verkeersborden\\a1c.png";
            Box[1].Tag = "..\\..\\img\\Verkeersborden\\a11.png";
            Box[5].Tag = "..\\..\\img\\Verkeersborden\\a11.png";
            
        }



        private void pictureBox_Click(object sender, EventArgs e)
        {

            PictureBox A = (PictureBox)sender;
            if (A.Tag != "Gevonden")
            {
                if (laatsteKeuze == null)
                {
                    A.Image = Image.FromFile((String)A.Tag);
                    laatsteKeuze = A;
                }
                    
                else{
                   A.Image = Image.FromFile((String)A.Tag);
                  
                  
                   if (laatsteKeuze.Tag != A.Tag)
                   {
                       MessageBox.Show("Fout"); // hier moet iets komen zodat de code effe wacht en ge ook ziet wat uw tweede keuze was
                       laatsteKeuze.Image = Image.FromFile("..\\..\\img\\Verkeersborden\\ico.png");
                       A.Image = Image.FromFile("..\\..\\img\\Verkeersborden\\ico.png");
                   }
                   else
                   {
                       laatsteKeuze.Tag = "Gevonden";
                       A.Tag = "Gevonden";
                   }
                   laatsteKeuze = null;


                }
            }
        }
    }
}
