using Bank_Application.Models;

namespace Bank_Application.Services
{
    public interface IUserService
    {
        Task<User> CreateUser(User user);
        Task<User> GetUserByID(int id);
        Task<IEnumerable<User>> GetAllUser();

    }
}
