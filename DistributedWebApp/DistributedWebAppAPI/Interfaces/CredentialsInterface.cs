﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistributedWebAppAPI.Interfaces
{
    public interface ICredentialsInterface
    {
        public string ApiPassword
            => Environment.GetEnvironmentVariable(
                "api_PrivateKey",
                EnvironmentVariableTarget.Machine);
        public string DbName
            => Environment.GetEnvironmentVariable(
                "db_DatabaseName",
                EnvironmentVariableTarget.Machine);
        public string DbUser
            => Environment.GetEnvironmentVariable(
                "db_Username",
                EnvironmentVariableTarget.Machine);
        public string DbPassword
            => Environment.GetEnvironmentVariable(
                "db_Password",
                EnvironmentVariableTarget.Machine);
        public string DbAddress
            => Environment.GetEnvironmentVariable(
                "db_Address",
                EnvironmentVariableTarget.Machine);

    }
}
