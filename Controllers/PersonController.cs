using Microsoft.AspNetCore.Mvc;
using Todo.Models.Domain;


namespace Todo.Controllers;

public class PersonController : Controller
{
    List<Person> todos = new List<Person>();
    public IActionResult Index()
    {

        Person element = new Person(1, "Helo", "w@gmail.com");
        todos.Add(element);
        Person element2 = new Person(1, "Hasdasdelo", "w@gmail.com");
        todos.Add(element2);
        return View(todos);
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(string Name, string Email)
    {
        return View(todos);
    }
}