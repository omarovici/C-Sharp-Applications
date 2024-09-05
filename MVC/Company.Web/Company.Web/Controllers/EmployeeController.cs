using Company.Service.Interfaces;
using Data.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Company.Web.Controllers;

public class EmployeeController : Controller
{
    private readonly IEmployeeService _employeeService;
    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }
    // GET
    public IActionResult Index()
    {
        var employees = _employeeService.GetAll();
        return View(employees);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Employee employee)
    {
        try
        {
            if (ModelState.IsValid)
            {
                _employeeService.Add(employee);
                return RedirectToAction(nameof(Index));
            }

            ModelState.AddModelError("EmployeeError", "Validation Error");

            return View(employee);
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("EmployeeError", ex.Message);
            return View(employee);
        }
    }

    public IActionResult Details(int? id, string viewName = "Details")
    {
        var employee = _employeeService.GetById(id);
        if (employee is null)
            return RedirectToAction("NotFoundPage", null, "Home");
        
        return View(viewName,employee);
    }

    public IActionResult Update(int? id)
    {
        return Details(id, "Update");
    }  

    public IActionResult Delete(int id)
    {
        var employee = _employeeService.GetById(id);
        if (employee is null)
            return RedirectToAction("NotFoundPage", null, "Home");
        
        _employeeService.Delete(employee);
        return RedirectToAction(nameof(Index));
    }
}