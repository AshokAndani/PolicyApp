using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PolicyApp.Models;

namespace PolicyApp.Repository
{
    public interface ISqlRepository
    {
        Task<bool> ValidateLogin(LoginModel login);
        Task<bool> RegisterUser(RegisterModel model);
    }
}