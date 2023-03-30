using API_rest.Data.VO;
using System.Collections.Generic;

namespace API_rest.Bussiness
{
    public interface IPersonService
    {
        PersonVO Create(PersonVO person);
        PersonVO FindByID(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}
