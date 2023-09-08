using System.Web.Mvc;

namespace Quan_Ly_Tour_Du_Lich.Areas.Admin
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
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Quan_Ly_Tour_Du_Lich.Areas.Admin.Controllers" }
            );
        }
    }
}