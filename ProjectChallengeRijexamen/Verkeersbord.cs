//Drag en Drop
//Author: Stef Janssens
//Datum: 6/05/2014
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChallengeRijexamen
{
    class Verkeersbord : Foto, IBeantwoord
    {
        private string uitleg;
        private Boolean beantwoord;

        public Verkeersbord(string uitleg, string foto): base(foto){
            this.uitleg = uitleg;
            beantwoord = false;
            
        }

        public override string GetDoel()
        {
            return "..\\..\\img\\Verkeersborden\\" + naam;
        }

        public bool Beantwoord
        {
            get
            {
                return beantwoord;
            }
            set
            {
                beantwoord = value;
            }  
        }

        public string Uitleg
        {
            get
            {
                return uitleg;
            }
        }
    }
}
