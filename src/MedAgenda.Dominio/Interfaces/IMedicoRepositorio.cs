using MedAgenda.Dominio.Modelos;

namespace MedAgenda.Dominio.Interfaces
{
    public interface IMedicoRepositorio
    {
        public List<Medico> ObterTodos();
        public Medico ObterPorId(int id);
        public void Criar(Medico medico);
        public void Atualizar(int id, Medico medico);
        public void Remover(int id);
    }
}
