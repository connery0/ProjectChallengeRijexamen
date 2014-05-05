using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChallengeRijexamen
{
    class Vraag
    {

        private String vraag;
        private Foto afbeelding;
        private Keuze antwoord1, antwoord2, antwoord3;
        private String uitleg;
        private int JuistAntwoord;
        private Boolean Beantwoord = false, JuistBeantwoord = false;


        public String PrintVraag()
        {
            String toPrint = "-------------\n" + vraag + "\n" + afbeelding.getNaam() + "\n";
            switch (JuistAntwoord)
            {
                case 1:
                    toPrint = toPrint + antwoord1.getAntwoord() + "\n" + antwoord2.getAntwoord() + "\n" + antwoord3.getAntwoord();
                    break;

                case 2:
                    toPrint = toPrint + antwoord2.getAntwoord() + "\n" + antwoord1.getAntwoord() + "\n" + antwoord3.getAntwoord();
                    break;

                case 3:
                    toPrint = toPrint + antwoord3.getAntwoord() + "\n" + antwoord2.getAntwoord() + "\n" + antwoord1.getAntwoord();
                    break;
            }
            toPrint = toPrint + "\n" + Uitleg;
            return toPrint;
        }

        public Boolean ControleerVraag(int Antwoord)
        {
            if (Beantwoord == false)
            {
                Beantwoord = true;
                if (JuistAntwoord == Antwoord)
                {
                    JuistBeantwoord = true;
                }
                else { JuistBeantwoord = false; }
            }
            return JuistBeantwoord;
        }



        public Boolean IsBeantwoord
        {
            get
            {
                return Beantwoord;
            }
        }
        public Boolean VraagJuist
        {
            get
            {
                return JuistBeantwoord;
            }
        }

        public String Uitleg
        {
            get { return uitleg; }
        }

        public Keuze getantwoord(int Nr)
        {
            Keuze returnAntwoord;
            switch (Nr)
            {
                case 1:
                    returnAntwoord = antwoord1;
                    break;
                case 2:
                    returnAntwoord = antwoord2;
                    break;
                case 3:
                    returnAntwoord = antwoord3;
                    break;
                default:
                    returnAntwoord = new Keuze("Error", false);
                    break;
            }
            return returnAntwoord;
        }
        public String getVraag
        {
            get
            {
                return vraag;
            }
        }
        public Foto Img
        {
            get
            {
                return afbeelding;
            }
        }

        public Vraag()
        {
            vraag = "Error";
            afbeelding = new Foto("Error.jpg");
        }

        public Vraag(String Vraag, String Afbeelding, String Antwoord1, String Antwoord2, String Antwoord3, String Uitleg, Random R)
        {
            vraag = Vraag; ;
            afbeelding = new Foto(Afbeelding);
            this.uitleg = Uitleg;

            switch (R.Next(0, 6))
            {
                case 1:
                    antwoord1 = new Keuze(Antwoord1, true);
                    antwoord2 = new Keuze(Antwoord2, false);
                    antwoord3 = new Keuze(Antwoord3, false);
                    JuistAntwoord = 1;
                    break;
                case 2:
                    antwoord1 = new Keuze(Antwoord1, true);
                    antwoord2 = new Keuze(Antwoord3, false);
                    antwoord3 = new Keuze(Antwoord2, false);
                    JuistAntwoord = 1;
                    break;
                case 3:
                    antwoord1 = new Keuze(Antwoord2, false);
                    antwoord2 = new Keuze(Antwoord1, true);
                    antwoord3 = new Keuze(Antwoord3, false);
                    JuistAntwoord = 2;
                    break;
                case 4:
                    antwoord1 = new Keuze(Antwoord3, false);
                    antwoord2 = new Keuze(Antwoord1, true);
                    antwoord3 = new Keuze(Antwoord2, false);
                    JuistAntwoord = 2;
                    break;
                case 5:
                    antwoord1 = new Keuze(Antwoord2, false);
                    antwoord2 = new Keuze(Antwoord3, false);
                    antwoord3 = new Keuze(Antwoord1, true);
                    JuistAntwoord = 3;
                    break;
                default:
                    antwoord1 = new Keuze(Antwoord3, false);
                    antwoord2 = new Keuze(Antwoord2, false);
                    antwoord3 = new Keuze(Antwoord1, true);
                    JuistAntwoord = 3;
                    break;
            }

        }

    }
}