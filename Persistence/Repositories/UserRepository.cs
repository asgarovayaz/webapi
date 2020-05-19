using AutoMapper;
using WebApiSkeleton.Core.Domain;
using WebApiSkeleton.Core.Domain.Users;
using WebApiSkeleton.Core.Helpers;
using WebApiSkeleton.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSkeleton.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private IMapper _mapper;

        public UserRepository(WebApiSkeletonContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public User SignIn(string email, string password, string appKey)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                return null;

            var requestedUser = WebApiSkeletonContext.User.SingleOrDefault(u => u.Email == email);

            if (requestedUser == null)
                return null;

            if (!UserManage.VerifyPasswordHash(password, requestedUser.PasswordHash, requestedUser.PasswordSalt))
                return null;


            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(appKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] { new Claim(ClaimTypes.Name, requestedUser.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            requestedUser.Token = tokenString;
            return requestedUser;
        }

        public async Task<ActionResult<List<Information>>> GetUsersAsync(long projectId)
        {
            List<User> users = await WebApiSkeletonContext.User.Where(u => u.ProjectId == projectId).ToListAsync();
            return _mapper.Map<List<Information>>(users);
        }

        public async Task<ActionResult<Information>> GetUserAsync(long userId)
        {
            User user = await WebApiSkeletonContext.User.FirstOrDefaultAsync(u => u.Id == userId);
            return _mapper.Map<Information>(user);
        }

        public void Register(Register user)
        {
            throw new NotImplementedException();
        }

        public void ModifyUser(Register user)
        {
            throw new NotImplementedException();
        }

        public User Create(User user, string password)
        {
            // validation
            //  if (string.IsNullOrWhiteSpace(password))
            //      throw new AppException("Password is required");

            //  if (_context.Users.Any(x => x.Username == user.Username))
            //      throw new AppException("Username \"" + user.Username + "\" is already taken");

            byte[] passwordHash, passwordSalt;
            UserManage.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            WebApiSkeletonContext.User.Add(user);
            WebApiSkeletonContext.SaveChanges();

            return user;
        }

        public User ResetPassword(string email)
        {
            throw new NotImplementedException();
        }

        public User GetById(long id) => WebApiSkeletonContext.User.Find(id);

        public WebApiSkeletonContext WebApiSkeletonContext => Context as WebApiSkeletonContext;

    }
}
