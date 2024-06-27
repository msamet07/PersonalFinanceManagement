using System.Collections.Generic;
using System.Threading.Tasks;
using PersonalFinanceManagement.Core.Models;

namespace PersonalFinanceManagement.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserAsync(int id);
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
    }
}
