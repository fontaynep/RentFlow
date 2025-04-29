using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RentFlow.Data;
using RentFlow.Models;

namespace RentFlow.Pages_Properties
{
    public class IndexModel : PageModel
    {
        private readonly RentFlow.Data.AppDbContext _context;

        public IndexModel(RentFlow.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Property> Property { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Property = await _context.Properties.ToListAsync();
        }
    }
}
