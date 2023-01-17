using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Templete_Design_Pattern.DAL.Entites;
using Templete_Design_Pattern.Models;

namespace Templete_Design_Pattern.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel model)
        { 
            var result=await _signInManager.PasswordSignInAsync(model.UserName, model.password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
