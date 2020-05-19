using WebApiSkeleton.Core.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSkeleton.Core.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<ActionResult<IEnumerable<Person>>> GetPersonsAsync(long webApiSkeletonId);
        Task<ActionResult<Person>> GetPersonAsync(long personId);
    }
}
