﻿namespace CustomerApi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public CustomerStatus Status { get; set; }
    }
}
