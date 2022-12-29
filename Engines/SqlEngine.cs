using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PolicyApp.Models;
using PolicyApp.Repository;

namespace PolicyApp.Engines
{
    public class SqlEngine : ISqlEngine
    {
        private readonly ISqlRepository repo;
        public SqlEngine(ISqlRepository repo)
        {
            this.repo = repo;
            
        }

        public Task<bool> RegisterUser(RegisterModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateLogin(LoginModel model)
        {
            throw new NotImplementedException();
        }
    }
}