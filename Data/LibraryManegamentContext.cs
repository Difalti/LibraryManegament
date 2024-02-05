using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryManegament.Models;

namespace LibraryManegament.Data
{
    public class LibraryManegamentContext : DbContext
    {
        public LibraryManegamentContext (DbContextOptions<LibraryManegamentContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryManegament.Models.Book> Book { get; set; } = default!;
    }
}
