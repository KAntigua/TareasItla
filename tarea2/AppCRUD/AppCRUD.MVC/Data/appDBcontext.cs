using Microsoft.EntityFrameworkCore;
using AppCRUD.MVC.Models;

namespace AppCRUD.MVC.Data
{
    public class appDBcontext : DbContext
    {

        public appDBcontext(DbContextOptions<appDBcontext> options) : base(options)
        {


        }

        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Empleado>(tb =>
            {
                tb.HasKey(col => col.IdEmpleado);

                tb.Property(col => col.IdEmpleado)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.NombreCompleto).HasMaxLength(50);
                tb.Property(col => col.Correo).HasMaxLength(50);

            });

            modelBuilder.Entity<Empleado>().ToTable("Empleado");
        }
    }
}
