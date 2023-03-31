using API_rest.HyperMedia.Abstract;
using System.Collections.Generic;

namespace API_rest.HyperMedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentRespponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
