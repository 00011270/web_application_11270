﻿using ClothingAppAPI.DPattern;
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
        public string Name { get; set; }
        public string Description { get; set; }
        public Double Price { get; set; }
        public int Quantity { get; set; }
        public Size Size { get; set; }
        public GenderTypeEnum Gender { get; set; }
        public ProductStatus Status { get; set; }
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
