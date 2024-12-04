using Microsoft.AspNetCore.Mvc;
using Shopping.DataAccess.Data;
using Shopping.Entities.Models;
using Shopping.Entities.Repositories;

namespace Shopping.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
           _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var categories = _unitOfWork.Category.GetAll();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category )
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Add(category);
                _unitOfWork.Complete();
                TempData["Create"] = "Item has created successfully!";
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(int? id) 
        {
            if(id is null || id == 0)
            {
                return NotFound();
            }
            var categoryIndb = _unitOfWork.Category.GetFirstOrDefault(x => x.Id == id);
            return View(categoryIndb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category) {
            if (ModelState.IsValid)
            {
                _unitOfWork.Category.Update(category);
                _unitOfWork.Complete();
                TempData["Update"] = "Item has updated successfully!";
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id is null || id == 0)
            {
                return NotFound();
            }
            var categoryIndb = _unitOfWork.Category.GetFirstOrDefault(x => x.Id == id);
            return View(categoryIndb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCategory(int? id)
        {
            var categoryIndb = _unitOfWork.Category.GetFirstOrDefault(x => x.Id == id);

            if (categoryIndb is null)
            {
                return NotFound();
            }
            _unitOfWork.Category.Remove(categoryIndb);
            _unitOfWork.Complete();
            TempData["Delete"] = "Item has deleted successfully!";
            return RedirectToAction("Index");
        }

    }
}
