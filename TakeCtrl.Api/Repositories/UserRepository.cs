using Microsoft.EntityFrameworkCore;
using System.Linq;
using TakeCtrl.Api.Data;
using TakeCtrl.Api.Entities;
using TakeCtrl.Api.Models.Dtos;
using TakeCtrl.Api.Repositories.Contracts;

namespace TakeCtrl.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TakeCtrlDbContext takeCtrlDbContext;

        public UserRepository(TakeCtrlDbContext takeCtrlDbContext)
        {
            this.takeCtrlDbContext = takeCtrlDbContext;
        }
        public Task<bool> DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUser(User user)
        {
            var userReturn = await takeCtrlDbContext.Users.FindAsync(user.Id);
            return userReturn;            
        }

        public async Task<bool> LoginUser(LoginDto user) 
        {

            //var userReturn = await this.takeCtrlDbContext.Users
            //.FindAsync(user.userName);
            var userReturn = takeCtrlDbContext.Users.FirstOrDefault(userReturn => userReturn.userName == user.UserName);


            if (userReturn != null)
            {
                if (userReturn.Password == user.Password)
                {
                    return true;
                }
            }

            return false;
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
