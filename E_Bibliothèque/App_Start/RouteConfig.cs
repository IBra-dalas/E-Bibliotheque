using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace E_Bibliothèque
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Accueil", action = "Afficher", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "",
                url: "{controller}/{action}/{id}",
                 defaults: new { controller = "Rechercher", action = "Livre", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "",
                url: "{controller}/{action}/{id}",
                 defaults: new { controller = "CreateLivre", action = "Ajouter", id = UrlParameter.Optional }
            );
        }

    }

  
}
