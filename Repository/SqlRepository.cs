using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PolicyApp.Models;

namespace PolicyApp.Repository
{
    public class SqlRepository : ISqlRepository
    {
        public Task<bool> RegisterUser(RegisterModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateLogin(LoginModel login)
        {
            throw new NotImplementedException();
        }
    }
}