using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApiSkeleton.Core.Domain;

namespace WebApiSkeleton.Persistence
{
    public class WebApiSkeletonContext : DbContext
    {
        public WebApiSkeletonContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Project> Projects { get; protected set; }
        public virtual DbSet<WebApiSkeletons> WebApiSkeletons { get; protected set; }
        public virtual DbSet<WebApiSkeletonContact> WebApiSkeletonContact { get; protected set; }
        public virtual DbSet<Person> Person { get; protected set; }
        public virtual DbSet<User> User { get; protected set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
