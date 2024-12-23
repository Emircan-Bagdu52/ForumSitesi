﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        ContactValidator cv=new ContactValidator();
        // GET: Contact
        public ActionResult Index()
        {
            var contactValues=contactManager.GetList();
            return View(contactValues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var cantactvalues=contactManager.GetById(id);
            return View(cantactvalues);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}