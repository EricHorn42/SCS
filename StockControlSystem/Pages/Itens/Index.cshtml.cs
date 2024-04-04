using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StockControlSystem.Infrastructure;
using StockControlSystem.Models;

namespace StockControlSystem.Pages.Itens
{
    public class IndexModel : PageModel
    {
        private readonly StockControlSystem.Infrastructure.Context _context;

        public IndexModel(StockControlSystem.Infrastructure.Context context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Item = await _context.Itens
                .Include(i => i.Brand)
                .Include(i => i.Category)
                .Include(i => i.Supplier).ToListAsync();
        }
    }
}
