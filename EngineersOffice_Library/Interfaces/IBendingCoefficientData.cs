using EngineersOffice_Library.Models;
using System.Collections.Generic;

namespace EngineersOffice_Library.Interfaces
{
    public interface IBendingCoefficientData
    {
        public IEnumerable<BendingCoefficient> GetAllBendingCoefficients();
        public BendingCoefficient GetBendingCoefficient_Flex(int flexibility);
    }
}
