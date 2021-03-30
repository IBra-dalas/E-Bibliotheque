using E_Bibliothèque.Models;
using E_Bibliothèque.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace E_Bibliothèque.Controllers
{
    public class AccueilController : Controller
    {
        private DAL dal = new DAL();

        // GET: Accueil
        public ActionResult Afficher(AccueilViewModels accueilViewModels)
        {

            var meslivres = dal.ListeTousLesLivres();

            accueilViewModels.ListeDesLivres = meslivres.ToList();
            return View(accueilViewModels);
            /*

            Auteur auteur1 = new Auteur { IdAuteur = 1, NomAuteur = "Senghor" };
            Auteur auteur2 = new Auteur { IdAuteur = 2, NomAuteur = "Thierno Monenembo" };
            Auteur auteur3 = new Auteur { IdAuteur = 3, NomAuteur = "Victor Hugo" };

            AccueilViewModels vm = new AccueilViewModels
            {

                Message = "Bonjour Depuis le controlleur",


                ListeDesLivres = new List<Models.Livre>
                {
                     new Livre { IdLivre = 1, TitreLivre = "Diop Le Rénegat", DateParition = DateTime.Now, UnAuteur = auteur1 },
                     new Livre { IdLivre = 2, TitreLivre = "Le Cercle de l'independance", DateParition = DateTime.Now, UnAuteur = auteur2 },
                     new Livre { IdLivre = 3, TitreLivre = "Mort de rire", DateParition = DateTime.Now, UnAuteur = auteur3 },
                     new Livre { IdLivre = 4, TitreLivre = "Les vieux Marabou", DateParition = DateTime.Now, UnAuteur = auteur1 },
                     new Livre { IdLivre = 5, TitreLivre = "La terre promise", DateParition = DateTime.Now, UnAuteur = auteur3 }

                }
               


            };
           return View(vm);
           */
        }

       


    }
}