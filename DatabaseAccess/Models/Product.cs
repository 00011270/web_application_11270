using ClothingAppAPI.DPattern;
using ClothingAppAPI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingAppAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Range(1, int.MaxValue)]
        public Double Price { get; set; }
        [Range(1, 100)]
        public int Quantity { get; set; }
        [Required]
        public Size Size { get; set; }
        [Required]
        public GenderTypeEnum Gender { get; set; }
        [Required]
        public ProductStatus Status { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public List<Review> Reviews { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        /*public override Prototype Clone()
        {
            return new Product
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description,
                Price = this.Price,
                Quantity = this.Quantity,
                Size = this.Size,
                Gender = this.Gender,
                Status = this.Status,
                CreatedAt = this.CreatedAt,
                UpdatedAt = this.UpdatedAt
            };
        }*/
    }
}
