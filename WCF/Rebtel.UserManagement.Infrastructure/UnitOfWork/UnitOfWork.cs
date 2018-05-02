using Rebtel.UserManagement.Infrastructure.Repository;

namespace Rebtel.UserManagement.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UserManagementDBContext Dbcontext;
        public UnitOfWork(UserManagementDBContext dbcontext)
        {
            Dbcontext = dbcontext;
        }
        public void Commit()
        {
            Dbcontext.SaveChanges();
        }
    }
}
