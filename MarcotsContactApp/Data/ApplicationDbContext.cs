using System;
using System.Collections.Generic;
using System.Text;
using MarcotsContactApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MarcotsContactApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> Contact { get; set; }
        public DbSet<Days> Days { get; set; }
        public DbSet<Months> Months { get; set; }
        public DbSet<MarStatus> MarStatus { get; set; }
        public DbSet<Adddress> Address { get; set; }
        public DbSet<FamAddress> FamAddress { get; set; }      

    }
}
