using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
