
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
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(WebApiSkeletonContext context) : base(context) { }
        public async Task<ActionResult<IEnumerable<Project>>> GetProjectsAsync()
        {
            var ret = await WebApiSkeletonContext.Projects.Where(c => c.Status == 1).ToListAsync();



            return ret;
        }

        public async Task<ActionResult<Project>> GetProjectAsync(long projectId)
        {
            return await WebApiSkeletonContext.Projects.FirstOrDefaultAsync(c => c.Status == 1 && c.Id == projectId);
        }

        public WebApiSkeletonContext WebApiSkeletonContext => Context as WebApiSkeletonContext;
    }
}
