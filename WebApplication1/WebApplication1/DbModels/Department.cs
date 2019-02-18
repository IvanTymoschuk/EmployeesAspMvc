using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DbModels
{
    public class Department
    {
        public Department()
       {
            Employees = new List<Employee>();
       }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descriptopn { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}