using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChallengeRijexamen
{
    class Verkeersbord :Foto
    {
        
        private Foto foto;
        private string uitleg;
        private Boolean gekozen = false;
        public Verkeersbord(string uitleg, string foto): base(foto){
            this.uitleg = uitleg;
            
        }
        public Boolean kiezen
        {
            set{
                gekozen = false;
            }

            
        }
       
        
    }
}
