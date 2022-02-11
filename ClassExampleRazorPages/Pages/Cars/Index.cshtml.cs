using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClassExampleRazorPages.Models;
using ClassExampleRazorPages.Data;

namespace ClassExampleRazorPages.Pages_Cars
{
    public class IndexModel : PageModel
    {
        private readonly ClassExampleRazorPagesContext _context;

        public IndexModel(ClassExampleRazorPagesContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Car.ToListAsync();
        }
    }
}