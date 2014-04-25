using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChallengeRijexamen
{
    class MultipleChoice
    {
        private Vraag[] Vragen;
        private MC_Form ParentForm;
        private Keuze HuidigAntwoord1, HuidigAntwoord2, HuidigAntwoord3;
        private Vraag HuidigeVraag;


        private void setvraag(Vraag V)
        {
            ParentForm.setVraag(V.getVraag());
            for (int i = 1; i <= 3; i++)
            {
                ParentForm.setAntwoord(V.getantwoord(i).getAntwoord(), i);
            }
            ParentForm.setImage(V.getImg().getDoel());
            ParentForm.setUitleg(V.getUitleg());

        }

        public MultipleChoice(MC_Form ParentForm, String Naam, Boolean NieuwBestand)
        {
            this.ParentForm = ParentForm;

            setVragen(Naam);
            setvraag(Vragen[1]);


        }



        
        private void setVragen(String bestandsNaam)
        {
            System.IO.StreamReader myFile =
            new System.IO.StreamReader("..\\..\\Vragen\\" + bestandsNaam + ".txt");
            string myString = myFile.ReadToEnd();

            myFile.Close();
            int Lengte = myString.Split('\n').Length / 6;
            Vragen = new Vraag[Lengte];

            ///////////////////////////////////////////////////////////////////////////////////////
            
            string line;
            int teller = 0;
            System.IO.StreamReader file = new System.IO.StreamReader("..\\..\\Vragen\\" + bestandsNaam + ".txt");
            while ((line = file.ReadLine()) != null)
            {
                Vragen[teller] = new Vraag(file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine());
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
