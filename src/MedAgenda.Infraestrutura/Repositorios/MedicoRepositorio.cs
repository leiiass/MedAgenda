using MedAgenda.Dominio.Interfaces;
using MedAgenda.Dominio.Modelos;
using MedAgenda.Infraestrutura.BancoDeDados;
using Microsoft.EntityFrameworkCore;

namespace MedAgenda.Infraestrutura.Repositorios
{
    class MedicoRepositorio : IMedicoRepositorio
    {
        private readonly Context _context;
        public MedicoRepositorio(Context context)
        {
            _context = context;
        }

        public List<Medico> ObterTodos()
        {
            return _context.Medicos.ToList();
        }
        public Medico ObterPorId(int id)
        {
            return _context.Medicos
                .SingleOrDefault(x => x.Id == id)
                 ?? throw new Exception($"Médico com id {id} não encontrado.");
        }

        public void Criar(Medico medico)
        {
            var novoMedico = _context.Medicos
                .Add(medico);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Medico medico)
        {
            var medicoAhSerAtualizado = _context.Medicos
                .Where(x => x.Id == id)
                .FirstOrDefault() 
                ?? throw new Exception($"Médico com id {id} não encontrado.");

            medicoAhSerAtualizado.Nome = medico.Nome;
            medicoAhSerAtualizado.Sobrenome = medico.Sobrenome;
            medicoAhSerAtualizado.NumeroCRM = medico.NumeroCRM;
            medicoAhSerAtualizado.EstadoCRM = medico.EstadoCRM;
            medicoAhSerAtualizado.Especialidade = medico.Especialidade;

            _context.Medicos.Entry(medicoAhSerAtualizado).State = EntityState.Modified;

            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var medicoAhSerRemovido = _context.Medicos
                .Where(x => x.Id == id)
                .FirstOrDefault()
                ?? throw new Exception($"Médico com id {id} não encontrado.");

            _context.Medicos.Remove(medicoAhSerRemovido);
            _context.SaveChanges();
        }
    }
}
