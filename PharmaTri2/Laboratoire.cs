using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTri2
{
    class Laboratoire
    {
        public Laboratoire(string LABOId, string LABOLocalisation, string LABONom)
        {
            this.LABOId = LABOId;
            this.LABOLocalisation = LABOLocalisation;
            this.LABONom = LABONom;
        }

        public string LABOId { get; set; }
        public string LABOLocalisation { get; set; }
        public string LABONom { get; set; }
    }
}
