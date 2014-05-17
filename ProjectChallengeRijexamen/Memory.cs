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
using System.Diagnostics;
using System.Threading;

namespace ProjectChallengeRijexamen
{
    public partial class Memory : Form
    {
        private PictureBox[] Box;
        private PictureBox laatsteKeuze = null;
        private Verkeersbord[] alleVerkeersborden;
        private Random r = new Random();
        private Form1 parentform;
        private Boolean closing = false;


        public Memory(Form1 parentform)
        {
            InitializeComponent();
            this.parentform = parentform;
            PictureBox[] Box = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18 };
            this.Box = Box;
            setVerkeersborden();


            int[] Temp = new int[Box.Length];
            for (int i = 0; i < this.Box.Length; i++)
            {
                Temp[i] = -1;
                Box[i].Load("..\\..\\img\\Verkeersborden\\ico.png");
                Box[i].Tag = "";
            }
            for (int i = 0; i < Box.Length / 2; i++)
            {
                Boolean j = false;
                while (!j) { 
                int N = r.Next(0, Temp.Length);
                if (Array.IndexOf(Temp,N) == -1)
                {
                    Settag(alleVerkeersborden[N].getNaam);
                    Settag(alleVerkeersborden[N].getNaam);
                    Temp[i] = N;
                    j = true;
                }
            }

            }


        }
        private void Settag(String Naam)
        {
            Boolean geplaatst = false;
            int teller = 0;
            while (teller < 20 && !geplaatst)
            {
                int N = r.Next(0, Box.Length);
                if (Box[N].Tag == "")
                {
                    Box[N].Tag = "..\\..\\img\\Verkeersborden\\" + Naam;
                    geplaatst = true;
                }
                teller++;
            }
            if (!geplaatst)
            {
                for (int i = 0; i < Box.Length; i++)
                {
                    if (Box[i].Tag == "" && !geplaatst)
                    {
                        Box[i].Tag = "..\\..\\img\\Verkeersborden\\" + Naam;
                        geplaatst = true;
                    }
                }
            }


        }



        private void setVerkeersborden()
        {
            StreamReader myFile = new StreamReader("..\\..\\Vragen\\Borden.txt");
            string myString = myFile.ReadToEnd();

            myFile.Close();

            double l = myString.Split('\n').Length / 3;
            int lengte = Convert.ToInt32(l);
            alleVerkeersborden = new Verkeersbord[lengte];

            ///////////////////////////////////////////////////////////////////////////////////////

            string line;
            int teller = 0;
            StreamReader file = new StreamReader("..\\..\\Vragen\\Borden.txt");
            while ((line = file.ReadLine()) != null)
            {
                alleVerkeersborden[teller] = new Verkeersbord(file.ReadLine(), file.ReadLine());
                teller += 1;
            }
            file.Close();
        }







        private void pictureBox_Click(object sender, EventArgs e)
        {

            PictureBox picture = (PictureBox)sender;



            if (picture.Tag != "Gevonden")
            {
                picture.Load((String)picture.Tag);

                if (laatsteKeuze == null)
                {
                    laatsteKeuze = picture;
                }

                else
                {

                    if (!laatsteKeuze.Equals(picture) && !((String)laatsteKeuze.Tag).Equals(((String)(picture.Tag)), StringComparison.Ordinal))
                    {


                        picture.Refresh();
                        System.Threading.Thread.Sleep(500);

                        laatsteKeuze.Image = Image.FromFile("..\\..\\img\\Verkeersborden\\ico.png");

                        if (!((String)laatsteKeuze.Tag).Equals(((String)(picture.Tag)), StringComparison.Ordinal))
                        {
                            
                            laatsteKeuze.Image = Image.FromFile("..\\..\\img\\Verkeersborden\\ico.png");
                            picture.Image = Image.FromFile("..\\..\\img\\Verkeersborden\\ico.png");
                        }
                        else
                        {
                            laatsteKeuze.Tag = "Gevonden";
                            picture.Tag = "Gevonden";
                            closing = true;
                            for (int i = 0; i < Box.Length; i++)
                            {
                                if (!Box[i].Tag.Equals("Gevonden"))
                                {
                                    closing = false;
                                }
                            }
                            if (closing)
                            {
                                MessageBox.Show("Gefeliciteerd je hebt alle paren gevonden.");
                                this.Close();
                            }

                        }
                        laatsteKeuze = null;
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Memory_Load(object sender, EventArgs e)
        {

        }

        private void Memory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closing)
            {
                DialogResult test = MessageBox.Show("Weet u zeker dat u wilt afsluiten?", "OPPASSEN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (test == DialogResult.Yes)
                {
                    parentform.Location = this.Location;
                    parentform.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                parentform.Location = this.Location;
                parentform.Show();
            } 
        }
    }
}
