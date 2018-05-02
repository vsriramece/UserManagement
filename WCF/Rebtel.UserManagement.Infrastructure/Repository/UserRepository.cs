using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebtel.UserManagement.Domain.Entities;
using System.Linq;

namespace Rebtel.UserManagement.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManagementDBContext DbContext;
        public IQueryable<User> AggregateStates => DbContext.Users.AsQueryable();

        public UserRepository(UserManagementDBContext dbcontext)
        {
            DbContext = dbcontext;
        }

        public User Create()
        {
            User user = new User();
            user.Id = Guid.NewGuid();
            DbContext.Users.Add(user);
            return user;
        }

        public void Delete(User user)
        {
            DbContext.Users.Remove(user);
        }

        public User GetById(Guid id)
        {
            return DbContext.Users.FirstOrDefault(o=>o.Id ==id);
        }

        public IEnumerable<User> GetAll()
        {
            // Need to implement batching/pagination to handle large count
            return DbContext.Users;
        }

        public Subscription GetSubscriptionById(Guid id)
        {
            return DbContext.Subscriptions.FirstOrDefault(s => s.Id == id);
        }
    }
}
