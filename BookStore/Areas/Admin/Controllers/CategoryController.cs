using BookStore.DataAccess.Repository.IRepository;
using BookStore.Models;
using BookStore.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BookStoreًWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
   // [Authorize(Roles = SD.Role_Admin)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        //private readonly ApplicationDBContxt dBContxt;
        public CategoryController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public IActionResult Index()
        {
          
            List<Category> Categoriess = unitOfWork.Category.GetAll().ToList();
            return View(Categoriess);
        }

        [HttpGet]
        public IActionResult Create()
        {
       
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Category.Add(category);
                unitOfWork.Save();
                TempData["success"] = "Category Created Successfully";
                return RedirectToAction("Index");
            }
            return View(new Category());
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();
            Category category = unitOfWork.Category.Get(F => F.Id == id);

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Category.Update(category);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            Category category = unitOfWork.Category.Get(F => F.Id == id);
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Category category = unitOfWork.Category.Get(F => F.Id == id);
            unitOfWork.Category.Remove(category);
            TempData["success"] = "Category Deleted Successfully";
            unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
