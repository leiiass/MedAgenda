using System.ComponentModel.DataAnnotations;

namespace MedAgenda.Dominio.Modelos
{
    public enum Especialidade
    {
        [Display(Name = "Cardiologista")]
        Cardiologista = 0,

        [Display(Name = "Clínico Geral")]
        ClinicoGeral = 1,

        [Display(Name = "Dermatologista")]
        Dermatologista = 2,

        [Display(Name = "Endocrinologista")]
        Endocrinologista = 3,

        [Display(Name = "Gastroenterologista")]
        Gastroenterologista = 4,

        [Display(Name = "Ginecologista")]
        Ginecologista = 5,

        [Display(Name = "Neurologista")]
        Neurologista = 6,

        [Display(Name = "Oftalmologista")]
        Oftalmologista = 7,

        [Display(Name = "Ortopedista")]
        Ortopedista = 8,

        [Display(Name = "Otorrinolaringologista")]
        Otorrinolaringologista = 9,

        [Display(Name = "Pediatra")]
        Pediatra = 10,

        [Display(Name = "Psiquiatra")]
        Psiquiatra = 11,

        [Display(Name = "Urologista")]
        Urologista = 12,

        [Display(Name = "Oncologista")]
        Oncologista = 13,

        [Display(Name = "Hematologista")]
        Hematologista = 14,

        [Display(Name = "Reumatologista")]
        Reumatologista = 15,

        [Display(Name = "Nefrologista")]
        Nefrologista = 16,

        [Display(Name = "Infectologista")]
        Infectologista = 17,

        [Display(Name = "Mastologista")]
        Mastologista = 18,

        [Display(Name = "Anestesiologista")]
        Anestesiologista = 19
    }
}
