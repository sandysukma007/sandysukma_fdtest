﻿using System.ComponentModel.DataAnnotations;

namespace sandysukma_fdtest.ViewModels
{
    public class ForgotPasswordViewModel 
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}