using Bank_Application.Data;
using Bank_Application.Models;
using Bank_Application.Services;
using Microsoft.EntityFrameworkCore;
namespace Bank_Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly BankDbContext _bankDbContext;

        public AccountService(BankDbContext bankDbContext)
        {
            _bankDbContext = bankDbContext;
        }

            
       public async  Task<Account> CreateAccountAsync(Account account)
        {
            _bankDbContext.Account.Add(account);
            await _bankDbContext.SaveChangesAsync();
            return account;
        }

       
       public async  Task<Account> GetAccountByIdAsync(int id)
        {
            return await _bankDbContext.Account.Include(a => a.User)
                            .Include(a => a.Transactions)
                            .FirstOrDefaultAsync(a => a.Id == id);
        }



        public async Task<IEnumerable<Account>> GetAllAccountsAsync()
        {
            return await _bankDbContext.Account.Include(a => a.User)
                                          .Include(a => a.Transactions)
                                          .ToListAsync();
        }

    }
}
