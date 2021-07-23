using EngineersOffice_Library.Interfaces;
using EngineersOffice_Library.Models.VolumeModels;
using System;

namespace EngineersOffice_Library.Services
{
    public class VolumeCalculator : ICalculationVolume
    {
        //объем шара
        public Ball BallVolume(Ball ball)
        {
            ball.Volume = (Math.PI * Math.Pow(ball.Radius, 2)) / 2;
            ball.Volume = Math.Round(ball.Volume, 2);

            return ball;
        }

        //объем конуса
        public Conus ConusVolume(Conus conus)
        {
            conus.Volume = (Math.PI * Math.Pow(conus.Radius, 2) * conus.Height) / 3;
            conus.Volume = Math.Round(conus.Volume, 2);

            return conus;
        }

        //объем куба
        public Cube CubeVolume(Cube cube)
        {
            cube.Volume = Math.Pow(cube.Height, 3);
            cube.Volume = Math.Round(cube.Volume, 2);

            return cube;
        }

        //объем цилиндра
        public Cylinder CylinderVolume(Cylinder cylinder)
        {
            cylinder.Volume = Math.PI * Math.Pow(cylinder.Radius, 2) * cylinder.Height;
            cylinder.Volume = Math.Round(cylinder.Volume, 2);

            return cylinder;
        }
    }
}
