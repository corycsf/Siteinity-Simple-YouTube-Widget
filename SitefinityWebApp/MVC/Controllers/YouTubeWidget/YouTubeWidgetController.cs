using SitefinityWebApp.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "YouTubeWidget", Title = "YouTube Widget", SectionName = "MVC")]
    public class YouTubeWidgetController : Controller
    {
        public string YouTubeVideoUrl { get; set; }
        // GET: YouTubeWidget
        public ActionResult Index()
        {
            var model = new YouTubeWidgetViewModel{ YouTubeVideoUrl = YouTubeVideoUrl};
            return View(model);
        }
    }
}