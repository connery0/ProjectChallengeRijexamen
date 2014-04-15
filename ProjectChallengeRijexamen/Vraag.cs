using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChallengeRijexamen
{
    class Vraag
    {

        String vraag; 
        Foto afbeelding;
        Keuze antwoord1, antwoord2, antwoord3;



        public Vraag(String Vraag, String Afbeelding, String Antwoord1, String Antwoord2, String Antwoord3)
        {
            vraag = Vraag; ;
            afbeelding =new Foto(Afbeelding);

            int R = new Random().Next(0, 6);
            switch (R)
            {
                case 1:
                    antwoord1 = new Keuze(Antwoord1, true);
                    antwoord2 = new Keuze(Antwoord2, false);
                    antwoord3 = new Keuze(Antwoord3, false);
                    break;
                case 2:
                    antwoord1 = new Keuze(Antwoord1, true);
                    antwoord2 = new Keuze(Antwoord3, false);
                    antwoord3 = new Keuze(Antwoord2, false);
                    break;
                case 3:
                    antwoord1 = new Keuze(Antwoord2, false);
                    antwoord2 = new Keuze(Antwoord1, true);
                    antwoord3 = new Keuze(Antwoord3, false);
                    break;
                case 4:
                    antwoord1 = new Keuze(Antwoord3, false);
                    antwoord2 = new Keuze(Antwoord1, true);
                    antwoord3 = new Keuze(Antwoord2, false);
                    break;
                case 5:
                    antwoord1 = new Keuze(Antwoord2, false);
                    antwoord2 = new Keuze(Antwoord3, false);
                    antwoord3 = new Keuze(Antwoord1, true);
                    break;
                case 6:
                    antwoord1 = new Keuze(Antwoord3, false);
                    antwoord2 = new Keuze(Antwoord2, false);
                    antwoord3 = new Keuze(Antwoord1, true);
                    break;
            }




        }

    }
}