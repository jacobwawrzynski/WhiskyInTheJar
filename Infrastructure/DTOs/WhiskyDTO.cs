using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DTOs
{
    public class WhiskyDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Stars Stars { get; set; }
    }
}
