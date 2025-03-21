using FluentValidation;
using MedAgenda.Dominio.Modelos;

namespace MedAgenda.Dominio.Validadores
{
    public class PacienteValidador : AbstractValidator<Paciente>
    {
        public PacienteValidador()
        {
            RuleFor(nome => nome.Nome).NotEmpty().NotNull().WithMessage("O nome do paciente é obrigatório.");
            RuleFor(sobrenome => sobrenome.Sobrenome).NotEmpty().NotNull().WithMessage("O sobrenome do paciente é obrigatório.");
            RuleFor(dataNasc => dataNasc.DataNascimento).NotEmpty().NotNull().WithMessage("A data de nascimento do paciente é obrigatória.");
            RuleFor(convenio => convenio.Convenio).NotEmpty().NotNull().WithMessage("O convenio do paciente é obrigatório.");
        }
    }
}
