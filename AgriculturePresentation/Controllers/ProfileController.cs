using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ProfileController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.mail = values.Email;
            userEditViewModel.phone = values.PhoneNumber;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.Email = userEditViewModel.mail;
            values.PhoneNumber = userEditViewModel.phone;

            if (!string.IsNullOrEmpty(userEditViewModel.password))
            {
                values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, userEditViewModel.password);
            }

            var result = await _userManager.UpdateAsync(values);

            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = "Profiliniz başarıyla güncellendi.";
                return RedirectToAction("Index");
            }

            return View(userEditViewModel);
        }
    }
}
