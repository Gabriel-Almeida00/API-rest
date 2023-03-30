using API_rest.Data.Converter.Contratc;
using API_rest.Data.VO;
using API_rest.Model;
using System.Collections.Generic;
using System.Linq;

namespace API_rest.Data.Converter.Implementation
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {   
        public Book Parse(BookVO origin)
        {
            if (origin is null) return null;
            return new Book
            {
                Id = origin.Id,
                author = origin.author,
                launchDate = origin.launchDate,
                price = origin.price,
                title = origin.title
            };
        }

        public BookVO Parse(Book origin)
        {
            if (origin is null) return null;
            return new BookVO
            {
                Id = origin.Id,
                author = origin.author,
                launchDate = origin.launchDate,
                price = origin.price,
                title = origin.title
            };
        }

        public List<Book> Parse(List<BookVO> origin)
        {
            if (origin is null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<BookVO> Parse(List<Book> origin)
        {
            if (origin is null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
