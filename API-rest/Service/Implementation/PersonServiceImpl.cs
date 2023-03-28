using API_rest.Model;
using API_rest.Model.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace API_rest.Service.Implementation
{
    public class PersonServiceImpl : IPersonService
    {
        private MySqlContext _context;

        public PersonServiceImpl(MySqlContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            return person;
        }
   
        public void Delete(long id)
        {
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

     
        public Person FindByID(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Leandro",
                LastName = "Costa",
                Address = "Uberlandia - Minas Gerais - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
