using System.Web.Mvc;

namespace CarManager.Areas.CarList
{
    public class CarAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Car";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Car_default",
                "Car/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}