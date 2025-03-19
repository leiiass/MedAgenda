﻿using MedAgenda.Dominio.Modelos;

namespace MedAgenda.Dominio.Interfaces
{
    public interface IPacienteRepositorio
    {
       public List<Paciente> ObterTodos();
       public Paciente ObterPorId(int id);
       public void Criar(Paciente paciente);
       public void Atualizar(int id, Paciente paciente);
       public void Remover(int id);
    }
}
