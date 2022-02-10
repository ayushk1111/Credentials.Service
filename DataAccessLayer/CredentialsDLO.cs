using Credentials.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Credentials.Service.DataAccessLayer
{
    public class CredentialsDLO : ICredentialsDLO
    {
        private readonly CredentialsDbContext _credentialsDbContext;

        public CredentialsDLO(CredentialsDbContext credentialsDbContext)
        {
            _credentialsDbContext = credentialsDbContext;
        }

        public List<CredentialsResponse> GetUserCredentials(int userID)
        {
            List<CredentialsResponse> credentialsResponse = (from d in _credentialsDbContext.UserCredentials
                                                     join a in _credentialsDbContext.UserAccounts
                                                     on d.AccountID equals a.AccountID
                                                     where a.UserID == userID
                                                     select new CredentialsResponse()
                                                     {
                                                         LoginID = d.LoginID,
                                                         Password = d.Password,
                                                         Pin = d.Pin,
                                                         AccountName = a.AccountName
                                                     }).ToList();

            return credentialsResponse;
        }

        public User GetUser(int userID)
        {
            User user = _credentialsDbContext.Users.Single(m => m.UserID == userID);
            return user;
        }
    }
}
