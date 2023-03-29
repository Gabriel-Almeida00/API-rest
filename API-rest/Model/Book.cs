using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_rest.Model
{
    [Table("books")]
    public class Book
    {
        [Column("id")]
        public int id { get; set; }

        [Column("author")]
        public string author { get; set; }

        [Column("launch_date")]
        [DataType(DataType.Date)]
        public DateTime launchDate { get; set; }

        [Column("price" , TypeName ="decimal(65,2)")]
        public Decimal price { get; set; }

        [Column("title")]
        public string title { get; set; }
    }
}
