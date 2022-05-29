﻿namespace newAlcogolMarket.Models.Entity
{
    public class BasketItem
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserId { get; set; }
    }
}