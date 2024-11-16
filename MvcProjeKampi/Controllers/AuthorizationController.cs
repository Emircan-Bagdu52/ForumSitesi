using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AuthorizationController : Controller
    {
        AdminManager adminmanager = new AdminManager(new EfAdminDal());
        // GET: Authorization
        public ActionResult Index()
        {
            var adminvalues=adminmanager.GetAll();
            return View(adminvalues);
        }
		[Authorize(Roles = "A")]
		
		[HttpGet]
		public ActionResult Add()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Add(Admin admin)
		{
			adminmanager.Add(admin);
			return RedirectToAction("Index", "Authorization");
		}

		[HttpGet]
		public ActionResult Update(int id)
		{
			var adminValue = adminmanager.GetById(id);
			return View(adminValue);
		}
		[HttpPost]
		public ActionResult Update(Admin admin)
		{
			adminmanager.Update(admin);
			return RedirectToAction("Index");
		}
		public ActionResult Delete(int id)
		{
			var adminValue = adminmanager.GetById(id);
			adminmanager.Delete(adminValue);
			return RedirectToAction("Index");
		}
	}
}