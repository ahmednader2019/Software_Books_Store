﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public string Author { get; set; }


        public string ISBN { get; set; }

        [Required]
        [Display(Name = "List Price")]
        public double ListPrice { get; set; }

        [Required]
        [Range(1, 1000)]
        [Display(Name = "Price for 1-50")]

        public double Price { get; set; }

        [Required]
        [Range(1, 1000)]
        [Display(Name = "Price for 50+")]

        public double Price50 { get; set; }

        [Required]
        [Range(1,1000)]
        [Display(Name = "Price for 100+")]
        public double Price100 { get; set;}

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public Category? Category { get; set; }
        [ValidateNever]
        public string? ImageURL { get; set; }


    }
}
