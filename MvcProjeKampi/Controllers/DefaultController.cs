using System.Web.Mvc;
using Business.Concrete;
using BusinessLayer.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccessLayer.EntityFramework;

namespace MvcProjectCamp.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private HeadingManager _headingManager = new HeadingManager(new EfHeadingDal());
        private ContentManager _contentManager = new ContentManager(new EfContentDal());
        public PartialViewResult Index(int id=0)
        {
            var contentList = _contentManager.GetListByHeadingId(id);
            return PartialView(contentList);
        }
        public ActionResult Headings()
        {
            var headingList = _headingManager.GetList();
            return View(headingList);
        }
    }
}