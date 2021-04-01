using FexEcommerce.Data.Interfaces;
using FexEcommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FexEcommerce.Data.Repositories
{
    public class UserRepositories : IUserRepositories
    {
        private FlexEcommerceContext _dbContext;
        
        public UserRepositories(FlexEcommerceContext flexEcommerceContext)
        {
            _dbContext = flexEcommerceContext;
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await _dbContext.Users
              .SingleOrDefaultAsync(c => c.ID == id);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _dbContext.Users.Include(u => u.City).Include(u => u.Department).ToListAsync();
        }

        public async Task<User> SaveUserAsync(User user)
        {

            _dbContext.Users.Add(user);
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception exception)
            {     
                Console.WriteLine(exception);
            }
            return user;
        }
    }
}
