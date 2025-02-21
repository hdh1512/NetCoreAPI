using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;
public class CalcDiemController:Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(float Fullname2,int DiemA,int DiemB,int DiemC,float Tenmonhoc)
    {
        var diemaa = DiemA*0.6;
        var diembb = DiemB*0.3;
        var diemcc = DiemC*0.1;
        var diemtong = diemaa+diembb+diemcc;
        ViewBag.CalcDiem=$"Điểm A là {diemaa} Điểm B là {diembb} Điểm C là {diemcc} Tổng điểm của môn {Tenmonhoc} là:{diemtong}";
        return View();
    }
}