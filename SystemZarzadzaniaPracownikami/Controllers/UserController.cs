using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using SystemZarzadzaniaPracownikami.Models;
using SystemZarzadzaniaPracownikami.Services;
using SystemZarzadzaniaPracownikami.Services.Interfaces;

namespace SystemZarzadzaniaPracownikami.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
               _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            var userList = _userService.GetAll();
            return View(userList);
        }


        [HttpGet]
        public IActionResult Add() {
        return  View();
        }

        [HttpPost]
        public IActionResult Add(User body) {

            if (!ModelState.IsValid)
            {
                return View(body);
            }
            var id = _userService.Save(body);
            TempData["id"] = id;
            return RedirectToAction("Lista");
        }


        [HttpGet]
        public IActionResult Lista () {
            var userList = _userService.GetAll();
            return View(userList);
        }

        [HttpPost] 
        public IActionResult Details(int id) {
            var user = _userService.Get(id);
            return View(user);
        }

        [HttpPost] 
        public IActionResult Delete(int id) {
            _userService.Delete(id);
            return RedirectToAction("Lista");
        }

        [HttpPost]
        public IActionResult Edit(int id,User user) {
            if (!ModelState.IsValid)
            {
                return View("Details",user);
            }
            _userService.Edit(id,user);
            return RedirectToAction("Lista");
        
        }

    }
}
