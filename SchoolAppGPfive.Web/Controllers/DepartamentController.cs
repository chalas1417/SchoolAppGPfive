using Microsoft.AspNetCore.Mvc;
using SchoolAppGPfive.DAL.Entities;
using SchoolAppGPfive.DAL.Interfaces;
using SchoolAppGPfive.DAL.Models;

namespace SchoolAppGPfive.Web.Controllers;

public class DepartamentController : Controller
{
    private readonly IDepartamentDb _departamentService;

    public DepartamentController(IDepartamentDb departamentService)
    {
        _departamentService = departamentService;
    }

    // GET: CourseController
    public ActionResult Index()
    {
        var departamentLists = _departamentService.GetDepartaments();

        return View(departamentLists);
    }

    public ActionResult Details(int id)
    {
        var departamentLists = _departamentService.GetDepartament(id);

        return View(departamentLists);
    }

    // GET: CourseController/Create
    public async Task<ActionResult> Create(Departament departament)
    {
        _departamentService.SaveDepartamet(departament);

        return View();
    }

    // POST: CourseController/Create

    [HttpPost]
    public ActionResult Edit(Departament departament)
    {
        _departamentService.SaveDepartamet(departament);

        return View();
    }



    // GET: CourseController/Delete/5
    public ActionResult Delete(DepartamentRemoveModel departament)
    {
        _departamentService.RemoveDepartament(departament);

        return View();
    }

}
