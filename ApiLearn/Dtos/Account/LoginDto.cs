﻿using System.ComponentModel.DataAnnotations;

namespace ApiLearn.Dtos.Account
{
    public class LoginDto
    {
        //[Required]
        //public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
