using Bank_Application.Models;

namespace Bank_Application.Services
{
    public interface IAccountService
    {
        Task<Account> CreateAccountAsync(Account account);
        Task<Account> GetAccountByIdAsync(int id);
        Task<IEnumerable<Account>> GetAllAccountsAsync();
    }
}
