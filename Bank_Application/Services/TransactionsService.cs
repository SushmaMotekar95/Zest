using Bank_Application.Data;
using Bank_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Bank_Application.Services
{
    public class TransactionsService : ITransactionService
    {
        private readonly BankDbContext _context;

        public TransactionsService(BankDbContext context)
        {
            _context = context;
        }

        public async Task<Transactions> CreateTransactionAsync(Transactions transaction)
        {
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();
            return transaction;
        }

        public async Task<IEnumerable<Transactions>> GetTransactionsByAccountIdAsync(int accountId)
        {
            return await _context.Transactions
                                 .Where(t => t.AccountID == accountId)
                                 .ToListAsync();
        }
    }
}
