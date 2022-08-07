using DegitalContentManagerment.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DegitalContentManagerment.Data
{
    public class DataContext:IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Leturer> Leturers { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
