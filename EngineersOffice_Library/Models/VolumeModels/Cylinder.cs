using System.ComponentModel.DataAnnotations;

namespace EngineersOffice_Library.Models.VolumeModels
{
    public class Cylinder
    {
        [Required(ErrorMessage = "Введите радиус")]
        public double Radius { get; set; }

        [Required(ErrorMessage = "Введите высоту")]
        public double Height { get; set; }
        public double Volume { get; set; }
    }
}
