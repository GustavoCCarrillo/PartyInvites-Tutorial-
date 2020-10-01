﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter your email address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please enter your phone number")]
        [Phone]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }

        public DateTime RsvpTime { get; set; }

    }
}
