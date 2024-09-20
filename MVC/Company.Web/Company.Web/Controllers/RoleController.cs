using Company.Web.Models;
using Data.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Company.Web.Controllers;

[Authorize (Roles = "Admin")]
public class RoleController : Controller
{
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ILogger<RoleController> _logger;
    
    public RoleController(RoleManager<IdentityRole> roleManager ,UserManager<ApplicationUser> userManager, ILogger<RoleController> logger)
    {
        _roleManager = roleManager;
        _userManager = userManager;
        _logger = logger;
    }
    public async Task<IActionResult> Index()
    {
        var roles = await _roleManager.Roles.ToListAsync();
        return View(roles);
    }
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(RoleViewModel roleModel)
    {
        if (ModelState.IsValid)
        {
            var role = new IdentityRole()
            {
                Name = roleModel.Name
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
                return RedirectToAction("Index");
            foreach (var error in result.Errors)
                _logger .LogError(error.Description);
        }
        return View(roleModel);
    }
    public async Task<IActionResult> Details(string id, string viewName = "Details")
    {
        var role = await _roleManager.FindByIdAsync(id);
        if (role is null)
            return NotFound();
        
        var roleUpdateViewModel = new RoleViewModel
        {
            Id = role.Id,
            Name = role.Name
        };
        return View(viewName, roleUpdateViewModel);
    }

    [HttpGet]
    public async Task<IActionResult> Update(string id)
    {
        return await Details(id, "Update");
    }

    [HttpPost]
    public async Task<IActionResult> Update(string id, RoleViewModel roleModel)
    {
        if (id != roleModel.Id)
            return NotFound();
        if (ModelState.IsValid)
        {
            try
            {
                var role = await _roleManager.FindByIdAsync(id);
                
                if (role is null)
                    return NotFound();
                
                role.Name = roleModel.Name;
                role.NormalizedName = roleModel.Name.ToUpper();
                
                var result = await _roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    _logger.LogInformation("Role updated successfully");
                    return RedirectToAction("Index");
                }
                foreach (var error in result.Errors)
                    _logger.LogError(error.Description);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }
        return View("Update", roleModel);
    }
    public async Task<IActionResult> Delete(string id)
    {
        try
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role is null)
                return NotFound();
            var result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
                return RedirectToAction("Index");
            foreach (var error in result.Errors)
                _logger.LogError(error.Description);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
        }
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> AddOrRemoveUsers(string roleId)
    {
        var role = await _roleManager.FindByIdAsync(roleId);
        if (role is null)
            return NotFound();
        
        ViewBag.RoleId = roleId;
        
        var users = await _userManager.Users.ToListAsync();
        
        var usersInRole = new List<UserInRoleViewModel>();
        foreach (var user in users)
        {
            var userInRole = new UserInRoleViewModel()
            {
                UserId = user.Id,
                UserName = user.UserName
            };
            if (await _userManager.IsInRoleAsync(user, role.Name))
                userInRole.IsSelected = true;
            else
                userInRole.IsSelected = false;
            
            usersInRole.Add(userInRole);
        }
        return View(usersInRole);
    }

    [HttpPost]
    public async Task<IActionResult> AddOrRemoveUsers(string roleId, List<UserInRoleViewModel> users)
    {
        var role = await _roleManager.FindByIdAsync(roleId);
        if (role is null)
            return NotFound();
        

        if (ModelState.IsValid)
        {
            foreach (var user in users)
            {
                var appUser = await _userManager.FindByIdAsync(user.UserId);
                if (appUser is not null)
                {
                    if(user.IsSelected && !await _userManager.IsInRoleAsync(appUser , role.Name))
                        await _userManager.AddToRoleAsync(appUser, role.Name);
                    else if(!user.IsSelected && await _userManager.IsInRoleAsync(appUser , role.Name))
                        await _userManager.RemoveFromRoleAsync(appUser, role.Name);
                }
            }
            return RedirectToAction("Update", new {id = roleId});
        }

        return View(users);
    }
}