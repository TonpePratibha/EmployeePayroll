using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.DBContext
{
   public class ApplicationDBcontext:DbContext
    {


        public ApplicationDBcontext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasPrecision(18, 2); // 18 total digits, 2 digits after the decimal
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
