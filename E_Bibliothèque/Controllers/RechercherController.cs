using E_Bibliothèque.Models;
using E_Bibliothèque.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Bibliothèque.Controllers
{
    public class RechercherController : Controller
    {
        private DAL dal = new DAL();
        // GET: Rechercher
        //public ActionResult Livre(RechercherController rechercheViewModel)
        //{

        //    if (!string.IsNullOrWhiteSpace(rechercheViewModel.Recherche))
        //    {
        //        rechercheViewModel.ListeDesLivres = dal.ListeTousLesLivres().Where(r =>
        //        r.TitreLivre.IndexOf(rechercheViewModel.Loup, StringComparison.CurrentCultureIgnoreCase) >= 0).ToList();
        //        rechercheViewModel.ListeDesLivres = dal.ListeTousLesLivres().Where(v =>
        //        v.UnAuteur.NomAuteur.IndexOf(rechercheViewModel.Loup, StringComparison.CurrentCultureIgnoreCase) >= 0).ToList();
        //    }
        //    else
        //    {
        //        rechercheViewModel.ListeDesLivres = new List<Livre>();

        //    }
        //    return View(rechercheViewModel);
        //}

        public ActionResult Livre(RechercherViewModel rechercherViewModel)
        {  
            if (!string.IsNullOrWhiteSpace(rechercherViewModel.Recherche))
            {
                var meslivres = dal.ListeTousLesLivres();

                rechercherViewModel.ListeDesLivres = meslivres.FindAll(livre => livre.TitreLivre.IndexOf(rechercherViewModel.Recherche, StringComparison.CurrentCultureIgnoreCase) >= 0);

                if (!rechercherViewModel.ListeDesLivres.Any())
                    rechercherViewModel.ListeDesLivres = meslivres.FindAll(livre => livre.UnAuteur.NomAuteur.IndexOf(rechercherViewModel.Recherche, StringComparison.CurrentCultureIgnoreCase) >= 0);

                //rechercherViewModel.ListeDesLivres = meslivres.Where(livre =>
                //livre.UnAuteur.NomAuteur.Contains(rechercherViewModel.Recherche)).ToList();

                //rechercherViewModel.ListeDesLivres = meslivres.Where(livre =>
                //livre.UnAuteur.NomAuteur.IndexOf(rechercherViewModel.Recherche, StringComparison.CurrentCultureIgnoreCase) >= 0).ToList();
            }
            else
            {
                rechercherViewModel.ListeDesLivres = new List<Livre>();
            }
            return View(rechercherViewModel);
        }
    }
}