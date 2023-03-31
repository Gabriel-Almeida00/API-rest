using System.Collections.Generic;

namespace API_rest.HyperMedia.Abstract
{
    public interface ISupportHypermedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
