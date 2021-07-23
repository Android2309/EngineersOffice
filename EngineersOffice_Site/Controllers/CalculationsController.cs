using EngineersOffice_Library.Interfaces;
using EngineersOffice_Library.Models.TraverseModels;
using EngineersOffice_Library.Models.VolumeModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EngineersOffice_Site.Controllers
{
    [Authorize]
    public class CalculationsController : Controller
    {
        private readonly ICalculationVolume calculationVolume;
        private readonly ICalculationTraverse calculationTraverse;

        public CalculationsController(ICalculationVolume CalculationVolume, ICalculationTraverse CalculationTraverse)
        {
            this.calculationVolume = CalculationVolume;
            this.calculationTraverse = CalculationTraverse;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexVolume()
        {
            return View();
        }
        public IActionResult IndexTraverse()
        {
            return View();
        }

        #region расчет объемов
        //расчет обьемов////////////////////////////////////////////////////////////////////////////////////////////////
        [HttpPost]
        public PartialViewResult _BallView(Ball ball)
        {
            return PartialView(calculationVolume.BallVolume(ball));
        }

        [HttpPost]
        public PartialViewResult _CubeView(Cube cube)
        {
            return PartialView(calculationVolume.CubeVolume(cube));
        }

        [HttpPost]
        public PartialViewResult _ConusView(Conus conus)
        {
            return PartialView(calculationVolume.ConusVolume(conus));
        }

        [HttpPost]
        public PartialViewResult _CylinderView(Cylinder cylinder)
        {
            return PartialView(calculationVolume.CylinderVolume(cylinder));
        }
        #endregion

        #region расчет траверс

        //расчет траверсы на изгиб
        [HttpGet]
        public PartialViewResult _TraverseBendingView(TraverseBendingModel traverse)
        {
            if (ModelState.IsValid)
            {
                return PartialView(calculationTraverse.BendingCalculation(traverse));
            }
            else
            {
                return PartialView(traverse);
            }
        }


        //расчет траверсы на сжатие
        [HttpGet]
        public PartialViewResult _TraverseCompressionView(TraverseCompressionModel traverse)
        {
            if (ModelState.IsValid)
            {
                return PartialView(calculationTraverse.CompressionCalculation(traverse));
            }
            else
            {
                return PartialView(traverse);
            }
        }
        #endregion

    }
}
