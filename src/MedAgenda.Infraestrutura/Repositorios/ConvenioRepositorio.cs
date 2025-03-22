using MedAgenda.Dominio.Interfaces;
using MedAgenda.Dominio.Modelos;
using MedAgenda.Infraestrutura.BancoDeDados;

namespace MedAgenda.Infraestrutura.Repositorios
{
    class ConvenioRepositorio : IConvenioRepositorio
    {
        private readonly Context _context;
        public ConvenioRepositorio(Context context)
        {
            _context = context;
        }

        public List<Convenio> ObterTodos()
        {
            return _context.Convenios.ToList();
        }

        public void Criar(Convenio convenio)
        {
            var novoConvenio = _context.Convenios.Add(convenio);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var convenioAhSerRemovido = _context.Convenios
                .Where(x => x.Id == id)
                .FirstOrDefault();

            if(convenioAhSerRemovido is null)
            {
                throw new Exception($"Convenio não encontrado com id {id}.");
            }

            _context.Convenios.Remove(convenioAhSerRemovido);
            _context.SaveChanges();
        }
    }
}
