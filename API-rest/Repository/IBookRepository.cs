using API_rest.Model;
using System.Collections.Generic;

namespace API_rest.Repository
{
    public interface IBookRepository
    {
        Book Create(Book book);
        Book FindById(int id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(int id);
        bool Exists(int id);
    }
}
