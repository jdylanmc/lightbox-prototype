using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Score.UI.Data.RenderingParameters;
using Score.UI.Web.Areas.ScoreUI.Models;

namespace lightbox.Web.Areas.lightbox.Models
{
    public class LightboxModel : RenderingModelBase<BaseComponentParameters>
    {
        public LightboxModel() : base("score-lightbox")
        {
            
        }
    }
}