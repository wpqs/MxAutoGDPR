﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GDPRCore20WebApp.Models;
using GDPRCore20WebApp.Services;
using GDPRCore20WebApp.Filters;

namespace GDPRCore20WebApp.Controllers
{
    [CookieConsent]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Cookies()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RevokeConsentCookie()
        {
            CookieConsent.RemoveConsentCookie(Response, this);
            ViewBag.AskCookieConsent = false;
            ViewBag.HasCookieConsent = false;
            ViewBag.CookieConsentFound = false;

            return View("Index");
        }

        [HttpGet]
        public ActionResult Test(string id)
        {
            if (String.IsNullOrEmpty(id) == false)
                ViewBag.MyParamValue = id;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}