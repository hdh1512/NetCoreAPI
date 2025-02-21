using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;
public class BillController:Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Bill Bi)
    {
        var thanhtien = Bi.Quantity*Bi.Price;
        ViewBag.thanhtien =$"Giá của {Bi.NameProduct} với số lượng {Bi.Quantity} có giá là {thanhtien}";
        return View();
    }
}