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

        public async Task<User> LoginUser(LoginDto user) 
        {
            var userReturn = takeCtrlDbContext.Users.FirstOrDefault(userReturn => userReturn.userName == user.UserName);


            if (userReturn != null)
            {
                if (userReturn.Password == user.Password)
                {
                    return userReturn;
                }
            }

            return default(User);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await takeCtrlDbContext.Users.ToListAsync();
            return users;
        }

        public async Task<User> AddUser(User user)
        {
            var newUser = await takeCtrlDbContext.AddAsync(user);

            await this.takeCtrlDbContext.SaveChangesAsync();

            return newUser.Entity;
        }

        public async Task<Feedback> PostFeedback(Feedback feedback)
        {
            var newFeedback = await takeCtrlDbContext.Feedbacks.AddAsync(feedback);

            await this.takeCtrlDbContext.SaveChangesAsync();

            return newFeedback.Entity;

        }

        public async Task<IEnumerable<Feedback>> GetAllFeedbacks()
        {
            var result = await takeCtrlDbContext.Feedbacks.ToListAsync();

            return result;
        }

        public async Task<User> DeleteUser(int id)
        {
            var user = await this.takeCtrlDbContext.Users.FindAsync(id);

            if (user != null)
            {
                this.takeCtrlDbContext.Users.Remove(user);
                await this.takeCtrlDbContext.SaveChangesAsync();
            }

            return user;

        }


    }
}
