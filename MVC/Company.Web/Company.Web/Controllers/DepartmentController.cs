using Company.Repository.Interfaces;
using Company.Service.Interfaces;
using Data.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Company.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IdepartmentService _departmentService;
        public DepartmentController(IdepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        // GET: DepartmentController
        public ActionResult Index()
        {
            var departments = _departmentService.GetAll();
            return View(departments);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _departmentService.Add(department);
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("DepartmentError", "Validation Error");
                
                return View(department);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("DepartmentError", ex.Message);
                return View(department);
            }
        }

        public IActionResult Details(int? id,string viewName = "Details")
        {
            var department = _departmentService.GetById(id);
            if (department is null)
                return RedirectToAction("NotFoundPage", null,"Home");
            
            return View(viewName,department);
        }
        
        [HttpGet]
        public IActionResult Update(int? id)
        {
            return Details(id,"Update");
        }

        [HttpPost]
        public IActionResult Update(int? id, Department department)
        {
            if (department.Id != id.Value)
                return RedirectToAction("NotFoundPage", null,"Home");

            _departmentService.Update(department);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var department = _departmentService.GetById(id);
            if (department is null)
                return RedirectToAction("NotFoundPage", null,"Home");
            
            _departmentService.Delete(department);
            return RedirectToAction(nameof(Index));
        }
    }
}
