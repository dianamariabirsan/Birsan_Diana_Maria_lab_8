#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Birsan_Diana_Maria_lab_8.Models;

namespace Birsan_Diana_Maria_lab_8.Data
{
    public class Birsan_Diana_Maria_lab_8Context : DbContext
    {
        public Birsan_Diana_Maria_lab_8Context (DbContextOptions<Birsan_Diana_Maria_lab_8Context> options)
            : base(options)
        {
        }

        public DbSet<Birsan_Diana_Maria_lab_8.Models.Book> Book { get; set; }

        public DbSet<Birsan_Diana_Maria_lab_8.Models.Publisher> Publisher { get; set; }

        public DbSet<Birsan_Diana_Maria_lab_8.Models.Category> Category { get; set; }
    }
}
