using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;
public class BMIController:Controller
{
    public IActionResult Index()
    {return View();
}
    [HttpPost]
    public IActionResult Index(float Fullname,float Height,float Weight,int Age)
    {
        var result =Weight/((Height/100)*(Height/100));
        ViewBag.BMI=$"Tên là:{Fullname},Cao:{Height}cm ,Nặng:{Weight}kg ,Tuổi:{Age} ,Chỉ số BMI là:{result}";
        return View();
    }
}
