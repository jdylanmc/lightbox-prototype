using System.Web.Mvc;

namespace lightbox.Web.Areas.lightbox
{
    public class lightboxAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "lightbox";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            // Register your MVC routes in here
        }
    }
}
