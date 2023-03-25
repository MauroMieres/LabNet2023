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
    public class CategoriesController : Controller
    {
        public ActionResult Index()
        {
            IABMLogic<Categories> categoriesLogic = new CategoriesLogic();
            var categories = categoriesLogic.GetAll().Select(c => new CategoriesViewModel { IdCategoria = c.CategoryID, NombreCategoria = c.CategoryName }).ToList();
            return View(categories);
        }

        public ActionResult ConfirmarEliminacion(int id)
        {
            IABMLogic<Categories> categoriesLogic = new CategoriesLogic();
            var entity = categoriesLogic.GetById(id);

            var viewModel = new CategoriesViewModel
            {
                NombreCategoria = entity.CategoryName,
                IdCategoria = entity.CategoryID
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult ConfirmarEliminacion(CategoriesViewModel viewModel)
        {
            IABMLogic<Categories> categoriesLogic = new CategoriesLogic();
            var entity = categoriesLogic.GetById(viewModel.IdCategoria);
            if (entity != null)
                categoriesLogic.Delete(entity);
            return RedirectToAction("Index");
        }



        public ActionResult Modificar(int id)
        {
            IABMLogic<Categories> categoriesLogic = new CategoriesLogic();
            CategoriesViewModel model = new CategoriesViewModel();
            var entity = categoriesLogic.GetById(id);
            model.IdCategoria = entity.CategoryID;
            model.NombreCategoria = entity.CategoryName;
            //categoriesLogic.Update(entity);
            return View(model);
        }

        [HttpPost]
        public ActionResult Modificar(CategoriesViewModel model)
        {
            //falta validacion
            IABMLogic<Categories> categoriesLogic = new CategoriesLogic();
            categoriesLogic.Update(new Categories { CategoryID = model.IdCategoria, CategoryName = model.NombreCategoria });
            //manejo de errores
            return RedirectToAction("Index");
        }

        public ActionResult Insert()
        {
            var categoryViewModel = new CategoriesViewModel();
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CategoriesViewModel categoryViewModel)
        {
            var category = new Categories
            {
                CategoryName = categoryViewModel.NombreCategoria
            };

            IABMLogic<Categories> categoriesLogic = new CategoriesLogic();
            //category.CategoryID = categoriesLogic.GetAll().Last().CategoryID + 1;
            categoriesLogic.Insert(category);
            return RedirectToAction("Index");
        }
    }
}