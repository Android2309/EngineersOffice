using EngineersOffice_Library.Models.MetalAssortment;
using System.ComponentModel.DataAnnotations;

namespace EngineersOffice_Library.Models.TraverseModels
{
    public class TraverseBendingModel
    {
        //балка
        public Beam beam = new Beam();

        //коэффициенты
        public double Kp { get; } = 1.1; //коэффициент перегрузки
        public double Kd { get; } = 1.1; //коэффициент динамичности
        public double m { get; } = 0.85;  //коэффициент условий работы


        //вес груза
        [Required(ErrorMessage = "Введите вес груза")]
        [Range(1, int.MaxValue, ErrorMessage = "Некорректный вес груза")]
        public double G { get; set; }

        //длина
        [Required(ErrorMessage = "Введите длину траверсы")]
        [Range(1, int.MaxValue, ErrorMessage = "Некорректная длина")]
        public double Length { get; set; }


        //предел текучести материала
        [Required(ErrorMessage = "Введите предел текучести материала")]
        [Range(1, int.MaxValue, ErrorMessage = "Некорректный предел текучести")]
        public double R { get; set; }

        //нагрузка действующая на траверсу
        public double P { get; set; }

        //изгибающий момент
        public double M { get; set; }

        //требуемый момент сопротивления поперечного сечения
        public double Wx { get; set; }
    }
}
