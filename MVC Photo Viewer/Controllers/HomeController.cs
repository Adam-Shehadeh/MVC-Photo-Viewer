//Author:     Adam Shehadeh
//Date:       6/7/2018
//Desc:       MVC photo viewer taking images from a source, converting them into a byte string, and sending them as array to view.
//            The view then allows us to see these photos.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC_Photo_Viewer.Controllers
{
    public class HomeController : Controller
    {
        List<string> ImageTitleList = new List<string>() {
                "1074.jpg",
                "1111.jpg",
                "B95.png",
                "_AFW.jpg"
            };
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.ImageTitleList = ImageTitleList;
            return View();
        }
        public JsonResult GetImageData(int index) {
            return Json(PhotoService.getPhotoData(ImageTitleList[index]), JsonRequestBehavior.AllowGet);
        }
        public JsonResult TestServer(string d1) {
            return Json(d1 + " and now from server.", JsonRequestBehavior.AllowGet);
        }
    }
}