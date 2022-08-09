using DegitalContentManagerment.Models.Admin;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DegitalContentManagerment.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        private readonly SignInManager<IdentityUser> _signInManager;

        public AdminController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register(string returnUrl=null)
        {
            returnUrl ??= Url.Content("~/");
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model,String returnUrl=null)
        {
            returnUrl ??= Url.Content("~/");
            ViewBag.returnUrl = returnUrl;
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.User,
                    Email = model.Email
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                    return LocalRedirect(returnUrl);
                }
                foreach(IdentityError item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

                return View(model);
            }
            return View(model);

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logout()
        {
            return View();
        }
        
    }
}
