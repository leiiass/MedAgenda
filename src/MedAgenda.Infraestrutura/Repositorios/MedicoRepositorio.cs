using MedAgenda.Dominio.Interfaces;
using MedAgenda.Dominio.Modelos;

namespace MedAgenda.Infraestrutura.Repositorios
{
    class MedicoRepositorio : IMedicoRepositorio
    {

        public List<Medico> ObterTodos()
        {
            throw new NotImplementedException();
        }
        public Medico ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Criar(Medico medico)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(int id, Medico medico)
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
