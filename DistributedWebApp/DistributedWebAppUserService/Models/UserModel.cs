using System;
using System.Collections.Generic;
using DistributedWebAppUsersService.Tools;

namespace DistributedWebAppUsersService.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public UserType UserType { get; set; }
        public List<LocationDataModel> Locations { get; set; }
        public DateTime Joined { get; set; }
        public Uri Avatar { get; set; }
        public int Rank { get; set; }
        public int Points { get; set; }
        public bool IsPremiumUser { get; set; }
        public bool IsBanned { get; set; }
        public List<UserModel> Observing { get; set; }
        public List<UserModel> Observed { get; set; }
        public List<UserModel> BlockedUsers { get; set; }
#nullable enable
        public int? Age { get; set; }

#nullable disable

        public UserModel() { }
    }
}

