using dotnetapp.Models;
using System;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;



public class ApplicationDbContext : DbContext
    {
public ApplicationDbContext()
        {
        }  
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Complaint> Complaints { get; set; }
        public virtual DbSet<CustomerServiceRepresentive> CustomerServiceRepresentive { get; set; }
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123;server=localhost;Database=FrenchTutionDB;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
            }
        }
        // Write your ApplicationDbContext here...
    }