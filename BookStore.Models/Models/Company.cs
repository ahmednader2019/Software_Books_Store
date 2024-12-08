using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Models
{
    public class Company
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string? streetAddress { get; set; }

        public string? city { get; set; }    

        public string? state { get; set; }

        public string? postalCode { get; set; }

        public string? phoneNumber { get; set; }

        

        

    }
}
