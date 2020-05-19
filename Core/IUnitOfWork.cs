using System;
using System.Threading.Tasks;
using WebApiSkeleton.Core.Repositories;

namespace WebApiSkeleton.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository User { get; }
        IProjectRepository Projects { get; }
        IWebApiSkeletonContactRepository WebApiSkeletonContacts { get; }
        IWebApiSkeletonsRepository WebApiSkeletons { get; }
        IPersonRepository Person { get; }
        int Complete();
        Task<int> CompleteAsync();

    }
}
