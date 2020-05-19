
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
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(WebApiSkeletonContext context) : base(context) { }
       

        public WebApiSkeletonContext WebApiSkeletonContext => Context as WebApiSkeletonContext;

        public Task<ActionResult<Person>> GetPersonAsync(long personId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<Person>>> GetPersonsAsync(long webApiSkeletonId)
        {
            throw new NotImplementedException();
        }
    }
}
