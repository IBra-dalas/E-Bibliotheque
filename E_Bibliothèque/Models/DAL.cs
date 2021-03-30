using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Bibliothèque.Models;

namespace E_Bibliothèque.Models
{
    public class DAL : IDAL
    {
        private Donnees bddTest;

        private BddContext bdd;
         public  DAL()
        {
            bddTest = new Donnees();
            bdd = new BddContext();
        }
        public Livre AfficherUnLivre_ParID(int id)
        {
            return bdd.Livres.FirstOrDefault(u => u.IdLivre == id);
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public List<Auteur> ListeTousLesAuteurs()
        {
            return bdd.Auteurs.ToList();
        }

        public List<Livre> ListeTousLesLivres()
        {
            return bdd.Livres.ToList();
        }

        public List<Livre> ListeTousLesLivres_AuteurParID(int id)
        {
            List<Auteur> auteurs = ListeTousLesAuteurs().ToList();
            List<Livre> livres = new List<Livre>().ToList();
            Livre MonAuteur = bdd.Livres.First(s => s.UnAuteur.IdAuteur == id);
           // int idAuteur = 0;           //  = grouping;
            //Auteur auteur = auteurs.First(r => r.IdAuteur == idAuteur);
            //    livres.Add(new Livre { TitreLivre = MonAuteur.UnAuteur.IdAuteur });

            
            return livres;
        }

        public Auteur FindAuteurById(int auteurId)
        {
            Auteur result = bdd.Auteurs.Where(a => a.IdAuteur == auteurId).FirstOrDefault();
            return result;
        }

        public Livre FindLivreByTitle(string _titreLivre)
        {
            Livre result = bdd.Livres.Where(a => a.TitreLivre == _titreLivre).FirstOrDefault();
            return result;
        }

      public Livre CreerUnLivre(string titre, DateTime date, int auteurId)
      {
            //Livre LeTitre = bdd.Livres.Where(m => m.TitreLivre == titre).FirstOrDefault();

            //if(titre != LeTitre.TitreLivre)
            //{

            try
            {
                
                var auteur = FindAuteurById(auteurId);
                Livre livre = new Livre { TitreLivre = titre, DateParition = date, UnAuteur = auteur };
                bdd.Livres.Add(livre);
                bdd.SaveChanges();
                
                return livre;
            }
            catch (Exception e)
            {

                throw e; 
            }
                
            
      }
        object IDAL.GroupBy(int id)
        {
           return id.ToString();
        }

        public bool LivreExiste(string titreLivre)
        {
            bool etat = false;
            if (titreLivre.Contains(titreLivre))
            
               etat = true;
            
            return etat;
                

        }
        
    }
}