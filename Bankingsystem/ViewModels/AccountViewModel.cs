﻿using Bankingsystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bankingsystem.ViewModels
{
    public class AccountViewModel
    {
        public IEnumerable<AccountDetail> AccountDetails{get; set;}
        public string Heading { get; set; }
    }
}
