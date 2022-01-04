﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Birsan_Diana_Maria_lab_8.Data;
using Birsan_Diana_Maria_lab_8.Models;

namespace Birsan_Diana_Maria_lab_8.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Birsan_Diana_Maria_lab_8.Data.Birsan_Diana_Maria_lab_8Context _context;

        public DetailsModel(Birsan_Diana_Maria_lab_8.Data.Birsan_Diana_Maria_lab_8Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}