using BookStore.Models.Models;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models

{
    public class Category
    {
       
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1,100,ErrorMessage = "Display Order Must be between 1 and 100")]
        public int DisplayOrder { get; set; }

       // public ICollection<Category> Categories { get;}
        

    }
}
