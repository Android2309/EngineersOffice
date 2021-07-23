using EngineersOffice_Library.Models.MetalAssortment;
using System.ComponentModel.DataAnnotations;

namespace EngineersOffice_Library.Models.TraverseModels
{
    public class TraverseCompressionModel
    {
        //балка
        public Beam beam = new Beam();

        //коэффициенты
        public double Kp { get; } = 1.1; //коэффициент перегрузки
        public double Kd { get; } = 1.1; //коэффициент динамичности
        public double m { get; } = 0.85;  //коэффициент условий работы
        public double fi_0 { get; } = 0.4; //коэффициент продольного изгиба стержня начальный
        public double fi { get; set; }  //коэффициент продольного изгиба стержня финальный
        public double mu { get; } = 1; //коэффициент привидения длины

    

        //вес груза
        [Required(ErrorMessage = "Введите вес груза")]
        [Range(1, int.MaxValue, ErrorMessage = "Некорректный вес груза")]
        public double G { get; set; }

        //предел текучести материала
        [Required(ErrorMessage = "Введите предел текучести материала")]
        [Range(1, int.MaxValue, ErrorMessage = "Некорректный предел текучести")]
        public double R { get; set; }

        //длина
        [Required(ErrorMessage = "Введите длину траверсы")]
        [Range(1, int.MaxValue, ErrorMessage = "Некорректная длина")]
        public double Length { get; set; }

        //угол наклона тяги
        [Required(ErrorMessage = "Введите угол наклона тяги")]
        [Range(1,360, ErrorMessage = "Некорректный угол наклона тяги")]
        public double Alfa { get; set; }


        //нагрузка действующая на траверсу
        public double P { get; set; }

        //изгибающий момент
        public double M { get; set; }

        //требуемый момент сопротивления поперечного сечения
        public double Wx { get; set; }

        //натяжение в канатной подвеске
        public double N { get; set; }

        //сжимающее усилие в стержне траверсы
        public double N1 { get; set; }

        //требуемая площадь поперечного сечения стержня
        public double F_tr { get; set; }

        //площадь поперечного сечения стержня
        public double F { get; set; }

        //расчетная длина стержня 
        public double Lc { get; set; }


        //радиусы инерции
        public double r_x { get; set; }
        public double r_y { get; set; }


        //предельная гибкость
        public double Flex_lim { get; } = 150;

        //гибкость стержня относительно главных плоскостей
        public double Flex_x { get; set; } //для швеллера и двутавра
        public double Flex_y { get; set; } //для швеллера и двутавра
        public double Flex { get; set; } //для стальной трубы
    }
}

