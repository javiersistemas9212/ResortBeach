using Microsoft.AspNetCore.Identity;
using ResortWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResortWeb.Helpers
{
    public interface IUserHelper
    {
        Task LogoutAsync();

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task<User> GetUserByEmailAsync(string email);

        Task<SignInResult> ValidatePasswordAsync(User user, string password);
     
        Task<User> AddUser(AddUserViewModel view, string role);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<string> GenerateEmailConfirmationTokenAsync(User user);

        Task<IdentityResult> UpdateUserAsync(User user);

        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);

        Task<User> GetUserByIdAsync(string userId);

        Task<IdentityResult> ConfirmEmailAsync(User user, string token);

        Task CheckRoleAsync(string roleName);


    }
}
