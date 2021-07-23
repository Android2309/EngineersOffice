using System.ComponentModel.DataAnnotations;

namespace EngineersOffice_Library.Models
{
    public class SteelGrade
    {
        public int Id { get; set; }


        [Display(Name = "Марка стали")]
        [Required]
        public string Grade { get; set; }

        //предел текучести
        [Display(Name = "σ_02(Мпа)")]
        public int YieldStress { get; set; }

        //предел прочности
        [Display(Name = "σ_в(Мпа)")]
        public int TensileStrength { get; set; }

        //относительное удлинение
        [Display(Name = "δ(%)")]
        public int Elongation { get; set; }

        //относительное сужение
        [Display(Name = "Ψ(%)")]
        public int Contraction { get; set; }

        //твердость HB
        public int HB { get; set; }
    }
}
