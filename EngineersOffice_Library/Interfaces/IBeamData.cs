
using EngineersOffice_Library.Models.MetalAssortment;
using System.Collections.Generic;

namespace EngineersOffice_Library.Interfaces
{
    public interface IBeamData
    {
        public IEnumerable<Beam> GetAllBeams();
        public Beam GetBeam(int Wx);
        public Beam GetBeam_Flex(int id, double F_tr, double Lc);

    }
}
