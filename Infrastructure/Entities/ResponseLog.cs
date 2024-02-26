using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class ResponseLog
    {
        [Key]
        public Guid Id { get; set; }
        public int? StatusCode { get; set; }
        public string? Body { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}
