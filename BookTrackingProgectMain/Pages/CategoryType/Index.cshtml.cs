using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookTrackingProgectMain.Data;
using BookTrackingProgectMain.Models;

namespace BookTrackingProgectMain.Pages.CategoryType
{
    public class IndexModel : PageModel
    {
        private readonly BookTrackingProgectMain.Data.BookTrackingProgectMainContext _context;

        public IndexModel(BookTrackingProgectMain.Data.BookTrackingProgectMainContext context)
        {
            _context = context;
        }

        public IList<CategorysType> CategorysType { get;set; }

        public async Task OnGetAsync()
        {
            CategorysType = await _context.CategorysType.ToListAsync();
        }
    }
}
