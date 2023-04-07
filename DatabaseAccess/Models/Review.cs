using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClothingAppAPI.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int Rating { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
