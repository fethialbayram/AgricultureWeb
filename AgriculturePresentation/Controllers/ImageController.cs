using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ImageController : Controller
    {

        private IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            var values = _imageService.GetListAll();
            return View(values);
        }

        public IActionResult AddImage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddImage(Image image)
        {
            ImageValidator imageValidator = new ImageValidator();
            ValidationResult validationResult = imageValidator.Validate(image);
            if (validationResult.IsValid)
            {
                _imageService.Insert(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteImage(int id)
        {
            var value = _imageService.GetById(id);
            _imageService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditImage(int id)
        {
            var value = _imageService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditImage(Image image)
        {
            ImageValidator imageValidator = new ImageValidator();
            ValidationResult validationResult = imageValidator.Validate(image);
            if (validationResult.IsValid)
            {
                _imageService.Update(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }
    }
}
