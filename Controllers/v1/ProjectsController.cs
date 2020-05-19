using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSkeleton.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiSkeleton.Core.Domain;
using WebApiSkeleton.Persistence;
using Microsoft.AspNetCore.Authorization;

namespace WebApiSkeleton.Controllers.v1
{
    [Route("[controller]")]
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    public class ProjectsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
        {

            return await _unitOfWork.Projects.GetProjectsAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProject(long id)
        {
            return await _unitOfWork.Projects.GetProjectAsync(id);
        }


        [HttpPost]
        public async Task<ActionResult<Project>> CreateProject([FromBody]Project project)
        {
             _unitOfWork.Projects.Add(project);
            
            await _unitOfWork.CompleteAsync();

            return Ok(project);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Project>> ModifyProject(long id, [FromBody]Project project)
        {
            _unitOfWork.Projects.Modify(project);

            await _unitOfWork.CompleteAsync();

            return Ok(project);
        }

    }
}
