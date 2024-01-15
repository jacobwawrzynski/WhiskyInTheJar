using Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public class Whisky : BaseEntity
    {
        public Stars Stars { get; set; } = Stars.None;
    }
}
