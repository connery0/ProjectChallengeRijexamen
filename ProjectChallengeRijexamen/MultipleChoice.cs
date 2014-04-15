using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChallengeRijexamen
{
    class MultipleChoice
    {
        Vraag[] Vragen;


        public MultipleChoice(String Naam)
        {
            setAantalVragen(Naam);
            setVragen(Naam);
        }





        public MultipleChoice()
        {
            setAantalVragen("test");
            setVragen("test");
        }

        private void setAantalVragen(String bestandsNaam)
        {
            System.IO.StreamReader myFile =
           new System.IO.StreamReader("..\\..\\Vragen\\" + bestandsNaam+".txt");
            string myString = myFile.ReadToEnd();

            myFile.Close();
            int Lengte = myString.Split('\n').Length / 6;
            Vragen = new Vraag[Lengte];
        }

        private void setVragen(String bestandsNaam)
        {

            string line;
            int teller = 0;
            System.IO.StreamReader file = new System.IO.StreamReader("..\\..\\Vragen\\" + bestandsNaam + ".txt");
            while ((line = file.ReadLine()) != null)
            {
                Vragen[teller] = new Vraag(file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine());
                teller += 1;
            }
            file.Close();
        }


        public int getAantalVragen()
        {
            return Vragen.Length;
        }









    }
}
