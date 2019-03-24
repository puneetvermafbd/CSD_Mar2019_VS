using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns
{
    public interface IDao
    {
        IUserInfo GetUserByName(string userName);
    }
    public class Dao : IDao
    {
        public IUserInfo GetUserByName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
