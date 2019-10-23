using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bankingsystem.Models
{
    public interface IAccountDetailRepository
    {
        IEnumerable<AccountDetail> AllDetails { get;}
        void AddAccountDetail(AccountDetail account);
        int ViewBalance( int accountId);
        int WithdrawAmount(int amt);
    }
}
