using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookTrackingProgectMain.Data;
using BookTrackingProgectMain.Models;

namespace BookTrackingProgectMain.Pages.Book
{
    public class DetailsModel : PageModel
    {
        private readonly BookTrackingProgectMain.Data.BookTrackingProgectMainContext _context;

        public DetailsModel(BookTrackingProgectMain.Data.BookTrackingProgectMainContext context)
        {
            _context = context;
        }

        public Books Books { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Books = await _context.Books.FirstOrDefaultAsync(m => m.ISBM == id);

            if (Books == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
