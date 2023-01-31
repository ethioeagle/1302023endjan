using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace try.Controllers
{
    public class FacultyController : Controller
    {
    DataContext _db;

    public FacultyController(DataContext db)
    {
        _db = db;
    }


    public IActionResult Index()
    {
        List<Employees> s = new List<Employees>();
        s = _db.Employees.ToList();

        string pagename = "This is from index- the time is : " + DateTime.Now;
        ViewBag.title = pagename;
        ViewBag.FName = "Dawit byFante";
        return View(s);
    }
    public IActionResult GetEmployeesById()
    {
        return View();
    }
    }
}
