using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sandysukma_fdtest.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string ThumbnailUrl { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public DateTime UploadedAt { get; set; } = DateTime.Now;

        [ForeignKey("User")]
        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}
