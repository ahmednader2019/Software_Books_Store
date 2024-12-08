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
    public class OrderHeader
    {
        public int Id { get; set; } 

        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        
        public ApplicationUser ApplicationUser { get; set; }

        public DateTime OrderDate {  get; set; }

        public DateTime ShippingDate { get; set; }

        public double OrderTotal { get; set; }

        public string? OrderStatus { get; set; }

        public string? PaymentStatus { get; set; }

        public string? TrackingNumber { get; set; }

        public string? Carrier { get; set; }

        public DateTime PaymentDate {  get; set; }

        public DateTime PaymentDueDate { get; set; }

        public string? PaymentIntentId { get; set;}

        [Required]
        public string Name { get; set; }
        [Required]

        public string? streetAddress { get; set; }
        [Required]

        public string? city { get; set; }
        [Required]

        public string? state { get; set; }
        [Required]

        public string? postalCode { get; set; }
        [Required]

        public string? phoneNumber { get; set; }




    }
}
