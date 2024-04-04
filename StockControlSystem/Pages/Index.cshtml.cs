using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StockControlSystem.Infrastructure;
using StockControlSystem.Models;


namespace StockControlSystem.Pages;

public class IndexModel : PageModel
{
    private readonly Context _db;

    public IndexModel(Context db)
    {

        _db = db;
    }

    [BindProperty]
    public Item? _Item { get; set; }

    public IReadOnlyList<Item>? _Itens { get; private set; }

    [TempData]
    public string Result { get; set; } = default!;

       
    
}
