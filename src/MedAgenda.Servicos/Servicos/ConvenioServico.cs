using MedAgenda.Dominio.Interfaces;
using MedAgenda.Dominio.Modelos;

namespace MedAgenda.Servicos.Servicos
{
    public class ConvenioServico
    {
        private readonly IConvenioRepositorio _convenioRepositorio;
        public ConvenioServico(IConvenioRepositorio convenioRepositorio)
        {
            _convenioRepositorio = convenioRepositorio;
        }

        public List<Convenio> ObterTodos()
        {
            return _convenioRepositorio.ObterTodos();
        }

        public void Criar(Convenio convenio)
        {
            _convenioRepositorio.Criar(convenio);
        }

        public void Remover(int id)
        {
            _convenioRepositorio.Remover(id);
        }
    }
}
