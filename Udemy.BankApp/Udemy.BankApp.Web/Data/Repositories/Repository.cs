using System.Collections.Generic;
using System.Linq;
using Udemy.BankApp.Web.Data.Context;
using Udemy.BankApp.Web.Data.Interfaces;

namespace Udemy.BankApp.Web.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly BankContext _context;

        public Repository(BankContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();

        }
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();

        }

        public List<T> GetAll()
        {

            return _context.Set<T>().ToList();
        }


        public T GetById(int id)
        {

            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {

            _context.Set<T>().Update(entity);
            _context.SaveChanges();

        }
    }
}
