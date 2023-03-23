using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.EF.MVC.Controllers
{
    public class RegionController : Controller
    {
        // GET: Region
        public ActionResult Index()
        {
            IABMLogic<Region> regionesLogic = new RegionLogic();
            var regiones = regionesLogic.GetAll().Select(r => new RegionViewModel { Id = r.RegionID, Descripcion = r.RegionDescription }).ToList();
            return View(regiones);
        }

        public ActionResult Eliminar(int id) 
        {
            IABMLogic<Region> regionesLogic = new RegionLogic();
            var entity = regionesLogic.GetById(id);
            regionesLogic.Delete(entity);
            return null;
        }

        public ActionResult Modificar(int id)
        {
            IABMLogic<Region> regionesLogic = new RegionLogic();
            RegionViewModel model = new RegionViewModel();
            var entity = regionesLogic.GetById(id);
            model.Id = entity.RegionID;
            model.Descripcion = entity.RegionDescription;
            //regionesLogic.Update(entity);
            return View(model);
        }

        [HttpPost]
        public ActionResult Modificar(RegionViewModel model)
        {
            //falta validacion
            IABMLogic<Region> regionesLogic = new RegionLogic();
            regionesLogic.Update(new Region { RegionID= model.Id, RegionDescription=model.Descripcion});

            //manejo de errores
            return RedirectToAction("Index");
        }
    }
}