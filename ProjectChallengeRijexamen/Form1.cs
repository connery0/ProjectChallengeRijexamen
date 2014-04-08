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
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vraag > -1 && AntwoordArray.Length > 1)
            {

                AntwoordArray = DeleteRow(AntwoordArray, vraag);
                genereerVraag();
            }
            else { MessageBox.Show("Einde"); }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AntwoordArray = AntwoordenLijst;
            genereerVraag();
        }
    }
}
