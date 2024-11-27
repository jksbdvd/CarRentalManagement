using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Data;
using CarRentalManagement.Domain;

namespace CarRentalManagement.Components.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CarRentalManagement.Data.CarRentalManagementContext _context;

        public IndexModel(CarRentalManagement.Data.CarRentalManagementContext context)
        {
            _context = context;
        }

        public IList<Make> Make { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Make = await _context.Make.ToListAsync();
        }
    }
}
