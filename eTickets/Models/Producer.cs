﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {

        [Key]
        public int ProducerId { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string? ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }
        [Display(Name = "Biography")]
        public string? Bio { get; set; }


        //relstionships

        public List<Movie>? Movies { get; set; }
    }
}