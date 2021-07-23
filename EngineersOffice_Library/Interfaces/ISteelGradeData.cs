using EngineersOffice_Library.Models;
using System.Collections.Generic;

namespace EngineersOffice_Library.Interfaces
{
    public interface ISteelGradeData
    {
        public IEnumerable<SteelGrade> GetSteelGrades(string searchString);

        void AddSteelGrade(SteelGrade steelGrade);

        void DeleteSteelGrade(int id);

        void EditSteelGrade(int id, SteelGrade steelGrade);
    }
}
