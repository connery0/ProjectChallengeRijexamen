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
    public partial class DnD : Form
    {
        private PictureBox pic1;
        private PictureBox pic2;
        public DnD()
        {
            InitializeComponent();
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


        private void button1_Click_1(object sender, EventArgs e)
        {
           
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
            if (controle())
            {
                pic2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                timer1.Stop();
            }
            else
            {
                pic2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                timer1.Stop();
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Boolean controle()
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
                        return false;

                    }
                    
                }
            }
            return true;
        }

        private void pictureBox10_DoubleClick(object sender, EventArgs e)
        {
            pic2 = (PictureBox)sender;
            pic2.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
       
    }
}
