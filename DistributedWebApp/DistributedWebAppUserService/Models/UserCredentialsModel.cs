using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistributedWebAppUsersService.Models
{
    public struct UserCredentialsModel
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }

        public UserCredentialsModel(string _nickname, string _password, string _email)
        {
            Nickname = _nickname;
            Password = _password;
            EmailAddress = _email;
        }
    }
}
