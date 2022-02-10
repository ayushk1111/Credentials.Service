using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Credentials.Service.Models
{
    public class CredentialsResponse
    {
        public string LoginID { get; set; }
        public string Password { get; set; }
        public string Pin { get; set; }
        public string AccountName { get; set; }
    }
}
