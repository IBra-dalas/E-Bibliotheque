using E_Bibliothèque.Models;
using E_Bibliothèque.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Bibliothèque.Controllers
{
    public class CreateLivreController : Controller
    {
        // GET: CreateLivre
        [HttpPost]
        public ActionResult Ajouter(Livre livre)
        {

            using (IDAL dal = new DAL())
            {
                BddContext bdd = new BddContext();
                if (!ModelState.IsValid)

                {
                    var v = dal.CreerUnLivre(livre.TitreLivre, livre.DateParition, livre.UnAuteur.IdAuteur);
                    ViewBag.Message = "Ajout effectué ";
                
                    return View(livre);
                }
                else
                {
                    return RedirectToAction("Index");
                }
                
                  
               
               
                
            }


        }
       

        [HttpGet]
        public ActionResult Index()
        {

            using (IDAL dal = new DAL())
            {
                var v = new Livre();
                return View(v);
            }


        }

        public List<Auteur> ListAuteurs = new List<Auteur>
        {
            new Auteur { IdAuteur = 1, NomAuteur = "Senghor" },
            new Auteur { IdAuteur = 2, NomAuteur = "Thierno Monenembo" },
            new Auteur { IdAuteur = 3, NomAuteur = "Victor Hugo" }
        };

        public JsonResult VerifNomLivre(string titreLivreVerif)
        {
            IDAL dal = new DAL();
            bool resultat = !dal.LivreExiste(titreLivreVerif);
            return Json(resultat, JsonRequestBehavior.AllowGet);
        }

    }
}