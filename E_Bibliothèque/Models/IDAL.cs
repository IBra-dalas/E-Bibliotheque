using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bibliothèque.Models
{
    public interface IDAL : IDisposable
    {
        List<Livre> ListeTousLesLivres();
        List<Auteur> ListeTousLesAuteurs();
        List<Livre> ListeTousLesLivres_AuteurParID(int IdLivre);
        Livre AfficherUnLivre_ParID(int IdLivre);
        Livre CreerUnLivre(string titre, DateTime date, int auteur);
        Auteur FindAuteurById(int auteurId);
        bool LivreExiste(string titreLivre);
       object GroupBy(int id);



    }
}
