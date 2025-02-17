using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class PersonController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string str0utput =$"Xin chào {ps.PersonID}-{ps.Fullname}-{ps.Address}";
        ViewBag.infoperson=str0utput;
        return View();
    }
    }
}