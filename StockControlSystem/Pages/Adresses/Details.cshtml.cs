using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StockControlSystem.Infrastructure;
using StockControlSystem.Models;

namespace StockControlSystem.Pages.Adresses
{
    public class DetailsModel : PageModel
    {
        private readonly StockControlSystem.Infrastructure.Context _context;

        public DetailsModel(StockControlSystem.Infrastructure.Context context)
        {
            _context = context;
        }

        public Address Address { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var address = await _context.Addresses.FirstOrDefaultAsync(m => m.Id == id);
            if (address == null)
            {
                return NotFound();
            }
            else
            {
                Address = address;
            }
            return Page();
        }
    }
}
