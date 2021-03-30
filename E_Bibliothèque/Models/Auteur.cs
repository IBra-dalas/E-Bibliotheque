using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace E_Bibliothèque.Models
{
    [Table("Auteur")]
    public class Auteur
    {     
        [Key]
        [DisplayName("Auteur")]
        public int IdAuteur { get; set; }
        [DisplayName("Auteur")]
        public string NomAuteur { get; set; }
     
    }
}