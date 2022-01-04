#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Birsan_Diana_Maria_lab_8.Data;
using Birsan_Diana_Maria_lab_8.Models;

namespace Birsan_Diana_Maria_lab_8.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Birsan_Diana_Maria_lab_8.Data.Birsan_Diana_Maria_lab_8Context _context;

        public CreateModel(Birsan_Diana_Maria_lab_8.Data.Birsan_Diana_Maria_lab_8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
