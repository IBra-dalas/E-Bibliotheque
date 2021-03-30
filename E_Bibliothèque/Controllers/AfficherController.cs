using E_Bibliothèque.Models;
using E_Bibliothèque.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Bibliothèque.Controllers
{
    public class AfficherController : Controller
    {
        // GET: Afficher
        public ActionResult Auteurs()
        {
            
            AfficherViewModels vm = new AfficherViewModels
            {
                Message = "Bonjour",

                 ListAuteurs = new List<Auteur>
                 {
                        new Auteur { IdAuteur = 1, NomAuteur = "Senghor" },
                        new Auteur { IdAuteur = 2, NomAuteur = "Thierno Monenembo" },
                        new Auteur { IdAuteur = 3, NomAuteur = "Victor Hugo" }
                 }
            };
            return View(vm);
        }

        public ActionResult Auteur(AccueilViewModels accueilViewModels)
        {

            DAL dal = new DAL();
            int id = 0;
            var LivreParIdAuteur = dal.ListeTousLesLivres_AuteurParID(id);
            accueilViewModels.ListeDesLivres = LivreParIdAuteur.ToList();

            //List<Livre> listDesLivres = dal.ListeTousLesLivres_AuteurParID(accueilViewModels.IdLivre);
            //return View(listDesLivres);
            return View(accueilViewModels);
            
        }



    }
}