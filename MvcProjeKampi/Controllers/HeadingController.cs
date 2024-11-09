﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var values = hm.GetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem>valuecategory=(from x in cm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text=x.CategoryName,
                                                   Value=x.CategoryID.ToString()
                                               }).ToList();

            List<SelectListItem> valuewriter = (from x in wm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.WriterName+" "+x.WriterSurname,
                                                      Value = x.WriterID.ToString()
                                                  }).ToList();

            ViewBag.vlc=valuecategory;
            ViewBag.vwn = valuewriter;


            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {
            heading.HeadingDate= DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(heading);
            return RedirectToAction("Index", "Heading");
        }
    }
}