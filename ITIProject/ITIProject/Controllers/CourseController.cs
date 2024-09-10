using ITIProject.Data;
using ITIProject.Models;
using ITIProject.Repository;
using ITIProject.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ITIProject.Controllers
{
    public class CourseController : Controller
    {
        ICourseRepo courseRepo;
        IStudentRepo studentRepo;

        public CourseController(ICourseRepo _corse)
        {
            courseRepo = _corse;
        }
        public IActionResult Index()
        {
            var crs=courseRepo.GetAll();
            return View(crs);
        }
        public IActionResult Details(int id)
        {
            var crs = courseRepo.GetById(id);
            return View(crs);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course crs)
        {
            courseRepo.Add(crs);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var crs = courseRepo.GetById(id);
            return View(crs);
        }
        [HttpPost]
        public IActionResult Edit(int id, Course crs)
        {
            courseRepo.Update(crs);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Remove(int id)
        {
            var dept = courseRepo.GetById(id);
            return View(dept);

        }
        [HttpPost, ActionName("Remove")]
        public IActionResult RemoveConfirmed(int id)
        {

            courseRepo.DeleteById(id);
            return RedirectToAction("Index");
        }
    }
}
