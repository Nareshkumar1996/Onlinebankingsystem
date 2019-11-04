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
        
        public void CreateNewUser(AccountDetail accountDetail)
        {
            _appDbContext.AccountDetails.Add(accountDetail);
            _appDbContext.SaveChanges();
        }

        public AccountDetail ViewBalance(int Id)
        {
            return _appDbContext.AccountDetails.FirstOrDefault(p => p.AccountId == Id);
        }

        
    }
}
