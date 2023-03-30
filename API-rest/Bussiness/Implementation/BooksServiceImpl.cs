using API_rest.Data.Converter.Implementation;
using API_rest.Data.VO;
using API_rest.Model;
using API_rest.Repository.Generic;
using System.Collections.Generic;

namespace API_rest.Bussiness.Implementation
{
    public class BooksServiceImpl
    {
        private readonly IRepository<Book> _repository;
        private readonly BookConverter _converter;  

        public BooksServiceImpl(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        public List<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public BookVO FindByID(int id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        public BookVO Create(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            return _converter.Parse(bookEntity);
        }

        public BookVO Update(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);

        }
    }
}
