using System.Collections.Generic;

namespace API_rest.Data.Converter.Contratc
{
    public interface IParser<O, D>
    {
        D Parse(O origin);
        List<D> Parse(List<O> origin);
    }
}
