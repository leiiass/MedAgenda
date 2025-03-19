using System.ComponentModel.DataAnnotations.Schema;

namespace MedAgenda.Dominio.Modelos
{
    class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int NumeroCRM { get; set; }
        public string EstadoCRM { get; set; }
        [NotMapped]
        public string CRM => $"CRM/{EstadoCRM} {NumeroCRM}";
        public Especialidade Especialidade { get; set; }
    }
}
