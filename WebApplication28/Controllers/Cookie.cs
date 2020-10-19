using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication28.Controllers
{
    public class Cookie : Controller
    {
        private int _num;

        public IActionResult Index()
        {
            
            string value = Request.Cookies["numberVisit"];
            bool alreadyHere = !String.IsNullOrEmpty(value);

            if (alreadyHere)
            {
                int times = int.Parse(value) + 1;
                Response.Cookies.Append("numberVisit", $"{times}");
                _num = times;
            }
            else
            {
                _num = 1;
                Response.Cookies.Append("numberVisit", $"{_num}");
            }

            return View(_num);
        }
    }
}
