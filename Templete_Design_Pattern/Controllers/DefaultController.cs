using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Templete_Design_Pattern.DAL.Entites;

namespace Templete_Design_Pattern.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _usermanager;

        public DefaultController(UserManager<AppUser> usermanager)
        {
            _usermanager = usermanager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _usermanager.Users.ToListAsync();
            return View(values);
        }
    }
}
