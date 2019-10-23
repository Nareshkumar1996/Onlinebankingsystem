using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bankingsystem.Models
{
    public class AccountDetail
    {
        [Key]
        public int AccountId { get; set; }
        public string Username { get; set; }
        public int BalanceAmount { get; set; }
    }
}
