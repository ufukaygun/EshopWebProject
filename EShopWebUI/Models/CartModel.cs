﻿using System.ComponentModel.DataAnnotations;

namespace EShopWebUI.Models
{
    public class CartModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public int UserId { get; set; }
    }
}
