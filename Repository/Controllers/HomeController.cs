using Repository.Library.DbContext.Entities;
using Repository.Library.UnitOfWork;
using Repository.Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Repository.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //[HttpPost]
        //public async Task<JsonResult> GetAllCustomerByStaffList(int page, int pageSize, StudentSearchModal searchModal)
        //{  
        //}
    }
}