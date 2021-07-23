using EngineersOffice_Library.Models.VolumeModels;

namespace EngineersOffice_Library.Interfaces
{
    public interface ICalculationVolume
    {
        public Ball BallVolume(Ball ball);
        public Conus ConusVolume(Conus conus);
        public Cube CubeVolume(Cube cube);
        public Cylinder CylinderVolume(Cylinder cylinder);
    }
}
