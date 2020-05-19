using WebApiSkeleton.Core.Domain;
using WebApiSkeleton.Core.Domain.Users;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApiSkeleton.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User SignIn(string email, string password, string appKey);

        Task<ActionResult<List<Information>>> GetUsersAsync(long projectId);
        Task<ActionResult<Information>> GetUserAsync(long projectId);

        void Register(Register user);
        void ModifyUser(Register user);


        User ResetPassword(string email);
        User GetById(long id);
        User Create(User user, string password);
    }
}
