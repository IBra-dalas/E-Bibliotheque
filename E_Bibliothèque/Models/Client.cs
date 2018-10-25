using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Bibliothèque.Models
{
    public class Client
    {

        public string NomClient { get; set; }
        [Key]
        public string Email { get; set; }
    }
}