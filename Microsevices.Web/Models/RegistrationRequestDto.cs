﻿using System.ComponentModel.DataAnnotations;

namespace Microservices.Web.Models
{
    public class RegistrationRequestDto
    {
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? FullName { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}
