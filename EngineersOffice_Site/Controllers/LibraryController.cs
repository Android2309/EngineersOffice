using EngineersOffice_Library.Interfaces;
using EngineersOffice_Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EngineersOffice_Site.Controllers
{
    [Authorize]
    public class LibraryController : Controller
    {
        private readonly ISteelGradeData steelGradeData;
        private readonly IBeamData beamData;
        private readonly IBendingCoefficientData bendingCoefficientData;

        public LibraryController(ISteelGradeData SteelGradeData, IBeamData BeamData, IBendingCoefficientData BendingCoefficientData)
        {
            this.steelGradeData = SteelGradeData;
            this.beamData = BeamData;
            this.bendingCoefficientData = BendingCoefficientData;
        }


        public IActionResult Index()
        {
            return View();
        }

        #region SteelGrade actions
        public IActionResult SteelGrades(string searchString)
        {
            return View(steelGradeData.GetSteelGrades(searchString));
        }

        // GET: SteelGrades/SteelGrades_Create
        [Authorize(Roles = "admin")]
        public IActionResult SteelGrade_Create()
        {
            return View();
        }

        // POST: SteelGrades/SteelGrades_Create
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SteelGrade_Create([Bind("Id,Grade,YieldStress,TensileStrength,Elongation,Contraction,HB")] SteelGrade steelGrade)
        {
            steelGradeData.AddSteelGrade(steelGrade);
            return RedirectToAction(nameof(SteelGrades));
        }

        // GET: SteelGrades/Delete/
        [Authorize(Roles = "admin")]
        public IActionResult SteelGrade_Delete(
            int id, string grade, int yieldStress, int tensileStrength, int elongation, int contraction, int hB)
        {
            return View(new SteelGrade
            {
                Id = id,
                Grade = grade,
                YieldStress = yieldStress,
                TensileStrength = tensileStrength,
                Elongation = elongation,
                Contraction = contraction,
                HB = hB
            });
        }


        // POST: SteelGrades/SteelGrade_Delete/5
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SteelGrade_Delete(int id)
        {
            steelGradeData.DeleteSteelGrade(id);
            return RedirectToAction(nameof(SteelGrades));
        }

        // GET: SteelGrades/Edit/5
        [Authorize(Roles = "admin")]
        public IActionResult SteelGrade_Edit(int id, string grade, int yieldStress, int tensileStrength, int elongation, int contraction, int hB)
        {
            return View(new SteelGrade
            {
                Id = id,
                Grade = grade,
                YieldStress = yieldStress,
                TensileStrength = tensileStrength,
                Elongation = elongation,
                Contraction = contraction,
                HB = hB
            });
        }

        // POST: SteelGrades/SteelGrade_Edit/5
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SteelGrade_Edit(int id, SteelGrade steelGrade)
        {
            steelGradeData.EditSteelGrade(id, steelGrade);
            return RedirectToAction(nameof(SteelGrades));
        }
        #endregion

        #region MetalAssortment actions
        public IActionResult Beams()
        {
            return View(beamData.GetAllBeams());
        }

        public IActionResult GetBeam(int Wx)
        {
            return View(beamData.GetBeam(Wx));
        }
        #endregion

        #region BendingCoefficient actions
        public IActionResult BendingCoefficients()
        {
            return View(bendingCoefficientData.GetAllBendingCoefficients());
        }

        #endregion
    }
}
