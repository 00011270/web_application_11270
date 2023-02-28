using CWClothingAppAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWClothingAppAPI.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Double Balance { get; set; }
        public CardStatus Status { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
