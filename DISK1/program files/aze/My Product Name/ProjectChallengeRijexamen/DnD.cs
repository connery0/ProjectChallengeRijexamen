﻿//Drag en Drop
//Author: Stef Janssens
//Datum: 6/05/2014
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

namespace ProjectChallengeRijexamen
{
    public partial class DnD : Form
    {
        private PictureBox pic1;
        private PictureBox pic2;
        private Verkeersbord[] alleVerkeersborden;
        private Verkeersbord[] gevraagdeVerkeersborden;
        private Form1 parentform;
        private int randomFoto;
        private int randomUitleg;
        private int aantalJuist;
        private int aantalVerkeersborden;
        private Boolean sluiten = false;

        public DnD(Form1 Parentform)
        {
            InitializeComponent();
            this.parentform = Parentform;
            setVerkeersborden();
            randomVerkeersborden();
            invullen();
            // Er voor zorgen dat de pictureboxen een drop toelaten
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;
            pictureBox9.AllowDrop = true;
            pictureBox10.AllowDrop = true;
            pictureBox11.AllowDrop = true;
            pictureBox12.AllowDrop = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Dat de picturebox locatie verandert waar de muis is
            pic1.Location = new Point(Cursor.Position.X - this.Location.X - 60, Cursor.Position.Y - this.Location.Y - 80);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //Als de linkermuis knop wordt ingedrukt voert hij deze code uit
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pic1 = (PictureBox)sender;

                timer1.Start();
                      
                DoDragDrop(pic1.Image, DragDropEffects.Copy | DragDropEffects.Move);
                
                timer1.Stop();
                //Zien of het op de juiste plaats is gedropt
                int picX = pic1.Location.X + 50;
                int picY = pic1.Location.Y + 50;
                if (picX >= 12 && picX <= 112 && picY >= 118 && picY <= 218)
                {
                    controle();
                    pictureBox7.Image = pic1.Image;
                    pictureBox7.Tag = pic1.Tag;
                }
                else if (picX >= 12 && picX <= 112 && picY >= 224 && picY <= 324)
                {
                    controle();
                    pictureBox8.Image = pic1.Image;
                    pictureBox8.Tag = pic1.Tag;
                }
                else if (picX >= 12 && picX <= 112 && picY >= 330 && picY <= 430)
                {
                    controle();
                    pictureBox9.Image = pic1.Image;
                    pictureBox9.Tag = pic1.Tag;
                }
                else if (picX >= 330 && picX <= 430 && picY >= 118 && picY <= 218)
                {
                    controle();
                    pictureBox10.Image = pic1.Image;
                    pictureBox10.Tag = pic1.Tag;
                }
                else if (picX >= 330 && picX <= 430 && picY >= 224 && picY <= 324)
                {
                    controle();
                    pictureBox11.Image = pic1.Image;
                    pictureBox11.Tag = pic1.Tag;
                }
                else if (picX >= 330 && picX <= 430 && picY >= 330 && picY <= 430)
                {
                    controle();
                    pictureBox12.Image = pic1.Image;
                    pictureBox12.Tag = pic1.Tag;
                }         
                //Terug zetten van de picturebox op de juiste plaats
                switch (pic1.Name)
                {
                    case "pictureBox1":
                        pic1.Location = new Point(12, 12);
                        break;
                    case "pictureBox2":
                        pic1.Location = new Point(121, 12);
                        break;
                    case "pictureBox3":
                        pic1.Location = new Point(227, 12);
                        break;
                    case "pictureBox4":
                        pic1.Location = new Point(333, 12);
                        break;
                    case "pictureBox5":
                        pic1.Location = new Point(439, 12);
                        break;
                }
            }
        }
      
        private void setVerkeersborden()
        {
            //Het inlezen van alle verkeersborden in een array
            try
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
            catch (FileNotFoundException)
            {
                MessageBox.Show("Het bestand is niet gevonden." + Environment.NewLine + "Gelieve te herinstalleren","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
           
        }
        private void controle()
        {
            //controle of de image als gebruikt is, zo ja verwijder het in die picturebox
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    PictureBox picture = (PictureBox)control;
                    if (picture.Image == pic1.Image && picture.Name != "pictureBox1" && picture.Name != "pictureBox2" && 
                        picture.Name != "pictureBox3" && picture.Name != "pictureBox4" && picture.Name != "pictureBox5" && 
                        picture.Name != "pictureBox6")
                    {
                        picture.Image = null; 
                     }
                    
                }
            }
        }

