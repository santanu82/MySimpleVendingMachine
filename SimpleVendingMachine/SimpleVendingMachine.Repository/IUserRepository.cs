using SimpleVendingMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVendingMachine.Repository
{
    public interface IUserRepository
    {
        List<User> GetUsers();

        User GetUser(int userId);

        User UpdateUser(int userId, int pinNumber, int numberOfCansUserWantsToBuy);
    }
}
