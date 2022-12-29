using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PolicyApp.Models;

namespace PolicyApp.Engines
{
    public interface ISqlEngine
    {
        Task<bool> ValidateLogin(LoginModel model);
        Task<bool> RegisterUser(RegisterModel model);
    }
}