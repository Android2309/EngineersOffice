using System.ComponentModel.DataAnnotations;

namespace EngineersOffice_Library.Models.VolumeModels
{
    public class Ball
    {
        [Required(ErrorMessage = "Введите радиус")]
        public double Radius { get; set; }
        public double Volume { get; set; }
    }
}
