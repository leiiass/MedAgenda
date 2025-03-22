using MedAgenda.Dominio.Interfaces;
using MedAgenda.Dominio.Modelos;
using MedAgenda.Infraestrutura.BancoDeDados;
using Microsoft.EntityFrameworkCore;

namespace MedAgenda.Infraestrutura.Repositorios
{
    public class PacienteRepositorio : IPacienteRepositorio
    {
        private readonly Context _context;
        public PacienteRepositorio(Context context)
        {
            _context = context;
        }

        public List<Paciente> ObterTodos()
        {
            return _context.Pacientes.ToList();
        }

        public Paciente ObterPorId(int id)
        {
            return _context.Pacientes
                .SingleOrDefault(x => x.Id == id) 
                ?? throw new Exception($"Paciente com id {id} não encontrado.");
        }

        public void Criar(Paciente paciente)
        {
            var novoPaciente = _context.Pacientes.Add(paciente);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Paciente paciente)
        {
            var pacienteAhSerAtualizado = _context.Pacientes
                .Where(x => x.Id == id)
                .FirstOrDefault() 
                ?? throw new Exception($"Paciente com id {id} não encontrado.");

            pacienteAhSerAtualizado.Nome = paciente.Nome;
            pacienteAhSerAtualizado.Sobrenome = paciente.Sobrenome;
            pacienteAhSerAtualizado.DataNascimento = paciente.DataNascimento;
            pacienteAhSerAtualizado.Convenio = paciente.Convenio;

            _context.Pacientes.Entry(pacienteAhSerAtualizado).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var pacienteAhSerRemovido = _context.Pacientes
                .Where(x => x.Id == id)
                .FirstOrDefault() 
                ?? throw new Exception($"Paciente não encontrado com id {id}.");

            _context.Pacientes.Remove(pacienteAhSerRemovido);
            _context.SaveChanges();
        }
    }
}
