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
    public class IndexModel : PageModel
    {
        private readonly StockControlSystem.Infrastructure.Context _context;

        public IndexModel(StockControlSystem.Infrastructure.Context context)
        {
            _context = context;
        }

        public IList<Address> Address { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Address = await _context.Addresses
                .Include(a => a.Supplier).ToListAsync();
        }
    }
}
