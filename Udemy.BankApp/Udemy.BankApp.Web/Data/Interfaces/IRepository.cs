using System.Collections.Generic;

namespace Udemy.BankApp.Web.Data.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {

        void Create(T entity);
        void Remove(T entity);

        List<T> GetAll();

        T GetById(int id);
        void Update(T entity);

    }
}
