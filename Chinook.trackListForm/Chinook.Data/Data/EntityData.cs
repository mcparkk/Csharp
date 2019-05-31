using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class EntityData<T> where T:Entity
    {
        public string ToLongText()
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                List<T> list = context.Set<T>().ToList();

                StringBuilder builder = new StringBuilder();

                foreach (T entity in list)
                {
                    builder.Append(entity.ToText());
                    builder.Append(", ");
                }

                return builder.ToString();
            }
        }
        
        public int GetCount()
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Artists.Count();
            }
        }

        public int GetCount(Expression<Func<T, bool>> predicate)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Set<T>().Count(predicate);
            }
        }

        public List<R> Select<R>(Expression<Func<T, R>> selector, Expression<Func<T, bool>> predicate = null)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                IQueryable<T> query = context.Set<T>();

                if (predicate != null)
                    query = query.Where(predicate);

                return query.Select(selector).ToList();
                //return context.Set<T>().Select(selector).ToList();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                IQueryable<T> query = context.Set<T>();

                if (predicate != null)
                    query = query.Where(predicate);

                return query.ToList();
            }
        }

        public void Insert(T entity)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                context.Set<T>().Add(entity);
                context.Entry(entity).State = System.Data.Entity.EntityState.Added;

                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;

                context.SaveChanges();
            }
        }
    }
}
