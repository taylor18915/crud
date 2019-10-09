using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRUDHW2.Data;

namespace CRUDHW2.Pages.myMan
{
    public class CreateModel : PageModel
    {
        private readonly CRUDHW2.Data.ApplicationDbContext _context;

        public CreateModel(CRUDHW2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Manufacturers Manufacturers { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Manufacturers.Add(Manufacturers);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}