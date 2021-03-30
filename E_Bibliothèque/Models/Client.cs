using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace E_Bibliothèque.Models
{
    [Table("Client")]
    public class Client
    {

        public string NomClient { get; set; }
        [Key]
        public string Email { get; set; }
    }
}