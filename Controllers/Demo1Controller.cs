using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using MvcMovie.Models.Process;

namespace MvcMovie.Controllers
{
    public class Demo1Controller : Controller    
    {
        //khai bao class theo huong doi tuong
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
      
      public IActionResult Index ()
      {
            return View();
      }
      //acction de nhan du loieu gui len
      [HttpPost]
      public IActionResult Index(string heSoA, string heSoB)
      {
        // ep kieu du lieu cua tham so
        double a = Convert.ToDouble(heSoA);
        double b = Convert.ToDouble(heSoB);
        string thongBao = gpt.GiaiPhuongTrinhBacNhat(a, b);
        ViewBag.mess= thongBao ; 
        return View();
      }
      [HttpPost]
      public IActionResult Creat(string heSoA, string heSoB, string heSoC)
      {
        // ep kieu du lieu cua tham so
        double a = Convert.ToDouble(heSoA);
        double b = Convert.ToDouble(heSoB);
        double c = Convert.ToDouble(heSoC);
        string thongBao = gpt.GiaiPhuongTrinhBacHai(a, b, c);
        ViewBag.thongbao= thongBao ; 
        return View();
      }
    }
}   
       