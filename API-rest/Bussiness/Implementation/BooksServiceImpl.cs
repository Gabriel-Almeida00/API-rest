using API_rest.Model;
using API_rest.Repository;
using System.Collections.Generic;

namespace API_rest.Bussiness.Implementation
{
    public class BooksServiceImpl
    {
        private readonly IBookRepository bookRepository;

        public BooksServiceImpl(IBookRepository _bookRepository)
        {
            bookRepository = _bookRepository;
        }

        public List<Book> FindAll()
        {
            return bookRepository.FindAll();
        }

        public Book FindByID(int id)
        {
            return bookRepository.FindById(id);
        }

        public Book Create(Book book)
        {
            return bookRepository.Create(book);
        }

        public Book Update(Book book)
        {
            return bookRepository.Update(book);
        }

        public void Delete(int id)
        {
            bookRepository.Delete(id);

        }
    }
}
