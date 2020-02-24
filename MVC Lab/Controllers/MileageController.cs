using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Lab.Controllers
{
    public class MileageController : Controller
    {
        public IActionResult MileageCal()
        {
            return View();
        }
        public IActionResult Result(int mpg, int gallons)
        {
            int mileage = 0;
            mileage = mpg * gallons;
            return View(mileage);
        }
    }
}