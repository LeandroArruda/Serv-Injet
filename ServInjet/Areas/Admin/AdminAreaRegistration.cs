﻿using System.Web.Mvc;

namespace ServInjet.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new {controller = "Inicio", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "ServInjet.Areas.Admin.Controllers" }
            );
        }
    }
}