
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSkeleton.Core.Domain;
using WebApiSkeleton.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApiSkeleton.Persistence.Repositories
{
    public class WebApiSkeletonsRepository : Repository<WebApiSkeletons>, IWebApiSkeletonsRepository
    {
        public WebApiSkeletonsRepository(WebApiSkeletonContext context) : base(context) { }
       

        public WebApiSkeletonContext WebApiSkeletonContext => Context as WebApiSkeletonContext;

        public Task<ActionResult<WebApiSkeletons>> GetWebApiSkeletonAsync(long webApiSkeletonId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<WebApiSkeletons>>> GetWebApiSkeletonsAsync(long projectId)
        {
            throw new NotImplementedException();
        }
    }
}
