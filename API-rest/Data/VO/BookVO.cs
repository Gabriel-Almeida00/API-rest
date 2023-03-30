using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace API_rest.Data.VO
{
    public class BookVO
    {
        public long Id { get; set; }

        public string author { get; set; }

        [DataType(DataType.Date)]
        public DateTime launchDate { get; set; }

        public Decimal price { get; set; }

        public string title { get; set; }
    }
}
