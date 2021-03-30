
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Bibliothèque.ViewModels
{
    public class RechercherViewModel
    {
        public string Recherche { get; set; }
        public List<Models.Livre> ListeDesLivres { get; set; }

    }
}