using System.Web.Mvc;

namespace SS_Demo.Areas.IsisAutoRepair
{
    public class IsisAutoRepairAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "IsisAutoRepair";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "IsisAutoRepair_default",
                "IsisAutoRepair/{controller}/{action}/{id}",
                new { controller="Home", action = "Index", id = UrlParameter.Optional }, 
                new[] {"SS_Demo.Areas.IsisAutoRepair.Controllers" }
            );
        }
    }
}
