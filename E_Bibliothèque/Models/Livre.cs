using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Bibliothèque.Models
{
    public class Livre
    {
        public int IdLivre { get; set; }
        public string TitreLivre { get; set; }
        public DateTime DateParition { get; set; }

        public List<Auteur> UnAuteur { get; set; }
       
        
    }
}