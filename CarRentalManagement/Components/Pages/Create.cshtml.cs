using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CarRentalManagement.Data;
using CarRentalManagement.Domain;

namespace CarRentalManagement.Components.Pages
{
    public class CreateModel : PageModel
    {
        private readonly CarRentalManagement.Data.CarRentalManagementContext _context;

        public CreateModel(CarRentalManagement.Data.CarRentalManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Make Make { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Make.Add(Make);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
