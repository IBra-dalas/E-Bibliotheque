using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace E_Bibliothèque.Models
{
    [Table("LouerUnLivre")]
    public class LouerUnLivre
    {
        [Key]
        public int IdLocation { get; set; }
        public virtual Livre Livres { get; set; } 
        public virtual Client UnClient { get; set; }
    }
}