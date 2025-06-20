﻿using System.ComponentModel.DataAnnotations;

namespace sandysukma_fdtest.ViewModels
{
    public class ResetPasswordViewModel 
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Token { get; set; }
    }
}