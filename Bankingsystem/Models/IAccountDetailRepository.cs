using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bankingsystem.Models
{
    public interface IAccountDetailRepository
    {
        IEnumerable<AccountDetail> AllDetails { get;}
        AccountDetail ViewBalance(int Id);
        void CreateNewUser(AccountDetail accountDetail);
      
    }
}
