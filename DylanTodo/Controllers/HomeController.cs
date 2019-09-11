﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DylanTodo.Models;
using Microsoft.AspNetCore.Http;

namespace DylanTodo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (Request.Cookies["UserInfo"] == null)
            {
                return RedirectToAction("Index", "Introduction", new { area = ""});
            }
            var model = new TodoList();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
