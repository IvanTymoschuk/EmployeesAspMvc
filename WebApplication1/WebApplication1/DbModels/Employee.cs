using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DbModels
{
    public class Employee
    {
        public int Id { get; set; }//
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Login { get; set; }//
        public string Password { get; set; }//
        public Department Department { get; set; }




    }
}