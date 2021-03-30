using E_Bibliothèque.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Bibliothèque.ViewModels
{
    public class CreateLivreViewModel
    {
        public class Auteur
        {
            public int IdAuteur { get; set; }
            public string NomAuteur { get; set; }
        }

        public IEnumerable<Auteur> AuteurOptionType =
            new List<Auteur>
            {
                        new Auteur { IdAuteur = 1, NomAuteur = "Senghor" },
                        new Auteur { IdAuteur = 2, NomAuteur = "Thierno Monenembo" },
                        new Auteur { IdAuteur = 3, NomAuteur = "Victor Hugo" }
            };

        [DisplayName("Auteur")]
        public string UnAuteur{get; set;}

        public bool IsSucces { get; set; }
    }
}