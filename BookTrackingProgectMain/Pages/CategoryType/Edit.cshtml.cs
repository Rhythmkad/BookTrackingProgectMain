using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookTrackingProgectMain.Data;
using BookTrackingProgectMain.Models;

namespace BookTrackingProgectMain.Pages.CategoryType
{
    public class EditModel : PageModel
    {
        private readonly BookTrackingProgectMain.Data.BookTrackingProgectMainContext _context;

        public EditModel(BookTrackingProgectMain.Data.BookTrackingProgectMainContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CategorysType CategorysType { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CategorysType = await _context.CategorysType.FirstOrDefaultAsync(m => m.Type == id);

            if (CategorysType == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CategorysType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategorysTypeExists(CategorysType.Type))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CategorysTypeExists(string id)
        {
            return _context.CategorysType.Any(e => e.Type == id);
        }
    }
}
