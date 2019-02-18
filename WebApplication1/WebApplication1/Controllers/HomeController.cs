using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        Model model = new Model();
        public ActionResult Index()
        {
            var emps = model.Employees.Include("Department");
            List<Index> mymodel = new List<Index>();
            foreach(var el in emps)
            {
                mymodel.Add(new Models.Index()
                {
                    Age = el.Age,
                    DepartmentDesc = el.Department.Descriptopn,
                    DepartmentName = el.Department.Name,
                    Salary = el.Salary,
                    SurName = el.SurName,
                    Name = el.Name
                    });
            }
            return View(mymodel);
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
    }
}