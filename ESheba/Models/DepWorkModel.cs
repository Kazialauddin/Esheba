using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ESheba.Models
{
    public class Department
    {

        public int DepartmentId { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public IEnumerable<Worker> Workers { get; set; }

    }
    public enum Gender { Male, Female }
    public enum City { Dhaka, Rajshahi, Khulna, Barishal, Sylhet }
    public class Worker
    {

        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }
        [Required, StringLength(50)]

        public string Contact { get; set; }
        [Required, EnumDataType(typeof(City))]
        public City City { get; set; }
        public string Experience { get; set; }
        public int DepartmentId { get; set; }
        public IEnumerable<Department> DepartmentCollections { get; set; }


    }
    public class DepartmentDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Worker> Workers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DbInitializer());
            base.OnModelCreating(modelBuilder);
        }
    }
    public class DbInitializer : DropCreateDatabaseIfModelChanges<DepartmentDbContext>
    {
        protected override void Seed(DepartmentDbContext context)
        {
            base.Seed(context);
        }
    }
}