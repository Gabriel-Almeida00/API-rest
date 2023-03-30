using System.ComponentModel.DataAnnotations.Schema;

namespace API_rest.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
