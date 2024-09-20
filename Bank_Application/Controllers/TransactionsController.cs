using Bank_Application.Models;
using Bank_Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _ITransactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _ITransactionService = transactionService;
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<ITransactionService>>> CreateTransaction(Transactions transactions)
        {
            var createTransaction = await _ITransactionService.CreateTransactionAsync(transactions);
            return Ok(createTransaction);

        }
        [HttpGet("accountid")]
        public async Task<ActionResult<IEnumerable<Transactions>>> GetTransactionsByAccountId(int accountid)
        {
            var transactions = await _ITransactionService.GetTransactionsByAccountIdAsync(accountid);
            if (transactions == null)
            {
                return NotFound();
            }
            return Ok(transactions);
        }
    }
}
