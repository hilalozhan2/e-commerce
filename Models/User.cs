﻿namespace guitars.Models
{
    public class User
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAdmin { get; set; }
        
    }
}
