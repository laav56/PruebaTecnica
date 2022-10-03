using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ControlDePersonal.Models;

namespace ControlDePersonal.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<ControlDePersonal.Models.Genero>? Genero { get; set; }
    public DbSet<ControlDePersonal.Models.Persona>? Persona { get; set; }
    public DbSet<ControlDePersonal.Models.Departamento>? Departamento { get; set; }
    public DbSet<ControlDePersonal.Models.Puesto>? Puesto { get; set; }
    public DbSet<ControlDePersonal.Models.Empleado>? Empleado { get; set; }
}
