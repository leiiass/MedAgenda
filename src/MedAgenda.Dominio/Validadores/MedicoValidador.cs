using FluentValidation;
using MedAgenda.Dominio.Modelos;

namespace MedAgenda.Dominio.Validadores
{
    public class MedicoValidador : AbstractValidator<Medico>
    {
        public MedicoValidador()
        {
            RuleFor(nome => nome.Nome).NotEmpty().NotNull().WithMessage("Nome do médico é obrigatório.");
            RuleFor(sobrenome => sobrenome.Sobrenome).NotEmpty().NotNull().WithMessage("O Sobrenome do médico é obrigatório.");
            RuleFor(numerocrm => numerocrm.NumeroCRM).NotEmpty().NotNull().WithMessage("O número do CRM é obrigatório. ");
            RuleFor(estadocrm => estadocrm.EstadoCRM).NotEmpty().NotNull().WithMessage("O estado do CRM é obrigatório.");
            RuleFor(especialidade => especialidade.Especialidade).NotNull().NotEmpty().WithMessage("A especialidade é obrigatória.");
        }
    }
}
