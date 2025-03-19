using MedAgenda.Dominio.Modelos;

namespace MedAgenda.Dominio.Interfaces
{
    public interface IConvenioRepositorio
    {
        List<Convenio> ObterTodos();
        void Criar(Convenio convenio);
        void Remover(int id);
    }
}
