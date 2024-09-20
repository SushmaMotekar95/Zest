using Bank_Application.Data;
using Bank_Application.Models;
using Bank_Application.Services;
using Microsoft.EntityFrameworkCore;
namespace Bank_Application.Services
{
    public class UserService : IUserService
    {
        private readonly BankDbContext _bankDbContext;   

        public UserService(BankDbContext bankDbContext)
        {
            _bankDbContext=bankDbContext;
        }

       public async  Task<User> CreateUser(User user)
        {
            _bankDbContext.User.Add(user);
            await _bankDbContext.SaveChangesAsync();
            return  user;
        }

       public async  Task<IEnumerable<User>> GetAllUser()
        {

           
            return await  _bankDbContext.User.ToListAsync();
        }

     public async  Task<User> GetUserByID(int id)
        {
            return await _bankDbContext.User.FindAsync(id);
        }
    }
}
