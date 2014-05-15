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
        private int juistAntwoord;
        private Boolean beantwoord = false, juistBeantwoord = false;
        private Boolean overgeslagen = false;

        public String PrintVraag()
        {
            String toPrint = "-------------\n" + vraag + "\n" + afbeelding.getNaam + "\n";
            switch (juistAntwoord)
            {
                case 1:
                    toPrint = toPrint + antwoord1.getAntwoord + "\n" + antwoord2.getAntwoord + "\n" + antwoord3.getAntwoord;
                    break;

                case 2:
                    toPrint = toPrint + antwoord2.getAntwoord + "\n" + antwoord1.getAntwoord + "\n" + antwoord3.getAntwoord;
                    break;

                case 3:
                    toPrint = toPrint + antwoord3.getAntwoord + "\n" + antwoord2.getAntwoord + "\n" + antwoord1.getAntwoord;
                    break;
            }
            toPrint = toPrint + "\n" + Uitleg;
            return toPrint;
        }



        public Boolean ControleerVraag(int Antwoord)
        {
            if (beantwoord == false)
            {
                beantwoord = true;
                if (juistAntwoord == Antwoord)
                {
                    juistBeantwoord = true;
                }
                else
                {
                    juistBeantwoord = false;
                }
            }
            return juistBeantwoord;
        }

        public Boolean Overgeslagen
        {
            get { return overgeslagen; }
            set
            {
                beantwoord = true; 
                overgeslagen = value; }
        }


        public Boolean IsBeantwoord
        {
            get
            {
                return beantwoord;
            }
        }
        public Boolean VraagJuist
        {
            get
            {
                return juistBeantwoord;
            }
        }

        public String Uitleg
        {
            get
            {
                return uitleg;
            }
        }

        public Keuze getAntwoord(int Nr)
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

        public Vraag(String vraag, String afbeelding, String antwoord1, String antwoord2, String antwoord3, String uitleg, Random R)
        {
            this.vraag = vraag;
            this.afbeelding = new Foto(afbeelding);
            this.uitleg = uitleg;

            switch (R.Next(0, 6))
            {
                case 1:
                    this.antwoord1 = new Keuze(antwoord1, true);
                    this.antwoord2 = new Keuze(antwoord2, false);
                    this.antwoord3 = new Keuze(antwoord3, false);
                    juistAntwoord = 1;
                    break;
                case 2:
                    this.antwoord1 = new Keuze(antwoord1, true);
                    this.antwoord2 = new Keuze(antwoord3, false);
                    this.antwoord3 = new Keuze(antwoord2, false);
                    juistAntwoord = 1;
                    break;
                case 3:
                    this.antwoord1 = new Keuze(antwoord2, false);
                    this.antwoord2 = new Keuze(antwoord1, true);
                    this.antwoord3 = new Keuze(antwoord3, false);
                    juistAntwoord = 2;
                    break;
                case 4:
                    this.antwoord1 = new Keuze(antwoord3, false);
                    this.antwoord2 = new Keuze(antwoord1, true);
                    this.antwoord3 = new Keuze(antwoord2, false);
                    juistAntwoord = 2;
                    break;
                case 5:
                    this.antwoord1 = new Keuze(antwoord2, false);
                    this.antwoord2 = new Keuze(antwoord3, false);
                    this.antwoord3 = new Keuze(antwoord1, true);
                    juistAntwoord = 3;
                    break;
                default:
                    this.antwoord1 = new Keuze(antwoord3, false);
                    this.antwoord2 = new Keuze(antwoord2, false);
                    this.antwoord3 = new Keuze(antwoord1, true);
                    juistAntwoord = 3;
                    break;
            }

        }

    }
}