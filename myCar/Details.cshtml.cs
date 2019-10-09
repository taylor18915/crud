using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDHW2.Data;

namespace CRUDHW2.Pages.myCar
{
    public class DetailsModel : PageModel
    {
        private readonly CRUDHW2.Data.ApplicationDbContext _context;

        public DetailsModel(CRUDHW2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Automobiles Automobiles { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Automobiles = await _context.Automobiles
                .Include(a => a.ManId).FirstOrDefaultAsync(m => m.AID == id);

            if (Automobiles == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
