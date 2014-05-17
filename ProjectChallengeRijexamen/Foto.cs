using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// een klasse om foto's op te slaan in het programma
// aangemaakt op: 18/04/2014
// gemaakt door: Tom Partoens

namespace ProjectChallengeRijexamen
{
    class Foto
    {        
        protected string naam;

        public Foto(string naam)
        {
            this.naam = naam;
        }

        public virtual string GetDoel()
        {
            return "..\\..\\img/" + naam;
        }
        
        public string getNaam
        {
            get{
            return naam;
            }
        }

    }
}
