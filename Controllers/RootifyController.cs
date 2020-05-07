using System;
using Microsoft.AspNetCore.Mvc;

namespace SquareRootWeb.Controllers
{
    public class RootifyController : Controller
    {
        [HttpGet]
        public ActionResult Squareroot()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Squareroot(string firstNumber, string secondNumber) 
        {
            double num1 = double.Parse(firstNumber); //variable for first number. Using double to be certain it can give result in decimals
            double sqrt1 = Math.Sqrt(num1); // variable for square root of first number
           
            double num2 = double.Parse(secondNumber);//variable for second number
            double sqrt2 = Math.Sqrt(num2);//variable for square root of second number
            
            ViewBag.Num1 = num1; 
            ViewBag.Num2 = num2;
            ViewBag.Sqrt1 = sqrt1;
            ViewBag.Sqrt2 = sqrt2;
            //using viewbag to be certain that value and results are displayed to the user.
    
            return View();//returning the view (ViewBag)
        }
    }
}