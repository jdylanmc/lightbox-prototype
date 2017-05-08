using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lightbox.Web.Areas.lightbox.Models;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;

namespace lightbox.Web.Areas.lightbox.Controllers
{
    public class LightboxController : SitecoreController
    {
        public ActionResult Lightbox()
        {
            var model = new LightboxModel();
            model.Initialize(RenderingContext.Current.Rendering);
            return this.PartialView(model);
        }
    }
}