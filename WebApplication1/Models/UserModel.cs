﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserModel
    {
        [Key] 
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public float RewardPoint { get; set; }
    }
}
