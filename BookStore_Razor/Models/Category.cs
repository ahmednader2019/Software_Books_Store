using System.ComponentModel.DataAnnotations;

namespace BookStore_Razor.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, 100, ErrorMessage = "Display Order Must be between 1 and 100")]
        public int DisplayOrder { get; set; }
    }
}
