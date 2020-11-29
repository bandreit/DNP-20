using System;
using System.Threading.Tasks;
using A1_DNP1Y.Data;
using A1_DNP1Y.Data.Impl;
using A1_DNP1Y.Models;
using Microsoft.AspNetCore.Mvc;

namespace DNP_A3_Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticateController : ControllerBase
    {
        private IUserService _inMemoryUserService;

        public AuthenticateController(IUserService inMemoryUserService)
        {
            _inMemoryUserService = inMemoryUserService;
        }

        [HttpGet]
        public async Task<ActionResult<User>> ValidateUser([FromQuery] string userName, [FromQuery] string password)
        {
            try
            {
                User user = await _inMemoryUserService.ValidateUser(userName, password);
                
                if (user == null)
                {
                    return NotFound();
                }

                if (!user.Password.Equals(password))
                {
                    return Unauthorized(password);
                }

                return Ok(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}