using Microsoft.AspNetCore.Mvc;
using SchoolAppGPfive.DAL.Entities;
using SchoolAppGPfive.DAL.Interfaces;
using SchoolAppGPfive.DAL.Models;
namespace School.Web.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseDb _courseService;

        public CourseController(ICourseDb courseService)
        {
            _courseService = courseService;
        }

        // GET: CourseController
        public ActionResult Index()
        {
            var courseLists = _courseService.GetCource();

            return View(courseLists);
        }

        public ActionResult Details(int id)
        {
            var courseLists = _courseService.GetCourse(id);

            return View(courseLists);
        }

        // GET: CourseController/Create
        public async Task<ActionResult> Create(Course course)
        {
            _courseService.SaveCourse(course);

            return View();
        }

        // POST: CourseController/Create

        [HttpPost]
        public ActionResult Edit(Course course)
        {
            _courseService.UpdateCourse(course);

            return View();
        }

     

        // GET: CourseController/Delete/5
        public ActionResult Delete(CourseRemoveModel course)
        {
            _courseService.RemoveCourse(course);

            return View();
        }

    }
}