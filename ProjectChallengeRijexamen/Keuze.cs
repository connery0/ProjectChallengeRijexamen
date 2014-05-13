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
        public Keuze(String antwoord, Boolean juist)
        {
            this.antwoord = antwoord;
            this.juist = juist;

        }

        public String getAntwoord
        {
            get{
            return antwoord;
            }
        }
        public Boolean isJuist
        {
            get{
            return juist;
            }
        }





    }
}
