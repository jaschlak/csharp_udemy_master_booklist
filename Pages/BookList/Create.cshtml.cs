using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using booklist.Model;

namespace booklist.Pages.BookList
{
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

//bind book property so the object can be called
[BindProperty]
public Book Book { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                // add to the book object
                await _db.Book.AddAsync(Book);
                // add to db
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            } 
            else
            {
                return Page();
            }
        }
    }
}
