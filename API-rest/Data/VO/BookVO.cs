using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using API_rest.HyperMedia.Abstract;
using System.Collections.Generic;
using API_rest.HyperMedia;

namespace API_rest.Data.VO
{
    public class BookVO : ISupportHypermedia
    {
        public long Id { get; set; }

        public string author { get; set; }

        [DataType(DataType.Date)]
        public DateTime launchDate { get; set; }

        public Decimal price { get; set; }

        public string title { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
