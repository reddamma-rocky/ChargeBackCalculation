﻿using ChargeBackCalculation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChargeBackCalculation.ViewModels
{
    public class PasswordReset
    {
        [Required(ErrorMessage = "UserId is required.")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        [DisplayName("User Id")]

        public int UserId { get; set; }


        [Required(ErrorMessage = "Please Select Secret Question")]
        [Display(Name = "Secret Question")]
        public SecretQuestion SecretQuestions { get; set; }

        [Required(ErrorMessage = "Please Enter Answer")]
        [Display(Name = "Answer")]
        public string Answer { get; set; }
    }
}