﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.Personnes.Salle
{
    public class Client : Personne
    {
        public int Id { get; set; }
        public Caractere Caractere { get; set; }
        public Gouts Gout { get; set; }
        bool Reservation { get; set; } = false;

        public Client()
        {

        }

        public override string ToString()
        {
            string nL = Environment.NewLine;
            return "Caractère : " + Caractere + nL + "Gout : " + Gout + nL + "Reservation : " + Reservation + nL;
        }
    }
}
