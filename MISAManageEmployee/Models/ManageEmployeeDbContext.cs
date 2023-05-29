using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MISAManageEmployee.Models
{
    public partial class ManageEmployeeDbContext : DbContext
    {
        public ManageEmployeeDbContext()
            : base("name=ManageEmployeeDbContext")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Unit)
                .WillCascadeOnDelete(false);
        }
    }
}
