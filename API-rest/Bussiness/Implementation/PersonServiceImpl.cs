using API_rest.Data.Converter.Implementation;
using API_rest.Data.VO;
using API_rest.Model;
using API_rest.Repository.Generic;
using System.Collections.Generic;

namespace API_rest.Bussiness.Implementation
{
    public class PersonServiceImpl : IPersonService
    {
        private readonly IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonServiceImpl(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }


        public PersonVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
          _repository.Delete(id);

        }
    }
}
