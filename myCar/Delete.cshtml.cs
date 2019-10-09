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
    public class DeleteModel : PageModel
    {
        private readonly CRUDHW2.Data.ApplicationDbContext _context;

        public DeleteModel(CRUDHW2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Automobiles = await _context.Automobiles.FindAsync(id);

            if (Automobiles != null)
            {
                _context.Automobiles.Remove(Automobiles);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
