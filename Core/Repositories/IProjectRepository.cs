using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiSkeleton.Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSkeleton.Core.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<ActionResult<Project>> GetProjectAsync(long id);
        Task<ActionResult<IEnumerable<Project>>> GetProjectsAsync();
    }
}
