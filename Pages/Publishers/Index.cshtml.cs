#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Birsan_Diana_Maria_lab_8.Data;
using Birsan_Diana_Maria_lab_8.Models;

namespace Birsan_Diana_Maria_lab_8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Birsan_Diana_Maria_lab_8.Data.Birsan_Diana_Maria_lab_8Context _context;

        public IndexModel(Birsan_Diana_Maria_lab_8.Data.Birsan_Diana_Maria_lab_8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
