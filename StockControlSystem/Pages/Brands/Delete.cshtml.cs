using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StockControlSystem.Infrastructure;
using StockControlSystem.Models;

namespace StockControlSystem.Pages.Brands
{
    public class DeleteModel : PageModel
    {
        private readonly StockControlSystem.Infrastructure.Context _context;

        public DeleteModel(StockControlSystem.Infrastructure.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Brand Brand { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brand = await _context.Brands.FirstOrDefaultAsync(m => m.Id == id);

            if (brand == null)
            {
                return NotFound();
            }
            else
            {
                Brand = brand;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brand = await _context.Brands.FindAsync(id);
            if (brand != null)
            {
                Brand = brand;
                _context.Brands.Remove(Brand);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
