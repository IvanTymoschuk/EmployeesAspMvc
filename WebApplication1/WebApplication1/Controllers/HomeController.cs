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
        [HttpPost]
        public ActionResult AddEmp(AddEmp emp)
        {
            model.Employees.Add(new DbModels.Employee()
            {
                Name = emp.Name,
                SurName = emp.SurName,
                Login = emp.Email,
                Password = emp.Password,
                Salary = emp.Salary,
                Department = model.Departments.Where(x => x.Name == emp.DepName).Single(),
                Age = emp.Age,
               
            });
            emp.deps.AddRange(model.Departments.Select(d => new SelectListItem { Text = d.Name, Value = d.Name }).ToArray());


            model.SaveChanges();
            return View();
        }

        public ActionResult AddEmp()
        {
            AddEmp emp = new AddEmp();
            foreach(var el in model.Departments)
            {
                emp.deps.Add(new SelectListItem() { Text = el.Name, Value = el.Name });
            }

            return View(emp);
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