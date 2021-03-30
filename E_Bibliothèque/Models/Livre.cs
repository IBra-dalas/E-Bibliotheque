using E_Bibliothèque.Models.ViewModels;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Bibliothèque.Models
{
    [Table("Livre")]
    public class Livre
    {
        [Key]
        public int IdLivre { get; set; }

        [AuMoinsDeuxDesAttribut(param1 = "TitreLivre", param2 ="DateParition", ErrorMessage = "Veillez remplir les champs obligatoire")]
        [Remote("VerifNomLivre", "CreateLivre", ErrorMessage="Ce livre existe déjà dans la base de donnée")]
        [Display(Name ="Titre :")]
        public string TitreLivre { get; set; }
        [AuMoinsDeuxDesAttribut(param1 = "TitreLivre", param2 = "DateParition", ErrorMessage = "Veillez remplir les champs obligatoire")]
        [Display(Name = "Date Parition :")]
        public DateTime DateParition { get; set; }
     //  [ForeignKey("IdAuteur")]
        [DisplayName("Auteur :")]
      public virtual Auteur UnAuteur { get; set; }

        public IEnumerable<Auteur> AuteurOptionType = new List<Auteur>
        {
            new Auteur { IdAuteur = 1, NomAuteur = "Senghor" },
            new Auteur { IdAuteur = 2, NomAuteur = "Thierno Monenembo" },
            new Auteur { IdAuteur = 3, NomAuteur = "Victor Hugo" }
        };



        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    //if(string.IsNullOrWhiteSpace(TitreLivre)) yield return new ValidationResult("Veillez entrer le titre et la date de parition", new [] { "" }){ }
        //}





    }
}