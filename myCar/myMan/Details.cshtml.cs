using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDHW2.Data;

namespace CRUDHW2.Pages.myMan
{
    public class DetailsModel : PageModel
    {
        private readonly CRUDHW2.Data.ApplicationDbContext _context;

        public DetailsModel(CRUDHW2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Manufacturers Manufacturers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manufacturers = await _context.Manufacturers.FirstOrDefaultAsync(m => m.MID == id);

            if (Manufacturers == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