        private void pictureBox10_DoubleClick(object sender, EventArgs e)
        {
            //Een andere manier om picturebox leeg te krijgen
            pic2 = (PictureBox)sender;
            pic2.Image = null;
            pic2.Tag = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            //Controle uitvoeren
            if (button1.Text == "Controle") {
                foreach (Control control in this.Controls)
                {
                    if (control is PictureBox)
                    {
                        PictureBox picture = (PictureBox)control;
                        //controle of alles is ingevuld
                        if (picture.Tag == null)
                        {
                            MessageBox.Show("Gelieve alle verkeersborden te matchen!", "Lege plaatsen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                //Zien of het juist is ingevuld
                if (pictureBox7.Tag.ToString() == label1.Text)
                {
                    label1.BackColor = Color.Green;
                    aantalJuist++;
                }
                else
                {
                    label1.BackColor = Color.Red;
                }

                if (pictureBox8.Tag.ToString() == label2.Text)
                {
                    label2.BackColor = Color.Green;
                    aantalJuist++;
                }
                else
                {
                    label2.BackColor = Color.Red;
                                    }

                if (pictureBox9.Tag.ToString() == label3.Text)
                {
                    label3.BackColor = Color.Green;
                    aantalJuist++;
                }
                else
                {
                    label3.BackColor = Color.Red;
                }

                if (pictureBox10.Tag.ToString() == label4.Text)
                {
                    label4.BackColor = Color.Green;
                    aantalJuist++;
                }
                else
                {
                    label4.BackColor = Color.Red;
                }

                if (pictureBox11.Tag.ToString() == label5.Text)
                {
                    label5.BackColor = Color.Green;
                    aantalJuist++;
                }
                else
                {
                    label5.BackColor = Color.Red;
                }

                if (pictureBox12.Tag.ToString() == label6.Text)
                {
                    label6.BackColor = Color.Green;
                    aantalJuist++;
                }
                else
                {
                    label6.BackColor = Color.Red;
                }

                for (int i = 0; i < gevraagdeVerkeersborden.Length; i++)
                {
                    gevraagdeVerkeersborden[i].Beantwoord = true;
                }
                aantalVerkeersborden += 6;
                button1.Text = "Volgende";

            }
            else if (button1.Text == "Volgende")
            {
                //Kijken of er nog verkeersborden zijn
                Boolean nogVerkeersborden = false;
                for (int i = 0; i < alleVerkeersborden.Length; i++)
                {
                    if (alleVerkeersborden[i].Beantwoord == false)
                    {
                        nogVerkeersborden = true;
                    }
                }

                if (nogVerkeersborden)
                {
                    //Alles terug zetten naar begin waarde
                    foreach (Control control in this.Controls)
                    {
                        if (control is PictureBox)
                        {
                            PictureBox picture = (PictureBox)control;
                            if (picture.Name != "pictureBox1" && picture.Name != "pictureBox2" &&
                                picture.Name != "pictureBox3" && picture.Name != "pictureBox4" && picture.Name != "pictureBox5" &&
                                picture.Name != "pictureBox6")
                            {
                                picture.Image = null;
                                picture.Tag = null;
                            }

                        }
                        else if (control is Label)
                        {
                            Label uitleg = (Label)control;
                            uitleg.BackColor = Color.Transparent;
                        }
                    }
                    //nieuwe 6 verkeersborden
                    randomVerkeersborden();
                    invullen();
                    button1.Text = "Controle";
                }
                else
                {
                    MessageBox.Show("Je hebt alle verkeersborden geoefend." + Environment.NewLine + "Je hebt " + aantalJuist.ToString() + "/24" + " gescoord.", "KLAAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sluiten = true;
                    this.Close();
                }
            }
        
        }

        private void randomVerkeersborden()
        {
            //6 Random verkeersborden kiezen
            Random randomGetal = new Random();
            gevraagdeVerkeersborden = new Verkeersbord[6];
            int tellerAantal = 0;
            int teller = 0;
            Boolean testing;
            while (tellerAantal<6)
            {
                testing = false;
                if (teller < 12)
                {
                    int i = randomGetal.Next(0, alleVerkeersborden.Length);
                    if (alleVerkeersborden[i].Beantwoord == false)
                    {            
                        for (int j = 1; j <= tellerAantal; j++)
                        {
                            //testen of het verkeersbord al in de array voor 6 zit
                            if (gevraagdeVerkeersborden[j-1] == alleVerkeersborden[i])
                            {
                                testing = true;
                                break;
                            }
                        }
                        // zit het er in doet hij deze code niet, zit de verkeersbord er nog niet in doet hij deze code en plaats hij het in de array
                        if (!testing)
                        {
                            gevraagdeVerkeersborden[tellerAantal] = alleVerkeersborden[i];
                            tellerAantal++;
                        }                      
                    }
                }
                else
                {
                    //Moest er altijd het zelfde random getal pakken. Gaat het hier door de hele array
                    for (int j = 0; j < alleVerkeersborden.Length; j++)
                    {
                        testing = false;
                        if (tellerAantal == 6)
                        {
                            break;
                        }
                        if (alleVerkeersborden[j].Beantwoord == false)
                        {
                            for (int k = 1; k <= tellerAantal; k++)
                            {
                                if (gevraagdeVerkeersborden[k - 1] == alleVerkeersborden[j])
                                {
                                    testing = true;
                                    break;
                                }
                            }
                            if (!testing)
                            {
                                gevraagdeVerkeersborden[tellerAantal] = alleVerkeersborden[j];
                                tellerAantal++;
                            }
                        }
                    }
                    
                }
                teller++;                
            }
        }

        private void invullen()
        {
            // Het invullen van de pictureboxen en labels
            Random getal = new Random();
            randomFoto = getal.Next(0,5);
            randomUitleg = getal.Next(0,5);
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    PictureBox picture = (PictureBox) control;
                    if (picture.Name == "pictureBox1" || picture.Name == "pictureBox2" ||
                        picture.Name == "pictureBox3" || picture.Name == "pictureBox4" || picture.Name == "pictureBox5" ||
                        picture.Name == "pictureBox6")
                    {                      
                        picture.Image = Image.FromFile(gevraagdeVerkeersborden[randomFoto].GetDoel());
                        picture.Tag = gevraagdeVerkeersborden[randomFoto].Uitleg;

                        if (randomFoto == 5)
                        {
                            randomFoto = 0;
                        }
                        else
                        {
                            randomFoto++;
                        }                        
                    }
                }
                else if (control is Label)
                {
                    Label uitleg = (Label)control;
           
                    uitleg.Text = gevraagdeVerkeersborden[randomUitleg].Uitleg;
                    if (randomUitleg == 5)
                    {
                        randomUitleg = 0;
                    }
                    else
                    {
                        randomUitleg++;
                    }
                }
            }            
        }

        private void DnD_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Als het formulier sluit en je bent nog bezig doet hij deze code. Zorgt ervoor dat hij er perongeluk op kan klikken en toch verder gaan
            if (!sluiten)
            {
                DialogResult test = MessageBox.Show("Weet u zeker dat u wilt afsluiten?", "OPPASSEN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (test == DialogResult.Yes)
                {
                    MessageBox.Show("Je hebt " + aantalJuist.ToString() + "/" + aantalVerkeersborden.ToString() + " gescoord.", "GESTOPT", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //http://msdn.microsoft.com/en-us/library/aa984430(v=vs.71).aspx
        //drag en drop voor laatste picturebox om toch een normale drop te hebben
        private void pictureBox7_DragDrop(object sender, DragEventArgs e)
        {
            pic2 = (PictureBox)sender;
            controle();
            pic2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pic2.Tag = pic1.Tag;
            timer1.Stop();
        }

        private void pictureBox7_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pic1 = (PictureBox)sender;

                timer1.Start();

                DoDragDrop(pic1.Image, DragDropEffects.Copy | DragDropEffects.Move);

                timer1.Stop();
                
                pic1.Location = new Point(545, 12);  
            }
        }       
    }
}
