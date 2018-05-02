using Rebtel.UserManagement.Domain.Entities;
using System.Data.Entity;

namespace Rebtel.UserManagement.Infrastructure.Repository
{
    public class UserManagementDBContext: DbContext
    {
        public virtual IDbSet<User> Users { get; set; }
        public virtual IDbSet<Subscription> Subscriptions { get; set; }
        public UserManagementDBContext():base("Db:UserManagement")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
