using MedAgenda.Dominio.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MedAgenda.Infraestrutura.BancoDeDados
{
    public class Context : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
