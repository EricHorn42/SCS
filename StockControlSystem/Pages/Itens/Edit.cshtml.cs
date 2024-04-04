using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StockControlSystem.Infrastructure;
using StockControlSystem.Models;

namespace StockControlSystem.Pages.Itens
{
    public class EditModel : PageModel
    {
        private readonly StockControlSystem.Infrastructure.Context _context;

        public EditModel(StockControlSystem.Infrastructure.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Item Item { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item =  await _context.Itens.FirstOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            Item = item;
           ViewData["Id"] = new SelectList(_context.Brands, "Id", "Name");
           ViewData["Id"] = new SelectList(_context.Categories, "Id", "Name");
           ViewData["Id"] = new SelectList(_context.Suppliers, "Id", "CNPJ");
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

            _context.Attach(Item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(Item.Id))
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

        private bool ItemExists(int id)
        {
            return _context.Itens.Any(e => e.Id == id);
        }
    }
}
