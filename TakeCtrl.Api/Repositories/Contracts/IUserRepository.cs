﻿using TakeCtrl.Api.Entities;
using TakeCtrl.Api.Models.Dtos;

namespace TakeCtrl.Api.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task<User> GetUser(User user);
        Task<IEnumerable<User>> GetUsers();
        Task<bool> DeleteUser(User user);
        Task<User> LoginUser(LoginDto user);
        Task<User> AddUser(User user);
        Task<Feedback> PostFeedback(Feedback feedback);
        Task<IEnumerable<Feedback>> GetAllFeedbacks();
        Task<User> DeleteUser(int id);
    }
}
