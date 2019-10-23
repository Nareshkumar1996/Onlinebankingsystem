using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bankingsystem.Models
{
    public class AccountDetailRepository : IAccountDetailRepository
    {
        private readonly AppDbContext _appDbContext;
        public AccountDetailRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<AccountDetail> AllDetails
        {
            get
            {
                return _appDbContext.AccountDetails;
            }
        }

        public void AddAccountDetail(AccountDetail account)
        {
            throw new NotImplementedException();
        }

        public int ViewBalance(AccountDetail AccountId)
        {
            throw new NotImplementedException();
        }

        public int ViewBalance(int accountId)
        {
            throw new NotImplementedException();
        }

        public int WithdrawAmount(int amt)
        {
            throw new NotImplementedException();
        }
    }
}
