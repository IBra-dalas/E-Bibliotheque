using System.Data.Entity;

namespace E_Bibliothèque.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Livre> Livres { get; set; }
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<LouerUnLivre> Louers { get; set; }
        public DbSet<Client> Clients { get; set; }
        //public DbSet<Livre> RechercherLivre()
    }
}