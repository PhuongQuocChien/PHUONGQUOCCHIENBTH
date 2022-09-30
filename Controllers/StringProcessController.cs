using Microsoft.AspNetCore.Mvc;
using Mvc.Models;
namespace Mvc.Controllers
{
    public class StringProcessController:Controller
    
     {
     StringProcess strPro =new StringProcess();
      
      public IActionResult Index ()
      {
            return View();
      }
      //acction de nhan du loieu gui len
      [HttpPost]
      public IActionResult Index(string strInput )
      {
        string StringProcess= strPro.RemoveRemainingWhiteSpace(strInput);
        ViewBag.a= StringProcess;
    
        return View();
      }
      StringProcess strPr =new StringProcess();
       public IActionResult Index1()
      {
            return View();
      }
      //acction de nhan du loieu gui len
      [HttpPost]
      public IActionResult Index1(string strInput )
      {
        string StringProcess= strPr.UpperToLower(strInput);
        ViewBag.b= StringProcess;
    
        return View();
      }
      
        StringProcess strP =new StringProcess();
       public IActionResult Index3()
      {
            return View();
      }
      //acction de nhan du loieu gui len
      [HttpPost]
      public IActionResult Index3(string strInput )
      {
        string StringProcess= strP.CapitalizeOneFirstCharacter(strInput);
        ViewBag.c= StringProcess;
    
        return View();
     }
      StringProcess str =new StringProcess();
       public IActionResult Index2()
      {
            return View();
      }
      //acction de nhan du loieu gui len
      [HttpPost]
      public IActionResult Index2(string strInput )
      {
        string StringProcess= str.RemoveVietnameseAccents(strInput);
        ViewBag.d= StringProcess;
    
        return View();
     }
     StringProcess st =new StringProcess();
       public IActionResult Index4()
      {
            return View();
      }
    
      //acction de nhan du loieu gui len
      [HttpPost]
      public IActionResult Index4(string strInput )
      {
        string StringProcess= strPro.CapitalizeFirstCharacter(strInput);
        ViewBag.e= StringProcess;
    
        return View();
      }
      }
      }
   
     