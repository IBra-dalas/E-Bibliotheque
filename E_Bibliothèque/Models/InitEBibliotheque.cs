using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace E_Bibliothèque.Models
{
    public class InitEBibliotheque : DropCreateDatabaseAlways<BddContext>
    {
    
        protected override void Seed(BddContext context)
        {
            using (var conn = new SqlConnection("{connectionString}"))
            {
                conn.Open();
                Auteur auteur1 = new Auteur { IdAuteur = 1, NomAuteur = "Senghor" };
                Auteur auteur2 = new Auteur { IdAuteur = 2, NomAuteur = "Thierno Monenembo" };
                Auteur auteur3 = new Auteur { IdAuteur = 3, NomAuteur = "Victor Hugo" };


                Livre livre1 = new Livre { IdLivre = 1, TitreLivre = "Diop Le Rénegat", DateParition = DateTime.Now, UnAuteur = auteur1 };
                Livre livre2 = new Livre { IdLivre = 2, TitreLivre = "Le Cercle de l'independance", DateParition = DateTime.Now, UnAuteur = auteur2 };
                Livre livre3 = new Livre { IdLivre = 3, TitreLivre = "Mort de rire", DateParition = DateTime.Now, UnAuteur = auteur3 };
                Livre livre4 = new Livre { IdLivre = 4, TitreLivre = "Les vieux Marabou", DateParition = DateTime.Now, UnAuteur = auteur1 };
                Livre livre5 = new Livre { IdLivre = 5, TitreLivre = "La terre promise", DateParition = DateTime.Now, UnAuteur = auteur3 };

                Client client1 = new Client { Email = "mamd@gmail.com", NomClient = "Mamadou" };
                Client client2 = new Client { Email = "razor@gmail.com", NomClient = "Razor" };
                //Ajout de trois Auteurs
                context.Auteurs.Add(auteur1);
                context.Auteurs.Add(auteur2);
                context.Auteurs.Add(auteur3);
                //Ajout de Deux clients
                context.Clients.Add(client1);
                context.Clients.Add(client2);
                //Ajout de 5 livres
                context.Livres.Add(livre1);
                context.Livres.Add(livre2);
                context.Livres.Add(livre3);
                context.Livres.Add(livre4);
                context.Livres.Add(livre5);
                //Operation de location
                context.Louers.Add(new LouerUnLivre { Livres = livre1, UnClient = client1 });
                context.Louers.Add(new LouerUnLivre { Livres = livre2, UnClient = client1 });
                context.Louers.Add(new LouerUnLivre { Livres = livre3, UnClient = client1 });
                context.Louers.Add(new LouerUnLivre { Livres = livre4, UnClient = client2 });
                context.Louers.Add(new LouerUnLivre { Livres = livre5, UnClient = client2 });


                base.Seed(context);
            }
        }

      
    }
}