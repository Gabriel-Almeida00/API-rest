using API_rest.HyperMedia;
using API_rest.HyperMedia.Abstract;
using System.Collections.Generic;

namespace API_rest.Data.VO
{
    public class PersonVO  : ISupportHypermedia
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
