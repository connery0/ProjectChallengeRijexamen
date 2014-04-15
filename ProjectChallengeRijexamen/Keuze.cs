using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChallengeRijexamen
{
    class Keuze
    {
        private String antwoord;
        private Boolean juist;


        public Keuze(String Antwoord,Boolean Juist){
            antwoord=Antwoord;
            juist=Juist;

        }

        public String getAntwoord()
        {
            return antwoord;
        }
        public Boolean isJuist()
        {
            return juist;
        }




        
    }
}
