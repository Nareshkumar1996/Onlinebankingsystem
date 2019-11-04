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
    public class AccountController : Controller
    {
        private readonly IAccountDetailRepository _accountDetailRepository;
        private readonly AppDbContext _appDbContext;

        public AccountController(IAccountDetailRepository accountDetailRepository, AppDbContext appDbContext)
        {
            _accountDetailRepository = accountDetailRepository;
            _appDbContext = appDbContext;
        }
        //Below method is to get all user details from db
        public ViewResult UserDetails()
        {
            AccountViewModel accountViewModel = new AccountViewModel();
            accountViewModel.AccountDetails = _accountDetailRepository.AllDetails;
            accountViewModel.Heading = "User Details";
            return View(accountViewModel);
        }
        public ViewResult GetBalanceform()
        {
            return View();
        }
        //Below method is to get the balance amount for a specific user
        [HttpPost]
        public IActionResult GetBalance(Withdraw withdraw)
        {

            var balan = _accountDetailRepository.ViewBalance(withdraw.AccountId);
            AccountViewModel accountViewModel = new AccountViewModel();
            accountViewModel.Uname = balan.Username;
            accountViewModel.BalanceAmount = balan.BalanceAmount;

            return View(accountViewModel);
        }
        public ViewResult Withdrawform()
        {
            return View();
        }

        //Below method is to withdraw amount from main balance and update the main balance
        [HttpPost]
        public ViewResult Withdraw(Withdraw withdraw)
        {
            int id = withdraw.AccountId;
            var viewbalance = 0 ;
            
            var details = _accountDetailRepository.AllDetails.FirstOrDefault(a => a.AccountId == id);
            if(details == null)
            {

            }
            else
            {
                details.BalanceAmount = details.BalanceAmount - withdraw.WithdrawAmount;
                ViewBag.viewbalance = details.BalanceAmount;
                
                _appDbContext.AccountDetails.Update(details);
                _appDbContext.SaveChanges();

            }
         
            return View(viewbalance);
        }
        public ViewResult NewUserform()
        {
            return View();
        }
        [HttpPost]
        public ViewResult NewUser(AccountDetail accountDetail)
        {
            _accountDetailRepository.CreateNewUser(accountDetail);
            ViewBag.uiname = accountDetail.Username;
            
            return View(accountDetail);
        }

    }
}
