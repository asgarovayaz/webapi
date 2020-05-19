using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSkeleton.Core;
using WebApiSkeleton.Core.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSkeleton.Controllers.v1
{
    [Route("[controller]")]
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    public class PersonsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PersonsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //persons/webApiSkeleton/{webApiSkeletonid}
        [HttpGet("webApiSkeleton/{webApiSkeletonid}")]
        public async Task<ActionResult<IEnumerable<Person>>> GetPersons(long webApiSkeletonId)
        {
            return await _unitOfWork.Person.GetPersonsAsync(webApiSkeletonId);
        }

        //persons/{personId}
        [HttpGet("{personId}")]
        public async Task<ActionResult<Person>> GetPerson(long personId)
        {
            return await _unitOfWork.Person.GetPersonAsync(personId);
        }

        //persons
        [HttpPost]
        public async Task<ActionResult<Person>> CreatePerson([FromBody]Person person)
        {
            _unitOfWork.Person.Add(person);

            await _unitOfWork.CompleteAsync();

            return Ok(person);
        }

        //persons/{personId}
        [HttpPost("{personId}")]
        public async Task<ActionResult<Person>> ModifyPerson([FromBody]Person person)
        {
            _unitOfWork.Person.Modify(person);

            await _unitOfWork.CompleteAsync();

            return Ok(person);
        }

    }
}