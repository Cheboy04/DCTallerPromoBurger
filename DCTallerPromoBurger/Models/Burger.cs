﻿using System.ComponentModel.DataAnnotations;

namespace DCTallerPromoBurger.Models
{
    public class Burger
    {
        public int BurgerID { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 99.99)]
        public decimal Price { get; set; }
        public List<Promo>? Promos { get; set; }

    }
}
