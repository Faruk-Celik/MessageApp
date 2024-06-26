using MessageApp.EntityLayer.Concrete;
using MessageApp.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MessageApp.WebUI.Controllers
{
   
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signinManager;

        public LoginController ( SignInManager<AppUser> signinManager )
        {
            _signinManager = signinManager;
        }
        [HttpGet]
        public IActionResult Index ()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index ( UserSignViewModel signViewModel )
        {
            if (ModelState.IsValid)
            {
                var result = await _signinManager.PasswordSignInAsync(signViewModel.UserName, signViewModel.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Inbox", "MailMessage");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı Kullanıcı veya şifre yanlış !");
                }
            }
            return View();
        }
        public async Task<IActionResult> LogOut ()
        {
            await _signinManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
