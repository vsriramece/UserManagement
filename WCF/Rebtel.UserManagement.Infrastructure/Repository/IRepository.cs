using System;
using System.Collections.Generic;

namespace Rebtel.UserManagement.Infrastructure.Repository
{
    public interface IRepository<T>
    {
        T Create();
        void Delete(T entity);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
    }
}
