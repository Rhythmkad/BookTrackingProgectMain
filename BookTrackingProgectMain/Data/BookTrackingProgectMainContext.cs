using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookTrackingProgectMain.Models;

namespace BookTrackingProgectMain.Data
{
    public class BookTrackingProgectMainContext : DbContext
    {
        public BookTrackingProgectMainContext (DbContextOptions<BookTrackingProgectMainContext> options)
            : base(options)
        {
        }

        public DbSet<BookTrackingProgectMain.Models.Books> Books { get; set; }

        public DbSet<BookTrackingProgectMain.Models.Categorys> Categorys { get; set; }

        public DbSet<BookTrackingProgectMain.Models.CategorysType> CategorysType { get; set; }
    }
}
