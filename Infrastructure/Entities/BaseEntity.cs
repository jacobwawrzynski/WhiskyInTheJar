﻿using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Length(1, 25)]
        public string Name { get; set; }

        [Length(1, 250)]
        public string Description { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;

        //public Guid? PhotoId { get; set; } // Assign default photo with guid 00...
    }
}
