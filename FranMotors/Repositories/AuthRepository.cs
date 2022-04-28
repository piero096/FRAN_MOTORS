using FranMotors.DB;
using FranMotors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FranMotors.Repositories
{

    public interface IAuthRepository
    {
        Account Login(string Username, string Password);
    }
    public class AuthRepository : IAuthRepository
    {
        private FranMotorsContext context;
        public AuthRepository(FranMotorsContext context)
        {
            this.context = context;
        }
        public Account Login(string Username, string Password)
        {
            return context.Accounts
                .Where(o => o.Username == Username && o.Password == Password).FirstOrDefault();
        }
    }
}
