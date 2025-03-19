namespace MedAgenda.Dominio.Modelos
{
    class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Convenio { get; set; }
    }
}
