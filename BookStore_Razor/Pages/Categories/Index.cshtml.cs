using BookStore_Razor.Data;
using BookStore_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore_Razor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext dBContext;
        public List<Category> CategoryList { get; set; }  
        public IndexModel(ApplicationDBContext _dBContext)
        {
            dBContext = _dBContext;
        }
        public void OnGet()
        {
         //   CategoryList = dBContext.Categories.ToList();
        }
    }
}
