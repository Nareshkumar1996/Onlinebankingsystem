using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bankingsystem.Models;
using Bankingsystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bankingsystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAccountDetailRepository _accountDetailRepository;
        public HomeController(IAccountDetailRepository accountDetailRepository)
        {
            _accountDetailRepository = accountDetailRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        
        
    }
}
