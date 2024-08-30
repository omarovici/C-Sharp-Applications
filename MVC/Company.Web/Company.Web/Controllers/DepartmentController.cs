using Company.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Company.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        // GET: DepartmentController
        public ActionResult Index()
        {
            var departments = _departmentRepository.GetAll();
            return View(departments);
        }

    }
}
