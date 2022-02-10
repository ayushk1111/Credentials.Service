using Credentials.Service.DataAccessLayer;
using Credentials.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Credentials.Service.BusinessLayer
{
    public class CredentialsBLO : ICredentialsBLO
    {
        private readonly ICredentialsDLO _credentialsDLO;
        public CredentialsBLO(ICredentialsDLO credentialsDLO)
        {
            _credentialsDLO = credentialsDLO;
        }

        public List<CredentialsResponse> GetUserCredentials(int userID)
        {
            var response = _credentialsDLO.GetUserCredentials(userID);

            return response;
        }

        public User GetUser(int userID)
        {
            var response = _credentialsDLO.GetUser(userID);

            return response;
        }
    }
}
