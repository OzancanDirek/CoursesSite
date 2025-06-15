using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class courseController : Controller
{
public IActionResult Index()
{
    var kurs = new Course()
    {
        Id = 1,
        Title = "Aspnet core kursu",
        Description = "Güzel bir kurs",
        Image = "1.png"
    };
    return View(kurs);
}

public IActionResult Details(int id)
{
        if (id == null)
        {
            return Redirect("/course/list");
        }
        var kurs = Repository.GetById(id);
        return View(kurs);
}


    public IActionResult List()
    {
        
        return View("CourseList", Repository.Courses);
    }
}