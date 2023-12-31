﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.Personnes;


namespace GESTION_ET_SUPERVISION_DU_RESTAURANT.Modèle.Lieux
{
    public class Cuisine
    {
        private static Cuisine _instance;
        static readonly object instanceLock = new object();

        public List<AEmploye> Employes { get; private set; } = new List<AEmploye>();

        private Cuisine()
        {

        }

        public static Cuisine Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (instanceLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Cuisine();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
