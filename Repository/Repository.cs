using DataAccess;
using DataAccess.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationRepository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDBContext _context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(AppDBContext _context)
        {
            this._context = _context;
            entities = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return entities.AsQueryable();
        }

        public T Get(int id, bool Status = true)
        {
            return entities.FirstOrDefault(x => x.Id == id && (x.Status || !Status));
        }

        public IEnumerable<T> Filter(Expression<Func<T, bool>> filter)
        {
            return entities.Where(filter);
        }

        public void Insert(T entity, bool saveChange = true)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.CreatedTime = DateTime.Now;
            entity.UpdatedTime = DateTime.Now;

            entities.Add(entity);

            if (saveChange)
            {
                _context.SaveChanges();
            }
        }

        public void Update(T entity, bool saveChange = true)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entity.UpdatedTime = DateTime.Now;

            entities.Update(entity);

            if (saveChange)
            {
                _context.SaveChanges();
            }
        }

        public void Delete(T entity, bool saveChange = true)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }


            entities.Remove(entity);

            if (saveChange)
            {
                _context.SaveChanges();
            }
        }
    }
}
