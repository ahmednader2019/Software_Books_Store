using BookStore.DataAccess.Repository;
using BookStore.DataAccess.Repository.IRepository;
using BookStore.Models;
using BookStore.Models.Models;
using BookStore.Models.ViewModels;
using BookStore.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

namespace BookStoreًWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
   // [Authorize(Roles = SD.Role_Admin)]

    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompanyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Company> Companys = _unitOfWork.Company.GetAll().ToList();
            
            return View(Companys); 
        }
        [HttpGet]
        public IActionResult  Create()
        { 
            return View(new Company());
        }

        [HttpPost]

        public IActionResult Create(Company company)
        {   
            if (ModelState.IsValid)
            {
                _unitOfWork.Company.Add(company);
                _unitOfWork.Save();
                TempData["success"] = "Company Created Successfully";

                return RedirectToAction("Index");
            }
            else 
            {
                return View(company);
            }
         
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();
            Company Company = _unitOfWork.Company.Get(F => F.Id == id);
            return View(Company);
        }

        [HttpPost]
        public IActionResult Edit( Company Company)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Company.Update(Company);
                _unitOfWork.Save();
                TempData["success"] = "Company Updated Successfully";

                return RedirectToAction("Index");
            }
            return View();
        }

        //[HttpGet]
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null)
        //        return NotFound();
        //    Company Company = _unitOfWork.Company.Get(F => F.Id == id);
        //    return View(Company);
        //}

        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeletePost(int? id)
        //{
        //    Company Company = _unitOfWork.Company.Get(F => F.Id == id);
        //    _unitOfWork.Company.Remove(Company);
        //    TempData["success"] = "Prodcut Deleted Successfully";
        //    _unitOfWork.Save();
        //    return RedirectToAction("Index");
        //}
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Company> Companys = _unitOfWork.Company.GetAll().ToList();
            return Json(new { data = Companys });
        }
        #endregion

        public IActionResult Delete(int? id)
        {
            var CompanyToBeDeleted = _unitOfWork.Company.Get(u => u.Id == id);
            if(CompanyToBeDeleted == null)
            {
                return Json(new { success = false, Message = "Error While Deleting" });
            }
           

            _unitOfWork.Company.Remove(CompanyToBeDeleted);
            _unitOfWork.Save();

            List<Company> Companys = _unitOfWork.Company.GetAll().ToList();
            return Json(new { success = true, Message = "Message Deleted Successfully " });


        }
    }
}

