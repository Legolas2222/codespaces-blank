using Microsoft.AspNetCore.Mvc;
using TodoistClone.Application.Services.Authentication.Commands;
using TodoistClone.Application.Services.Authentication.Queries;
using TodoistClone.Contracts.Authentication;

namespace TodoistClone.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController(
        IAuthenticationCommandService authenticationCommandService,
        IAuthenticationQueryService authenticationQueryService) : ControllerBase
    {
        private readonly IAuthenticationCommandService _authenticationCommandService = authenticationCommandService;
        private readonly IAuthenticationQueryService _authenticationQueryService = authenticationQueryService;

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            var authResult = _authenticationCommandService.Register(
                request.FirstName,
                request.LastName,
                request.Email,
                request.Password);

            var response = new AuthenticationResponse(
                authResult.User.Id,
                authResult.User.FirstName,
                authResult.User.LastName,
                authResult.User.Email,
                authResult.Token);

            return Ok(response);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var authResult = _authenticationQueryService.Login(
                request.Email,
                request.Password);

            var response = new AuthenticationResponse(
                authResult.User.Id,
                authResult.User.FirstName,
                authResult.User.LastName,
                authResult.User.Email,
                authResult.Token);

            return Ok(response);
        }
    }
}
