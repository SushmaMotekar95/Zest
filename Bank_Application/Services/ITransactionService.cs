using Bank_Application.Models;

namespace   Bank_Application.Services
{
    public interface ITransactionService
    {
        Task<Transactions> CreateTransactionAsync(Transactions transaction);
        Task<IEnumerable<Transactions>> GetTransactionsByAccountIdAsync(int accountId);
    }
}
