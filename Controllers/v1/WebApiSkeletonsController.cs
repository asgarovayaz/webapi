using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiSkeleton.Core;
using WebApiSkeleton.Core.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSkeleton.Controllers.v1
{
    [Route("[controller]")]
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    public class WebApiSkeletonsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public WebApiSkeletonsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //webApiSkeletons/project/{projectid}
        [HttpGet("project/{projectId}")]
        public async Task<ActionResult<IEnumerable<WebApiSkeletons>>> GetWebApiSkeletons(long projectId)
        {
            return await _unitOfWork.WebApiSkeletons.GetWebApiSkeletonsAsync(projectId);
        }

        //webApiSkeletons/{webApiSkeletonId}
        [HttpGet("{webApiSkeletonId}")]
        public async Task<ActionResult<WebApiSkeletons>> GetWebApiSkeleton(long webApiSkeletonId)
        {
            return await _unitOfWork.WebApiSkeletons.GetWebApiSkeletonAsync(webApiSkeletonId);
        }

        //webApiSkeletons/contacts/{webApiSkeletonId}
        [HttpGet("contacts/{hotelId}")]
        public async Task<ActionResult<IEnumerable<WebApiSkeletonContact>>> GetWebApiSkeletonContacts(long webApiSkeletonId)
        {
            return await _unitOfWork.WebApiSkeletonContacts.GetWebApiSkeletonContactsAsync(webApiSkeletonId);
        }

        //webApiSkeletons/contacts
        [HttpPost("contacts")]
        public async Task<ActionResult<WebApiSkeletonContact>> CreateContacts([FromBody]WebApiSkeletonContact webApiSkeletonContact)
        {
            _unitOfWork.WebApiSkeletonContacts.Add(webApiSkeletonContact);

            await _unitOfWork.CompleteAsync();

            return Ok(webApiSkeletonContact);
        }

    }
}