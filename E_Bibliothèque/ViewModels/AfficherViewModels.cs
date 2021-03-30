using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Bibliothèque.Models;

namespace E_Bibliothèque.ViewModels
{
    public class AfficherViewModels
    {
       public string Message { get; set; }
       public List<Models.Auteur> ListAuteurs { get; set; }
       
    }
}