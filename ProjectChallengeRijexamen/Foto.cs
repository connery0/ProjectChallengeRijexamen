using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChallengeRijexamen
{
    class Foto
    {
        
        string Naam;

        public Foto(string Naam)
        {
            this.Naam = Naam;
        }

        public string getDoel()
        {
            return "..\\..\\img/" + Naam;
        }
        public string getDoelVerkeersbord()
        {
            return "..\\..\\img\\Verkeersborden\\" + Naam;
        }
        public string getNaam()
        {
            return Naam;
        }

    }
}
