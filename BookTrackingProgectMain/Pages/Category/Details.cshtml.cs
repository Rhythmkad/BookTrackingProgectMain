using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookTrackingProgectMain.Data;
using BookTrackingProgectMain.Models;

namespace BookTrackingProgectMain.Pages.Category
{
    public class DetailsModel : PageModel
    {
        private readonly BookTrackingProgectMain.Data.BookTrackingProgectMainContext _context;

        public DetailsModel(BookTrackingProgectMain.Data.BookTrackingProgectMainContext context)
        {
            _context = context;
        }

        public Categorys Categorys { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Categorys = await _context.Categorys.FirstOrDefaultAsync(m => m.NameToken == id);

            if (Categorys == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
