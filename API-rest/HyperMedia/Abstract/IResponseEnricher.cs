using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace API_rest.HyperMedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutedContext context);
        Task Enrich(ResultExecutedContext context);
    }
}
