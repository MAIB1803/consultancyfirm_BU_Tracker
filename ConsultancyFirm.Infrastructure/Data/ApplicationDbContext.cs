using ConsultancyFirm.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ConsultancyFirm.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Partner> Partners { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<BusinessTracker> BusinessTrackers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
