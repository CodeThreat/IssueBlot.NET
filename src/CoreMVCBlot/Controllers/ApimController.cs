using CoreMVCBlot.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCBlot.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApimController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<User> Get(string redirect)
        {
            
            if (!String.IsNullOrEmpty(redirect))
            {
                // CTSECNONISSUE:OpenRedirect
                // return Redirect(Url.Content("~/") + "#gotourl=" + redirect);
            }
            
            return Enumerable.Range(1, 5).Select(index => new User
            {
            })
            .ToArray();
        }
    }
}