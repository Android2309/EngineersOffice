using System.ComponentModel.DataAnnotations;

namespace EngineersOffice_Library.Models.VolumeModels
{
    public class Cube
    {
        [Required(ErrorMessage = "Введите высоту")]
        public double Height { get; set; }
        public double Volume { get; set; }
    }
}
