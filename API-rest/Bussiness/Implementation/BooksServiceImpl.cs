using API_rest.Model;
using API_rest.Repository.Generic;
using System.Collections.Generic;

namespace API_rest.Bussiness.Implementation
{
    public class BooksServiceImpl
    {
        private readonly IRepository<Book> _repository;

        public BooksServiceImpl(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindByID(int id)
        {
            return _repository.FindByID(id);
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);

        }
    }
}
