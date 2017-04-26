using HTTP5203_FinalProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace HTTP5203_FinalProject.Controllers
{
    public class HomeController : Controller
    {    
        [HttpGet]
        public ActionResult Index()
        {
            //XMLReader myXmlReader = new XMLReader();
            //var lstClosures = myXmlReader.getListOfRoadClosures().Where(c => c.District == "Etobicoke York");
            //return View(lstClosures.ToList());

            ViewBag.RoadblockDistance = ManageRoadblocks.RoadblockDistance;
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public JsonResult AllRoadBlocks()
        {
            XMLReader myXmlReader = new XMLReader();
            var lstAllClosures = myXmlReader.getListOfRoadClosures().ToList();
            return Json(lstAllClosures, JsonRequestBehavior.AllowGet);
        }
    }
}