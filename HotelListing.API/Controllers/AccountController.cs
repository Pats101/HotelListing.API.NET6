using HotelListing.API.Core.Contracts;
using HotelListing.API.Core.Exceptions;
using HotelListing.API.Core.Models.Users;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace HotelListing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAuthManager _authManager;
        private readonly ILogger<AccountController> _logger;
        public AccountController(IAuthManager authManager, ILogger<AccountController> logger)
        {
            _authManager = authManager;
        }
        // api/account/register
        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult>Register([FromBody] ApiUserDto apiUserDto) 
        {
            var errors = await _authManager.Register(apiUserDto);

            if (errors.Any())
            {
                foreach (var error in errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                throw new BadRequestException(nameof(Register), apiUserDto.Email);
                //return BadRequest(ModelState);
            }
            return Ok();
        }
        // api/account/register
        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Login([FromBody] LoginDto loginDto)
        {
            var authResponse = await _authManager.Login(loginDto);

            if (authResponse == null)
            {
                return Unauthorized();
            }
            return Ok(authResponse);
        }

        // api/account/refreshtoken
        [HttpPost]
        [Route("refreshtoken")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> RefreshToken([FromBody] AuthResponseDto request)
        {
            var authResponse = await _authManager.VerifyRefreshToken(request);
            if (authResponse == null)
            {
                return Unauthorized();
            }
            return Ok(authResponse);
        }
    }
}
