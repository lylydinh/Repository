using Repository.Common.Items;
using Repository.Library.DbContext.Entities;
using Repository.Library.UnitOfWork;
using Repository.Library.ViewModels;
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

        /// <summary>
        /// Lay ra danh sach hoc sinh
        /// </summary>
        /// <returns></returns>

        public async  Task<ActionResult> ListAll(ModelView<Student,string> model)
        {

            long totalRecord;
            model.PageInfo.PageSize = 2;
            model.Items = await UnitOfWork.StudentRepo.FindAsync(out totalRecord, null, null,
                model.PageInfo.CurrentPage, model.PageInfo.PageSize);

            model.PageInfo.TotalRecord = (int)totalRecord;
            model.PageInfo.Url = Url.Action("Index", "Home");
            
            return View(model); 
        }
    }
}