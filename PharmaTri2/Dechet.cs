﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaTri2
{
    class Dechet
    {
        public Dechet(int DECHETId, string DECHETLibelle, string DECHETComposition, string DECHETDateEntree, string DECHETDateSortie)
        {
            this.DECHETId = DECHETId;
            this.DECHETLibelle = DECHETLibelle;
            this.DECHETComposition = DECHETComposition;
            this.DECHETDateEntree = DECHETDateEntree;
            this.DECHETDateSortie = DECHETDateSortie;
        }

        public int DECHETId { get; set; }
        public string DECHETLibelle { get; set; }
        public string DECHETComposition { get; set; }

        public string DECHETDateEntree { get; set; }
        public string DECHETDateSortie { get; set; }
    }
}
