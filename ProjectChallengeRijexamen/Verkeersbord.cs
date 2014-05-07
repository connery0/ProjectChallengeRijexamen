using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChallengeRijexamen
{
    class Verkeersbord :Foto
    {
        private string uitleg;
        private Boolean beantwoord;

        public Verkeersbord(string uitleg, string foto): base(foto){
            this.uitleg = uitleg;
            beantwoord = false;
            
        }
        public Boolean GetSetBeantwoord
        {
            get
            {
                return beantwoord;
            }
            set{
                beantwoord = false;
            }         
        }
        public string deUitleg
        {
            get
            {
                return uitleg;
            }
        }
       
        
    }
}
