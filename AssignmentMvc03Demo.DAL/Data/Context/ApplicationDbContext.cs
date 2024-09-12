using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMvc03Demo.DAL.Data.Context
{
    internal class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseSqlServer("Server=.;Database=MvcCompany;Trusted_Connection=True;Encrypt:False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
                => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
