using Credentials.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Credentials.Service.BusinessLayer
{
    public interface ICredentialsBLO
    {
        List<CredentialsResponse> GetUserCredentials(int userID);

        User GetUser(int userID);
    }
}
