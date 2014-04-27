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
                if ((!Vragen[i].VraagJuist())||(!Vragen[i].VraagBeantwoord()))
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
                    System.IO.File.Delete("..\\..\\Vragen\\" + Naam + ".txt");
                }
                catch (System.IO.IOException f)
                {
                    Console.WriteLine(f.Message);
                    return;
                }
            }
            else
            {
                System.IO.File.WriteAllText("..\\..\\Vragen\\" + Naam + ".txt", PrintVragen);
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
                    if (Vragen[I].VraagBeantwoord() == false)
                    {
                        HuidigeVraag = Vragen[I];
                    }
                }
                else
                {
                    for (int j = 0; j < Vragen.Length; j++)
                    {
                        if (Vragen[j].VraagBeantwoord() == false)
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
                ParentForm.VraagFout(HuidigeVraag.getUitleg());
            }
        }




        private void setvraag(Vraag V)
        {
            ParentForm.setVraag(V.getVraag());
            for (int i = 1; i <= 3; i++)
            {
                if (V.getantwoord(1) == null)
                {
                    ParentForm.ShowMessage("wut");
                }
                ParentForm.setAntwoord(V.getantwoord(i).getAntwoord(), i);
            }
            ParentForm.setImage(V.getImg().getDoel());

        }

        private void setVragen(String bestandsNaam)
        {
            System.IO.StreamReader myFile =
            new System.IO.StreamReader("..\\..\\Vragen\\" + bestandsNaam + ".txt");
            string myString = myFile.ReadToEnd();

            myFile.Close();

            double L = myString.Split('\n').Length / 7;
            int Lengte = Convert.ToInt32(L);
            Vragen = new Vraag[Lengte];

            ///////////////////////////////////////////////////////////////////////////////////////

            string line;
            int teller = 0;
            System.IO.StreamReader file = new System.IO.StreamReader("..\\..\\Vragen\\" + bestandsNaam + ".txt");
            while ((line = file.ReadLine()) != null)
            {
                Vragen[teller] = new Vraag(file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), R);
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
