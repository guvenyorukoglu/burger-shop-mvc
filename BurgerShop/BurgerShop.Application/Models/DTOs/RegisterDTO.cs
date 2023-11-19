﻿using BurgerShop.Application.Extensions;
using BurgerShop.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BurgerShop.Application.Models.DTOs
{
    public class RegisterDTO
    {
        [Required]
        [StringLength(20, ErrorMessage = "Firstname cannot be more than 20 characters!", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Lastname cannot be more than 30 characters!", MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [CustomEmail(ErrorMessage = "Email is invalid!")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Password must have more than 6 and less than 20 characters!")]
        [CustomPassword(ErrorMessage = "Password must have at least 1 uppercase letter, 1 lowercase letter, 1 digit, and 1 special character.")]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match!")]
        public string ConfirmedPassword { get; set; }

        public DateTime CreatedDate => DateTime.Now;

        public Status Status => Status.Passive;

    }
}
