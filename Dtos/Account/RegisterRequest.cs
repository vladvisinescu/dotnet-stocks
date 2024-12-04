﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Dtos.Account
{
    public class RegisterRequest
    {
        [Required]
        public string? Username { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string? Email { get; set; } = string.Empty;

        [Required]
        public string? Password { get; set; } = string.Empty;
    }
}
