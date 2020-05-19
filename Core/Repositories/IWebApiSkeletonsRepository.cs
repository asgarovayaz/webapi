using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiSkeleton.Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSkeleton.Core.Repositories
{
    public interface IWebApiSkeletonsRepository : IRepository<WebApiSkeletons>
    {
        Task<ActionResult<IEnumerable<WebApiSkeletons>>> GetWebApiSkeletonsAsync(long projectId);
        Task<ActionResult<WebApiSkeletons>> GetWebApiSkeletonAsync(long webApiSkeletonId);
    }
}
