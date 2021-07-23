using EngineersOffice_Library.Interfaces;
using EngineersOffice_Library.Models.TraverseModels;
using System;
using System.Threading;

namespace EngineersOffice_Library.Services
{
    public class TraverseCalculator : ICalculationTraverse
    {
        private readonly IBeamData beamData;
        private readonly IBendingCoefficientData bendingCoefficientData;
        static Mutex mutexObj = new Mutex();

        public TraverseCalculator(IBeamData BeamData, IBendingCoefficientData BendingCoefficientData)
        {
            this.beamData = BeamData;
            this.bendingCoefficientData = BendingCoefficientData;
        }


        public TraverseBendingModel BendingCalculation(TraverseBendingModel traverse)
        {
            
            traverse.P = 10 * traverse.G * traverse.Kp * traverse.Kd;
            traverse.M = traverse.P * traverse.Length / 4;
            traverse.Wx = traverse.M / (traverse.m * 0.1 * traverse.R);
            if (traverse.Wx > Int32.MaxValue)
            {
                traverse.Wx = 0;
            }
            else
            {
               traverse.beam = beamData.GetBeam(Convert.ToInt32(traverse.Wx));
            }

            return traverse;
        }

        public TraverseCompressionModel CompressionCalculation(TraverseCompressionModel traverse)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            //Натяжение в канатной подвеске(кН)
            traverse.N = 10 * traverse.G / (2 * Math.Cos(traverse.Alfa * 0.017453));

            //сжимающее усилие в стержне траверсы
            traverse.N1 = 10 * traverse.G * traverse.Kd * traverse.Kp * Math.Tan(traverse.Alfa * 0.017453) / 2;

            //требуемая площадь поперечного сечения
            traverse.F_tr = traverse.N1 / (traverse.fi_0 * traverse.m * 0.1 * traverse.R);

            //расчетная длина стержня
            traverse.Lc = traverse.mu * traverse.Length;

            //max гибкость
            int maxFlex;

            //начальные значение id балки (для 1й итерации цикла если
            traverse.beam.Id = 0;

            //выбор балки проверкой на устойчивость
            while (true)
            {

                //подбор балки по гибкости
                mutexObj.WaitOne();
                traverse.beam = beamData.GetBeam_Flex(traverse.beam.Id, traverse.F_tr, traverse.Lc);
                mutexObj.ReleaseMutex();

                if (traverse.beam != null)
                {
                    traverse.r_x = traverse.beam.i_x;
                    traverse.r_y = traverse.beam.i_y;
                    traverse.Flex_x = traverse.Lc / traverse.r_x;
                    traverse.Flex_y = traverse.Lc / traverse.r_y;
                    traverse.F = traverse.beam.F;
                    traverse.Wx = traverse.beam.Wx;

                    //подбор коэффициента фи по гибкости
                    maxFlex = Convert.ToInt32(Math.Max(traverse.Flex_x, traverse.Flex_y));
                    traverse.fi = Convert.ToDouble(bendingCoefficientData.GetBendingCoefficient_Flex(maxFlex).R_220) / 1000;

                    //проверка на устойчивость и выход из цикла
                    if (traverse.N1 / (traverse.F * traverse.fi) * 10 <= traverse.m * traverse.R)
                    {
                        break;
                    }
                }
                else
                {
                    traverse.Wx = 0;
                    break;
                }
            }
            return traverse;
        }
    }
}
