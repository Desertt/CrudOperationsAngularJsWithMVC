using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrudOperationsAngularJsWithMVC.Models;

namespace CrudOperationsAngularJsWithMVC.Controllers
{
    public class HomeController : Controller
    {
        database_Access_Layer.db dblayer = new database_Access_Layer.db();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Show_data()
        {
            return View();
        }
        public ActionResult update_data()
        {
            return View();
        }

        public JsonResult Add_record(register rs)
        {
            string res = string.Empty;
            try
            {
                
                dblayer.Add_record(rs);
                res = "Inserted";
            }
            catch (System.Exception)
            {
                res = "failed";
                
            }
            return Json(res, JsonRequestBehavior.AllowGet);
            
        }



    }
}