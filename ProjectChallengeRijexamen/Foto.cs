using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChallengeRijexamen
{
    class Foto
    {
        String doel;
        public Foto(String Naam)
        {
            doel = "..//..//img//" + Naam;
        }

        public String getDoel()
        {
            return doel;
        }

    }
}
