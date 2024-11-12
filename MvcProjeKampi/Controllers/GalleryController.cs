using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        ImageFileManager imageFileManager=new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var values = imageFileManager.GetAll();
            return View(values);
        }
    }
}