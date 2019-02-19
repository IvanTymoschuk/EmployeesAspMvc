namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using WebApplication1.DbModels;

    public class Model : DbContext
    {
        // Your context has been configured to use a 'Model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WebApplication1.Model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model' 
        // connection string in the application configuration file.
        public Model()
            : base("name=Model")
        {
            Database.SetInitializer(new ModelDBInitializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

    }
    public class ModelDBInitializer : DropCreateDatabaseIfModelChanges<Model>
    {
        protected override void Seed(Model context)
        {
           var emps = new List<Employee>();
            var dep = new Department { Name = "Water Department", Descriptopn = "Specialized on provide water to all factory points" };
            emps.Add(new Employee() { Name = "Michael", SurName = "Baumer", Department = dep, Age = 45, Login = "qwe@a.a", Password = "12345678", Salary = 25000 });
            emps.Add(new Employee() { Name = "Maryna", SurName = "Pavlova", Department = dep, Age = 25, Login = "qee@a.a", Password = "12345678", Salary = 13000 });


            context.Employees.AddRange(emps);

            context.SaveChanges();
        }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}