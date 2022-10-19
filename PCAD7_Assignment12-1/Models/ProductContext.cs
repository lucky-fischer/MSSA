using Microsoft.EntityFrameworkCore; // add this to use DbContext

namespace PCAD7_Assignment12_1.Models
{
    // this is the class that is represtents the db
    public class ProductContext : DbContext
    {
        //constructor
        public ProductContext(DbContextOptions<ProductContext> options):base(options) // we are calling the constructor of the base class which is Dbcontext. by giving it the current options<>
        {

        }

        // product table
        public DbSet<Product>? Products { get; set; }
        //dept table
        public DbSet<Department>? Departments { get; set; }

        //data seeding (creating dummy records)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // adding dummy data in department
            modelBuilder.Entity<Department>().HasData(
                new Department { DeptId = 1, DeptName = "Gi" },
                     new Department { DeptId = 2, DeptName = "Books" },
                     new Department { DeptId = 3, DeptName = "Mats" },
                     new Department { DeptId = 4, DeptName = "Supplies" }
                    );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "White Gi", DeptId = 1, Department = Dept.Gi, price = 74.99f, Description = "white BJJ uniform", imageName = "images.jpg" },
                new Product { Id = 2, Name = "BJJ Mats", DeptId = 3, Department = Dept.Mats, price = 124.99f, Description = "BJJ roll out mats", imageName = "bjjMats.jpg" }
                

                ) ;
        }
    }
}
