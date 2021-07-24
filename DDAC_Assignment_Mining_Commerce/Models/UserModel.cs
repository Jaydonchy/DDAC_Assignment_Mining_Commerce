﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DDAC_Assignment_Mining_Commerce.Models
{
    public class UserModel
    {
        public int ID { get; set; }

        [Display(Name ="Full Name")]
        [StringLength(70, MinimumLength = 6, ErrorMessage = "The {0} must be between {2}-{1} chars")]
        [Required]
        public string fullname { get; set; }

        [Display(Name ="Email")]
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name = "Phone no.")]
        [Required(ErrorMessage = "Phone Number is Required")]
        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }

        [Display(Name ="Gender")]
        [StringLength(1,MinimumLength = 1)]
        [Required]
        public string gender {get;set;}

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Date of Birth is Required")]
        public DateTime DOB { get; set; }

        [Display(Name ="Password")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Required]
        public string password { get; set; }
    }

    enum UserType{ 
        ADMIN,
        SELLER,
        BUYER
    }
}
