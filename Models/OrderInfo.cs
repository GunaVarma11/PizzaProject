﻿namespace Project_pizza.Models
{
    public class OrderInfo : Pizza
    {
        public int OrderId { get; set; }

        public int TotalPrice { get; set; }
    }
}
