using MessageApp.DataAccessLayer.Abstract;
using MessageApp.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageApp.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        MessageAppContext context = new MessageAppContext();
        public void Delete ( int id )
        {
           var values =context.Set<T>().Find(id);
            context.Set<T>().Remove(values);
            context.SaveChanges();
        }

        public T GetbyId ( int id )
        {
           return context.Set<T>().Find(id);
        }

        public List<T> GetlistAll ()
        {
            return context.Set<T>().ToList();

         }

        public void Insert ( T entity )
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update ( T entity )
        {     
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}
