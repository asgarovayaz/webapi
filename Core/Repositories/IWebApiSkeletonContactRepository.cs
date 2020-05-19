using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiSkeleton.Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSkeleton.Core.Repositories
{
    public interface IWebApiSkeletonContactRepository : IRepository<WebApiSkeletonContact>
    {
        Task<ActionResult<IEnumerable<WebApiSkeletonContact>>> GetWebApiSkeletonContactsAsync(long webApiSkeletonId);
    }
}
