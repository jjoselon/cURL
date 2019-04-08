using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCapplicacion.Models
{
    public class Binnacle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string BinnacleType { get; set; }
        public DateTime PublishDate { get; set; }
        // see https://docs.microsoft.com/es-es/ef/core/modeling/relationships
        // navigation properties
        public ICollection<Tag> Tags { get; set; }

    }
}
