using EngineersOffice_Library.Models.TraverseModels;

namespace EngineersOffice_Library.Interfaces
{
    public interface ICalculationTraverse
    {
        public TraverseBendingModel BendingCalculation(TraverseBendingModel traverse);
        public TraverseCompressionModel CompressionCalculation(TraverseCompressionModel traverse);

    }
}
