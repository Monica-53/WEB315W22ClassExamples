using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IList<Car> Car { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList CarMakesList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CarMake { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> carMakeQuery = from c in _context.Car
                                              orderby c.CarMake
                                              select c.CarMake;
            var cars = from c in _context.Car
                       select c; // SELECT * from Car

            if (!string.IsNullOrEmpty(SearchString))
            {
                // where clause from sql, where c.CarModel = SearchString
                cars = cars.Where(c => c.CarModel.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(CarMake))
            {
                cars = cars.Where(c => c.CarMake == CarMake);
            }
            CarMakesList = new SelectList(await carMakeQuery.Distinct().ToListAsync());

            Car = await cars.ToListAsync();
        }
    }
}