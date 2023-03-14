using ClothingAppAPI.DAL;
using ClothingAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingAppAPI.Repository
{
    public class CardRepository : Repository<Card>
    {
        private static CardRepository cardRepository;
        public CardRepository(ClothingContext clothingContext) : base(clothingContext)
        {
        }

        public static CardRepository GetInstance(ClothingContext clothing)
        {
            if (cardRepository  == null)
            {
                cardRepository = new CardRepository(clothing);
            }
            return cardRepository;
        }
    }
}
