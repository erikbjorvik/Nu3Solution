using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nu3.Models;

namespace Nu3.Services.Interfaces
{
    public interface IUserHelper
    {

        IEnumerable<User> GetUsersByBeaconId(string id);

        void AddUser(User user);

        User GetUserById(string id);

        IEnumerable<User> GetUsers();

    }
}
