using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChallengeRijexamen
{
    class Foto
    {
        
        string naam;

        public Foto(string naam)
        {
            this.naam = naam;
        }

        public string getDoel()
        {
            return "..\\..\\img/" + naam;
        }
        public string getDoelVerkeersbord()
        {
            return "..\\..\\img\\Verkeersborden\\" + naam;
        }
        public string getNaam
        {
            get{
            return naam;
            }
        }

    }
}
