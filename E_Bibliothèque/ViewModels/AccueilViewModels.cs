using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace E_Bibliothèque.ViewModels
{
    public class AccueilViewModels
    {
        public int IdLivre { get; set; }
        public string Email { get; set; }
        public string Nom { get; set; }
        public string Message { get; set; }
        public List<Models.Auteur> ListAuteurs { get; set; }
        public string Loup { get; set; }
        public List<Models.Livre> ListeDesLivres { get; set; }
        public List<Models.Client> ListClients { get; set; }
        public List<Models.LouerUnLivre> LouerUnLivres { get; set; }

       


    }
}