using API_rest.Model;
using API_rest.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_rest.Repository.Implementation
{
    public class BookRepositoryImpl : IBookRepository
    {
        private MySqlContext _context;

        public BookRepositoryImpl(MySqlContext context)
        {
            _context = context;
        }

        public List<Book> FindAll()
        {
            return _context.Books.ToList();
        }

        public Book FindById(int id)
        {
            return _context.Books.SingleOrDefault(b => b.id.Equals(id));
        }

        public Book Create(Book book)
        {
            try
            {
                _context.Add(book);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return book;
        }

        public Book Update(Book book)
        {
            if (!Exists(book.id)) return null;

            var result = _context.Books.SingleOrDefault(p => p.id.Equals(book.id));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(book);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return book;
        }

        public void Delete(int id)
        {
            var result = _context.Books.SingleOrDefault(p => p.id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Books.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public bool Exists(int id)
        {
            return _context.Books.Any(p => p.id.Equals(id));
        }
    }
}
