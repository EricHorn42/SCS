using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StockControlSystem.Infrastructure;
using StockControlSystem.Models;

namespace StockControlSystem.Pages.Itens
{
    public class CreateModel : PageModel
    {
        private readonly StockControlSystem.Infrastructure.Context _context;

        public CreateModel(StockControlSystem.Infrastructure.Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Id"] = new SelectList(_context.Brands, "Id", "Name");
        ViewData["Id"] = new SelectList(_context.Categories, "Id", "Name");
        ViewData["Id"] = new SelectList(_context.Suppliers, "Id", "CNPJ");
            return Page();
        }

        [BindProperty]
        public Item Item { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Itens.Add(Item);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
