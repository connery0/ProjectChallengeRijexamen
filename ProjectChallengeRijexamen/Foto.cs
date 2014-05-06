using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChallengeRijexamen
{
    class Foto
    {
        
        String Naam;

        public Foto(String Naam)
        {
            this.Naam = Naam;
        }

        public String getDoel()
        {
            return "..\\..\\img/" + Naam;
        }
        public String getNaam()
        {
            return Naam;
        }

    }
}
