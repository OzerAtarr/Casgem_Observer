using Casgem_Observer.DAL;
using Casgem_Observer.Models;
using Casgem_Observer.ObserveePattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_Observer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observerObject;

        public RegisterController(UserManager<AppUser> userManager, ObserverObject observerObject = null)
        {
            _userManager = userManager;
            _observerObject = observerObject;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            var appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                City = model.City,
                Email = model.Email,
                District = model.District,
                UserName = model.Username
            };
            var result = await _userManager.CreateAsync(appUser, model.Password);
            if (result.Succeeded)
            {
                _observerObject.Notifyserver(appUser);
                return View();
            }
            return View();
        }
    }
}
