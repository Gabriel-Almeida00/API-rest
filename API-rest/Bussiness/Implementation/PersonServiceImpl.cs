using API_rest.Model;
using API_rest.Model.Context;
using API_rest.Repository;
using API_rest.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace API_rest.Bussiness.Implementation
{
    public class PersonServiceImpl : IPersonService
    {
        private readonly IRepository<Person> _repository;

        public PersonServiceImpl(IRepository<Person> repository)
        {
            _repository = repository;
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }


        public Person FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public Person Update(Person person)
        {
          return _repository.Update(person);
        }

        public void Delete(long id)
        {
          _repository.Delete(id);

        }
    }
}
