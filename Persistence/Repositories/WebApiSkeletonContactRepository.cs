using WebApiSkeleton.Core.Domain;
using WebApiSkeleton.Core.Repositories;
using System.Collections.Generic;
using WebApiSkeleton.Persistence.Repositories;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSkeleton.Persistence
{
    public class WebApiSkeletonContactRepository : Repository<WebApiSkeletonContact>,IWebApiSkeletonContactRepository
    {
        public WebApiSkeletonContactRepository(WebApiSkeletonContext context) : base(context) { }

        public WebApiSkeletonContext WebApiSkeletonContext => Context as WebApiSkeletonContext;

        public Task<ActionResult<IEnumerable<WebApiSkeletonContact>>> GetWebApiSkeletonContactsAsync(long webApiSkeletonId)
        {
            throw new System.NotImplementedException();
        }
    }

    

}
