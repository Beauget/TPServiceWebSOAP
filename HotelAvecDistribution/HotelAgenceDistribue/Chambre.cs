﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HotelAgenceDistribue
{
    public class Chambre
    {
        public int numChambre;
        public int nbLits;


        public Chambre()
        {

        }

        public Chambre(int num, int lits)
        {
            this.numChambre = num;
            this.nbLits = lits;
        }


        public override string ToString()
        {
            return "Numéro : " + this.numChambre + " | " + "Nombre de lits : " + this.nbLits;
        }
    }
}
