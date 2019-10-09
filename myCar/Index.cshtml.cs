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
    public class IndexModel : PageModel
    {
        private readonly CRUDHW2.Data.ApplicationDbContext _context;

        public IndexModel(CRUDHW2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Automobiles> Automobiles { get;set; }

        public async Task OnGetAsync()
        {
            Automobiles = await _context.Automobiles
                .Include(a => a.ManId).ToListAsync();
        }
    }
}
