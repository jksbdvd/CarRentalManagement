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
    public class DetailsModel : PageModel
    {
        private readonly CarRentalManagement.Data.CarRentalManagementContext _context;

        public DetailsModel(CarRentalManagement.Data.CarRentalManagementContext context)
        {
            _context = context;
        }

        public Make Make { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var make = await _context.Make.FirstOrDefaultAsync(m => m.Id == id);
            if (make == null)
            {
                return NotFound();
            }
            else
            {
                Make = make;
            }
            return Page();
        }
    }
}
