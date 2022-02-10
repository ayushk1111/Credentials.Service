using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Credentials.Service.Models;
using Credentials.Service.BusinessLayer;

namespace Credentials.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CredentialsController : ControllerBase
    {
        private readonly ICredentialsBLO _credentialsBLO;
        public CredentialsController(ICredentialsBLO credentialsBLO)
        {
            _credentialsBLO = credentialsBLO;
        }

        [HttpGet]
        [Route("{userID}/credentials")]
        public IActionResult GetUserCredentials([FromRoute] int userID)
        {
            var response = _credentialsBLO.GetUserCredentials(userID);

            return Ok(response);
        }

        [HttpGet]
        [Route("{userID}/user")]
        public IActionResult GetUser([FromRoute] int userID)
        
        
        {
            var response = _credentialsBLO.GetUser(userID);

            return Ok(response);
        }
    }
}
