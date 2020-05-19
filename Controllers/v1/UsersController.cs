using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSkeleton.Core;
using WebApiSkeleton.Core.Domain;
using WebApiSkeleton.Core.Domain.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSkeleton.Controllers.v1
{
    [Route("[controller]")]
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //users/project/{projectid}
        [HttpGet("project/{projectId}")]
        public async Task<ActionResult<List<Information>>> GetUsers(long projectId)
        {
            return await _unitOfWork.User.GetUsersAsync(projectId);
        }

        //users/{userId}
        [HttpGet("{userId}")]
        public async Task<ActionResult<Information>> GetUser(long userId)
        {
            return await _unitOfWork.User.GetUserAsync(userId);
        }


        //users/project
        [HttpPost("project")]
        public async Task<ActionResult<Register>> CreateUser([FromBody]Register user)
        {
            _unitOfWork.User.Register(user);

            await _unitOfWork.CompleteAsync();

            return Ok(user);

        }

        //users/project/userId
        [HttpPut("project/{userId}")]
        public async Task<ActionResult<Register>> ModifyUser([FromBody]Register user)
        {
            _unitOfWork.User.ModifyUser(user);

            await _unitOfWork.CompleteAsync();

            return Ok(user);
        }

    }
}