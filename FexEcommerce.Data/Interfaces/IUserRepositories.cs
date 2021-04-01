using FexEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FexEcommerce.Data.Interfaces
{
    public interface IUserRepositories
    {
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserAsync(int id);
        Task<User> SaveUserAsync(User user);
    }
}
