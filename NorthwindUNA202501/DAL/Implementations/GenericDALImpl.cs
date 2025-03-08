using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Entities.Entities;

namespace DAL.Implementations
{
    public class GenericDALImpl<T> : IGenericDAL<T> where T : class
    {

        NorthWindContext _context;


        public GenericDALImpl(NorthWindContext context)
        {
            _context = context;
        }

        public bool Add(T entity)
        {
            try
            {
                _context.Add(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public T FindById(int id)
        {
            return _context.Set<T>().Find(id) ;
        }

        public List<T> Get()
        {
            var result =_context.Set<T>().ToList();
            return result;
        }

        public bool Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
