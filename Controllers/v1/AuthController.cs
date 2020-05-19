using System;
using System.Threading.Tasks;
using AutoMapper;
using WebApiSkeleton.Core;
using WebApiSkeleton.Core.Domain;
using WebApiSkeleton.Core.Domain.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebApiSkeleton.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("[controller]")]
    [Authorize]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AuthController(IUnitOfWork unitOfWork,IMapper mapper, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configuration = configuration;
        }

        /// <summary>
        /// Sign in to application. 
        /// </summary>
        [AllowAnonymous]
        [HttpPost("signin")]
        public IActionResult Signin([FromBody]Auth auth)
        {
            User user = _unitOfWork.User.SignIn(auth.Email, auth.Password, _configuration["ApplicationInformation:Secret"]);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });
            
            return Ok(new { Id = user.Id,  Username = user.Email, FirstName = user.FirstName, LastName = user.LastName, Token = user.Token });
        }

        /// <summary>
        /// When user forgot password
        /// </summary>
        [AllowAnonymous]
        [HttpPost("forgot-password")]
        public IActionResult ForgotPassword([FromBody]Auth auth)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// User reset password
        /// </summary>
        [AllowAnonymous]
        [HttpPost("reset-password")]
        public IActionResult ResetPassword([FromBody]Auth auth)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// User verify account via Verification link
        /// </summary>
        [AllowAnonymous]
        [HttpGet("verify/{verificationGUID}")]
        public async Task<ActionResult<Verify>> VerifyUser(Guid verificationGUID)
        {
            throw new NotImplementedException();
        }
    }
}