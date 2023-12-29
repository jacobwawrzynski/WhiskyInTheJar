using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DTOs
{
    public class ItemDTO
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Comment { get; set; }
        public Stars Stars { get; set; }
        public DateTime DateAdded { get; set; }
        public Guid? PhotoId { get; set; }
    }
}
