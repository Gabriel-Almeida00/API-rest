using API_rest.Model.Base;
using System.Collections.Generic;

namespace API_rest.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        public T Create(T item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public bool Exists(long id)
        {
            throw new System.NotImplementedException();
        }

        public List<T> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public T FindByID(long id)
        {
            throw new System.NotImplementedException();
        }

        public T Update(T item)
        {
            throw new System.NotImplementedException();
        }
    }
}
