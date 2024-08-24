using FlightsTest.Data;
using FlightsTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlightsTest.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Items
        public async Task<IActionResult> Index()
        {
            var items = await _context.Items.ToListAsync();


            return View(items);
        }

        // GET: Items/Create
        [HttpGet("/ItemsCreate")]
        public IActionResult Create()
        {
            return View();
        }

       
    }
}
