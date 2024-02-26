using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class RequestLog
    {
        [Key]
        public Guid Id { get; set; }
        public string? Method { get; set; }
        public string? Body { get; set; }
        public string? Path { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}
