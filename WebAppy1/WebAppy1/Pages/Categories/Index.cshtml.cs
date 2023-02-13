using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppy1.Data;
using WebAppy1.Model;
using System;
namespace WebAppy1.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly AppyDBcontext _db;
        public IEnumerable<Category> Categories { get; set; }
        public IndexModel(AppyDBcontext db) {
            _db = db;
        }

        public void OnGet()
        {
            Categories = _db.Categories;
        }
    }
}
