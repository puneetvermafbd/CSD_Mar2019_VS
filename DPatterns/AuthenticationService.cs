using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns
{
    public interface IAuthenticationService
    {
        bool Authenticate(IUserInfo user);
    }

    public class AuthenticationService : IAuthenticationService
    {
        private readonly IDao dao;

        public AuthenticationService(IDao dao)
        {
            this.dao = dao;
        }

        public bool Authenticate(IUserInfo user)
        {
            var data = dao.GetUserByName(user.Name);

            if(data.Password == user.Password)
            {
                return true;
            }

            return false;
        }       
    }
}
