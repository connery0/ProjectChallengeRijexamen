﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProjectChallengeRijexamen
{
    class MultipleChoice
    {
        private Vraag[] vragen;
        public MC_Form parentForm;
        private Vraag huidigeVraag;
        private int gevraagd = 0;
        private Random randomGetal = new Random();
        private String naam;
        private Boolean examen = false;


        public MultipleChoice(MC_Form parentForm, String naam) //oefenvragen
        {
            this.parentForm = parentForm;
            this.naam = naam;
            setVragen(naam);
            VolgendeVraag();
        }


        public Vraag vraag(int i)
        {
            return vragen[i];
        }





        public MultipleChoice(MC_Form parentForm) //examen
        {
            examen = true;
            naam = "..\\Vragen";
            this.parentForm = parentForm;
            setVragen(naam);
            for (int i = vragen.Length; i > 50; i--)
            {
                VolgendeVraag();
                huidigeVraag.Overgeslagen = true;
                if (gevraagd == 0) { }
            }
            VolgendeVraag();
        }


        public void VolgendeVraag()
        {
            if (gevraagd < vragen.Length)
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
            if (!examen)
            {
                String printVragen = "";
                Boolean eersteText = true;
                for (int i = 0; i < vragen.Length; i++)
                {
                    if (examen || ((!vragen[i].VraagJuist) || (!vragen[i].Beantwoord)))
                    {
                        if (!eersteText)
                        {
                            printVragen = printVragen + "\n";
                        }
                        else
                        {
                            eersteText = false;
                        }

                        printVragen = printVragen + vragen[i].PrintVraag();
                    }

                }
                if (printVragen == "")
                {
                    try
                    {
                        File.Delete("..\\..\\Vragen\\Persoon\\" + naam + ".txt");
                    }
                    catch (IOException fout)
                    {
                        Console.WriteLine(fout.Message);
                        return;
                    }
                }
                else
                {
                    File.WriteAllText("..\\..\\Vragen\\Persoon\\" + naam + ".txt", printVragen);
                }
            }
            parentForm.Close();
        }





        private void RandomVraag()
        {
            Random randomGetal2 = new Random();
            huidigeVraag = null;
            int teller = 0;
            while (huidigeVraag == null)
            {
                if (teller < 20)
                {
                    int I = randomGetal2.Next(0, vragen.Length);
                    if (vragen[I].Beantwoord == false)
                    {
                        huidigeVraag = vragen[I];
                    }
                }
                else
                {
                    for (int j = 0; j < vragen.Length; j++)
                    {
                        if (vragen[j].Beantwoord == false)
                        {
                            huidigeVraag = vragen[j];
                        }
                    }
                    if (huidigeVraag == null)
                    {
                        huidigeVraag = new Vraag();
                        parentForm.ShowMessage("Er is iets misgegaan, sluit het programma en probeer het opnieuw");
                    }
                }
                teller++;
            }

            setvraag(huidigeVraag);


        }

        public void ControleerVraag(int antwoord)
        {
            if (huidigeVraag.ControleerVraag(antwoord))
            {
                parentForm.VraagJuist();
            }
            else
            {
                parentForm.VraagFout(huidigeVraag.Uitleg);
            }
        }




        private void setvraag(Vraag vraag)
        {
            parentForm.setVraag(vraag.getVraag);
            for (int i = 1; i <= 3; i++)
            {
                parentForm.setAntwoord(vraag.getAntwoord(i).getAntwoord, i);
            }
            parentForm.setImage(vraag.Img.GetDoel());

        }

        private void setVragen(String bestandsNaam)
        {
            try
            {
                StreamReader myFile = new StreamReader("..\\..\\Vragen\\Persoon\\" + bestandsNaam + ".txt");
                string myString = myFile.ReadToEnd();

                myFile.Close();

                double volledigeLengte = myString.Split('\n').Length / 7;
                int lengte = Convert.ToInt32(volledigeLengte);
                vragen = new Vraag[lengte];

                ///////////////////////////////////////////////////////////////////////////////////////

                string line;
                int teller = 0;
                StreamReader file = new StreamReader("..\\..\\Vragen\\Persoon\\" + bestandsNaam + ".txt");
                while ((line = file.ReadLine()) != null)
                {
                    vragen[teller] = new Vraag(file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), randomGetal);
                    teller += 1;
                }
                file.Close();
            }
            catch (FileNotFoundException)
            {
                //hier moet error komen
            }
            
        }


        public int getAantalVragen
        {
            get
            {
                if (examen)
                {
                    return 50;
                }
                else
                {
                    return vragen.Length;
                }
            }
        }

    }
}
