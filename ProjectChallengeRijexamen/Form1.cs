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
    public partial class Form1 : Form
    {
        int Antwoord = 0;
        int vraag = -1;
        Random r = new Random();
        String[][] AntwoordArray;
        String[][] AntwoordenLijst = 
            {
                new String[] {"1+1=","2","3","7","9"},
                new String[] {"0+0","0","4","6","984512316546531"},
                new String[] {"test","Juist Antwoord","11","22","1531"},
                new String[] {"2+2=","4","11","22","1531"}
            };



        private String[][] DeleteRow(String[][] A, int ToDelete)
        {
            String[][] TempArray = new String[A.Length - 1][];
            for (int i = 0; i < A.Length; i++)
            {
                if (i < ToDelete)
                {
                    TempArray[i] = A[i];
                }
                else if (i > ToDelete)
                {
                    TempArray[i - 1] = A[i];
                }
            }
            return TempArray;
        }


        private void genereerVraag()
        {
            vraag = r.Next(0, AntwoordArray.Length);
            Vraagbox.Text = AntwoordArray[vraag][0];
            int A1, A2, A3, A4;
            A1 = r.Next(1, AntwoordArray[vraag].Length);
            A2 = r.Next(1, AntwoordArray[vraag].Length);
            while (A2 == A1)
            {
                A2 = r.Next(1, AntwoordArray[vraag].Length);
            }
            A3 = r.Next(1, AntwoordArray[vraag].Length);
            while (A3 == A2 || A3 == A1)
            {
                A3 = r.Next(1, AntwoordArray[vraag].Length);
            }
            A4 = r.Next(1, AntwoordArray[vraag].Length);
            while (A4 == A3 || A4 == A2 || A4 == A1)
            {
                A4 = r.Next(1, AntwoordArray[vraag].Length);
            }
            antwoord1.Text = AntwoordArray[vraag][A1];
            antwoord2.Text = AntwoordArray[vraag][A2];
            antwoord3.Text = AntwoordArray[vraag][A3];
            antwoord4.Text = AntwoordArray[vraag][A4];






        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Antwoord != 0)
            {
                if (Antwoord == 1) { textBox2.Text = "Juist"; }
                else { textBox2.Text = "Fout"; }

                Antwoord = 0;
                antwoord1.Checked = false;
                antwoord2.Checked = false;
                antwoord3.Checked = false;
                antwoord4.Checked = false;
                
                if (vraag > -1 && AntwoordArray.Length > 1)
                {

                    AntwoordArray = DeleteRow(AntwoordArray, vraag);
                    genereerVraag();
                   
                }

                else { MessageBox.Show("Einde"); }
            }
            else
            {
                MessageBox.Show("Gelieve een antwoord aan te duiden");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Antwoord = 0;
            antwoord1.Checked = false;
            antwoord2.Checked = false;
            antwoord3.Checked = false;
            antwoord4.Checked = false;
            antwoord1.Visible = true;
            antwoord2.Visible = true;
            antwoord3.Visible = true;
            antwoord4.Visible = true;
            AntwoordArray = AntwoordenLijst;
            genereerVraag();

        }

        private void antwoord1_CheckedChanged(object sender, EventArgs e)
        {
            if (antwoord1.Checked)
            {
                Antwoord = Array.LastIndexOf(AntwoordArray[vraag], antwoord1.Text);
            }
        }

        private void antwoord2_CheckedChanged(object sender, EventArgs e)
        {
            if (antwoord2.Checked)
            {
                Antwoord = Array.LastIndexOf(AntwoordArray[vraag], antwoord2.Text);
            }
        }
        private void antwoord3_CheckedChanged(object sender, EventArgs e)
        {
            if (antwoord3.Checked)
            {
                Antwoord = Array.LastIndexOf(AntwoordArray[vraag], antwoord3.Text);
            }

        }
        private void antwoord4_CheckedChanged(object sender, EventArgs e)
        {
            if (antwoord4.Checked)
            {
                Antwoord = Array.LastIndexOf(AntwoordArray[vraag], antwoord4.Text);
            }
        }


    }
}
