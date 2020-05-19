using AutoMapper;
using WebApiSkeleton.Core;
using WebApiSkeleton.Core.Repositories;
using WebApiSkeleton.Persistence.Repositories;
using System.Threading.Tasks;

namespace WebApiSkeleton.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WebApiSkeletonContext _context;
        private IMapper _mapper;

        public UnitOfWork(WebApiSkeletonContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

            User = new UserRepository(_context, _mapper);
            Projects = new ProjectRepository(_context);
            WebApiSkeletonContacts = new WebApiSkeletonContactRepository(_context);
            WebApiSkeletons = new WebApiSkeletonsRepository(_context);
            Person = new PersonRepository(_context);
        }

        public IUserRepository User { get; private set; }
        public IProjectRepository Projects { get; private set; }
        public IWebApiSkeletonContactRepository WebApiSkeletonContacts { get; private set; }
        public IWebApiSkeletonsRepository WebApiSkeletons { get; private set; }
        public IPersonRepository Person { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
