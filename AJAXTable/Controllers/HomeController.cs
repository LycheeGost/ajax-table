using AJAXTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace AJAXTable.Controllers
{
    public class HomeController : Controller
    {
        List<EmployeeModel> listEmployee = new List<EmployeeModel>() {
            new EmployeeModel()
            {
                ID = 1,
                Name = "Nguyen Van A",
                Salary = 2000000,
                Status = true
            },
            new EmployeeModel()
            {
                ID = 2,
                Name = "Nguyen Van B",
                Salary = 3000000,
                Status = true
            },
            new EmployeeModel()
            {
                ID = 3,
                Name = "Nguyen Van C",
                Salary = 5000000,
                Status = true
            },
        };

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult LoadData()
        {
            return Json(new
            {
                data = listEmployee,
                status = true
            }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Update(string model)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            EmployeeModel employee = serializer.Deserialize<EmployeeModel>(model);

            //save db
            var entity = listEmployee.Single(x => x.ID == employee.ID);
            entity.Salary = employee.Salary;
            return Json(new
            {
                status = true
            });
        }
    }
}