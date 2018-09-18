using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MongoDB.Bson;
using Nu3.Configuration;
using Nu3.Models;
using Nu3.Services.Interfaces;

namespace Nu3.Services
{
    public class UserHelper : IUserHelper
    {
        private readonly IDataAccessProvider _dataAccess;
        public UserHelper(IDataAccessProvider dataAccess)
        {
			_dataAccess = dataAccess;
		}

        public IEnumerable<User> GetUsersByBeaconId(string id)
        {
            throw new NotImplementedException();
        }

        public void AddUser(User user)
        {
            
            if (user == null)
            {
                throw new ArgumentNullException("User cannot be null");
            }

            if (string.IsNullOrWhiteSpace(user.Firstname))
            {
                throw new ArgumentException("Firstname not valid");
            }

            if (string.IsNullOrWhiteSpace(user.Lastname))
            {
                throw new ArgumentException("Lastname not valid");
            }

            if (string.IsNullOrWhiteSpace(user.SocialSecurityNumber))
            {
                throw new ArgumentException("SocialSecurityNumber not valid");
            }



        }

        public User GetUserById(string id)
        {
            return _dataAccess.Get<User>(new ObjectId(id), DatabaseConfiguration.UsersEntity);
        }

        public IEnumerable<User> GetUsers()
        {
            return _dataAccess.Get<User>(DatabaseConfiguration.UsersEntity);
        }
    }
}
