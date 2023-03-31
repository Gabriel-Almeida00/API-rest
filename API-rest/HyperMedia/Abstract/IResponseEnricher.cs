using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace API_rest.HyperMedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutingContext context);
        Task Enrich(ResultExecutingContext context);
    }
}
