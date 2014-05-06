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
        public MC_Form ParentForm;
        private Vraag HuidigeVraag;
        private int gevraagd = 0;
        private Random R = new Random();
        private String Naam;


        public MultipleChoice(MC_Form ParentForm, String Naam)
        {
            this.ParentForm = ParentForm;
            this.Naam = Naam;
            setVragen(Naam);
            VolgendeVraag();
        }


        public void VolgendeVraag()
        {
            if (gevraagd < Vragen.Length)
            {
                RandomVraag();
                gevraagd++;
            }
            else
            {
                EindeVraag();

            }

        }


        public void EindeVraag()
        {
            ParentForm.ShowMessage("einde");

            String PrintVragen = "";
            Boolean EersteText = true;
            for (int i = 0; i < Vragen.Length; i++)
            {
                if ((!Vragen[i].VraagJuist)||(!Vragen[i].IsBeantwoord))
                {
                    if (!EersteText)
                    {
                        PrintVragen = PrintVragen + "\n";
                    }
                    else
                    {
                        EersteText = false;
                    }

                    PrintVragen = PrintVragen + Vragen[i].PrintVraag();
                }

            }
            if (PrintVragen == "")
            {
                try
                {
                    System.IO.File.Delete("..\\..\\Vragen\\Persoon\\" + Naam + ".txt");
                }
                catch (System.IO.IOException f)
                {
                    Console.WriteLine(f.Message);
                    return;
                }
            }
            else
            {
                System.IO.File.WriteAllText("..\\..\\Vragen\\Persoon\\" + Naam + ".txt", PrintVragen);
            }

            ParentForm.Close();

        }





        private void RandomVraag()
        {
            Random R = new Random();
            HuidigeVraag = null;
            int teller = 0;
            while (HuidigeVraag == null)
            {
                if (teller < 20)
                {
                    int I = R.Next(0, Vragen.Length);
                    if (Vragen[I].IsBeantwoord == false)
                    {
                        HuidigeVraag = Vragen[I];
                    }
                }
                else
                {
                    for (int j = 0; j < Vragen.Length; j++)
                    {
                        if (Vragen[j].IsBeantwoord == false)
                        {
                            HuidigeVraag = Vragen[j];
                        }
                    }
                    if (HuidigeVraag == null)
                    {
                        HuidigeVraag = new Vraag();
                        ParentForm.ShowMessage("Er is iets misgegaan, sluit het programma en probeer het opnieuw");
                    }
                }
                teller++;
            }

            setvraag(HuidigeVraag);


        }

        public void ControleerVraag(int Antwoord)
        {
            if (HuidigeVraag.ControleerVraag(Antwoord))
            {
                ParentForm.VraagJuist();
            }
            else
            {
                ParentForm.VraagFout(HuidigeVraag.Uitleg);
            }
        }




        private void setvraag(Vraag V)
        {
            ParentForm.setVraag(V.getVraag);
            for (int i = 1; i <= 3; i++)
            {
                ParentForm.setAntwoord(V.getantwoord(i).getAntwoord(), i);
            }
            ParentForm.setImage(V.Img.getDoel());

        }

        private void setVragen(String bestandsNaam)
        {
            System.IO.StreamReader myFile =
            new System.IO.StreamReader("..\\..\\Vragen\\Persoon\\" + bestandsNaam + ".txt");
            string myString = myFile.ReadToEnd();

            myFile.Close();

            double L = myString.Split('\n').Length / 7;
            int Lengte = Convert.ToInt32(L);
            Vragen = new Vraag[Lengte];

            ///////////////////////////////////////////////////////////////////////////////////////

            string line;
            int teller = 0;
            System.IO.StreamReader file = new System.IO.StreamReader("..\\..\\Vragen\\Persoon\\" + bestandsNaam + ".txt");
            while ((line = file.ReadLine()) != null)
            {
                String test, test2, test3, test4, test5, test6;
                test = file.ReadLine();
                test2 = file.ReadLine();
                test3 = file.ReadLine();
                test4 = file.ReadLine();
                test5 = file.ReadLine();
                test6 = file.ReadLine();

                Vragen[teller] = new Vraag(test,test2,test3,test4,test5,test6, R);
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
