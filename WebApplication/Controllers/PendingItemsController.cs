﻿using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class PendingItemsController : Controller
    {
        // GET
        //this method should not be used as it makes
        //no sense on this page
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("userId") == null)
            {
                return RedirectToAction("Index", "Login");
            }

            ViewData["userId"] = HttpContext.Session.GetInt32("userId");
            ViewData["username"] = HttpContext.Session.GetString("username").ToString();
            ViewData["userType"]= HttpContext.Session.GetString("userType");

            return View();
        }
        
        //GET
        public IActionResult CurrentItems(int id)
        {
            if (HttpContext.Session.GetInt32("userId") == null)
            {
                return RedirectToAction("Index", "Login");
            }

            ViewData["userId"] = HttpContext.Session.GetInt32("userId");
            ViewData["username"] = HttpContext.Session.GetString("username").ToString();
            ViewData["userType"]= HttpContext.Session.GetString("userType");
            
            return View(id);
        }
        
    }
}