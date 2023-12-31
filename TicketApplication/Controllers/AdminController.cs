﻿using Microsoft.AspNetCore.Mvc;
using TicketApplication.Models.Models;
using TicketApplication.Services.Interface;

namespace TicketApplication.Controllers
{
    public class AdminController : Controller
    {


        private readonly IUserService _userService;

        public AdminController(IUserService service)
        {
            _userService = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetUsers() {
            List<ApplicationUser> allUsers = _userService.GetAll().ToList();

            return View(allUsers);
        }
    }
}
