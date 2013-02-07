using System.Web.Mvc;

namespace SS_Demo.Areas.IsisPrinting
{
    public class IsisPrintingAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "IsisPrinting";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "IsisPrinting_default",
                "IsisPrinting/{controller}/{action}/{id}",
                new { controller="Home", action = "Index", id = UrlParameter.Optional }, 
                new[] {"SS_Demo.Areas.IsisPrinting.Controllers" }
            );
        }
    }
}
