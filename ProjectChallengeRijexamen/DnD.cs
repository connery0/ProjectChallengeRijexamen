﻿using System;
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
    public partial class DnD : Form
    {
        private PictureBox pic1;
        private PictureBox pic2;
        private Verkeersbord[] alleVerkeersborden;
        private Verkeersbord[] gevraagdeVerkeersborden;
        private Form1 Parentform;
        private int randomFoto;
        private int randomUitleg;

        public DnD(Form1 Parentform)
        {
            InitializeComponent();
            this.Parentform = Parentform;
            setVerkeersborden();
            randomVerkeersborden();
            invullen();
            
            
            foreach( Control control in this.Controls){
                
                if (control is PictureBox)
                {
                    PictureBox picture = (PictureBox)control;
                    if (picture.Name != "pictureBox1" && picture.Name != "pictureBox2" &&
                        picture.Name != "pictureBox3" && picture.Name != "pictureBox4" && picture.Name != "pictureBox5" &&
                        picture.Name != "pictureBox6")
                    {
                        control.AllowDrop = true;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pic1.Location = new Point(Cursor.Position.X - this.Location.X - 60, Cursor.Position.Y - this.Location.Y - 80);
        }

        private void pictureBox7_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
            pic1 = (PictureBox)sender;
            timer1.Start();
            DoDragDrop(pic1.Image, DragDropEffects.Copy | DragDropEffects.Move);
            timer1.Stop();
                switch (pic1.Name)
                {
                    case "pictureBox1":
                        pic1.Location = new Point(12, 12);
                        break;
                    case "pictureBox2":
                        pic1.Location = new Point(118, 12);
                        break;
                    case "pictureBox3":
                        pic1.Location = new Point(224, 12);
                        break;
                    case "pictureBox4":
                        pic1.Location = new Point(330, 12);
                        break;
                    case "pictureBox5":
                        pic1.Location = new Point(436, 12);
                        break;
                    case "pictureBox6":
                        pic1.Location = new Point(542, 12);
                        break;
                }
            }
        }

       
        private void pictureBox7_DragDrop(object sender, DragEventArgs e)
        {
            pic2 = (PictureBox)sender;
            controle();
            pic2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pic2.Tag = pic1.Tag;
            timer1.Stop();
        }

      
        private void setVerkeersborden()
        {
            System.IO.StreamReader myFile = new System.IO.StreamReader("..\\..\\Vragen\\Borden.txt");
            string myString = myFile.ReadToEnd();

            myFile.Close();

            double L = myString.Split('\n').Length / 3;
            int Lengte = Convert.ToInt32(L);
            alleVerkeersborden = new Verkeersbord[Lengte];

            ///////////////////////////////////////////////////////////////////////////////////////

            string line;
            int teller = 0;
            System.IO.StreamReader file = new System.IO.StreamReader("..\\..\\Vragen\\Borden.txt");
            while ((line = file.ReadLine()) != null)
            {
                alleVerkeersborden[teller] = new Verkeersbord(file.ReadLine(), file.ReadLine());
                teller += 1;
            }
            file.Close();
        }
        private void controle()
        {
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
            pic2 = (PictureBox)sender;
            pic2.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (button1.Text == "Controle") {
                foreach (Control control in this.Controls)
                {
                    if (control is PictureBox)
                    {
                        PictureBox picture = (PictureBox)control;
                        if (picture.Tag == null)
                        {
                            MessageBox.Show("Gelieve alle pictureboxen in te vullen", "Lege pictureboxen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }


                    }
                }

                if (pictureBox7.Tag.ToString() == label1.Text)
                {
                    label1.BackColor = Color.Green;
                }
                else
                {
                    label1.BackColor = Color.Red;
                }

                if (pictureBox8.Tag.ToString() == label2.Text)
                {
                    label2.BackColor = Color.Green;
                }
                else
                {
                    label2.BackColor = Color.Red;
                }

                if (pictureBox9.Tag.ToString() == label3.Text)
                {
                    label3.BackColor = Color.Green;
                }
                else
                {
                    label3.BackColor = Color.Red;
                }

                if (pictureBox10.Tag.ToString() == label4.Text)
                {
                    label4.BackColor = Color.Green;
                }
                else
                {
                    label4.BackColor = Color.Red;
                }

                if (pictureBox11.Tag.ToString() == label5.Text)
                {
                    label5.BackColor = Color.Green;
                }
                else
                {
                    label5.BackColor = Color.Red;
                }

                if (pictureBox12.Tag.ToString() == label6.Text)
                {
                    label6.BackColor = Color.Green;
                }
                else
                {
                    label6.BackColor = Color.Red;
                }

                for (int i = 0; i < gevraagdeVerkeersborden.Length; i++)
                {
                    gevraagdeVerkeersborden[i].GetSetBeantwoord = true;
                }

                button1.Text = "Volgende";

            }
            else if (button1.Text == "Volgende")
            {
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
                        uitleg.BackColor = Color.White;
                    }
                }
                randomVerkeersborden();
                invullen();
                button1.Text = "Controle";
            }
        
        }

        private void randomVerkeersborden()
        {
            Random randomGetal = new Random();
            gevraagdeVerkeersborden = new Verkeersbord[6];
            int tellerAantal = 0;
            int teller = 0;
            Boolean testing;
            while (tellerAantal<6)
            {
                testing = false;
                if (teller < 10)
                {
                    int i = randomGetal.Next(0, alleVerkeersborden.Length);
                    if (alleVerkeersborden[i].GetSetBeantwoord == false)
                    {
                        
                        for (int j = 1; j <= tellerAantal; j++)
                        {
                            if (gevraagdeVerkeersborden[j-1] == alleVerkeersborden[i])
                            {
                                testing = true;
                                break;
                            }
                        }
                        if (!testing)
                        {
                            gevraagdeVerkeersborden[tellerAantal] = alleVerkeersborden[i];
                            tellerAantal++;
                        }
                        
                            
                    }
                }
                else
                {
                    for (int j = 0; j < alleVerkeersborden.Length; j++)
                    {
                        if (alleVerkeersborden[j].GetSetBeantwoord == false)
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
                      
                        picture.Image = Image.FromFile(gevraagdeVerkeersborden[randomFoto].getDoelVerkeersbord());
                        picture.Tag = gevraagdeVerkeersborden[randomFoto].deUitleg;

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
           
                    uitleg.Text = gevraagdeVerkeersborden[randomUitleg].deUitleg;
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

        private void DnD_Load(object sender, EventArgs e)
        {

        }

        private void DnD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parentform.Location = this.Location;
            Parentform.Show();
               
            
        }

        private void DnD_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
       
    }
}
