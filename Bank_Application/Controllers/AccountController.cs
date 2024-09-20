using Bank_Application.Models;
using Bank_Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }


        [HttpPost]
        public async Task<ActionResult<Account>> CreateAccount(Account account)
        {

            var createdAccount = await _accountService.CreateAccountAsync(account);
            return Ok(createdAccount);
        }
        [HttpGet("id")]
        public async Task<ActionResult<Account>> GetAccountByID(int id)
        {
            var account = await _accountService.GetAccountByIdAsync(id);
            if (account == null)
            {
                return NotFound();

            }
            return account;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetAllAccounts()
        {
            var accounts = await _accountService.GetAllAccountsAsync();
            return Ok(accounts);
        }
             
    }
}
