using Microsoft.AspNetCore.Mvc;

public class OsobaController : Controller
{
    private readonly AppDbContext _context;

    public OsobaController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Osoby.ToList());
    }

    public IActionResult Dodaj()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Dodaj(Osoba osoba)
    {
        if (ModelState.IsValid)
        {
            _context.Osoby.Add(osoba);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(osoba);
    }
}
