using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class AddEmp
    {
        public AddEmp()
        {
            deps = new List<SelectListItem>();
        }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int Salary { get; set; }
        public string DepName { get; set; }
        public List<SelectListItem> deps { get; set; }

    }
}