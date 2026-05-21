using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectSuperhero.Data;
using ProjectSuperhero.Models;

namespace ProjectSuperhero.Pages.Comics
{
    public class CreateModel : PageModel
    {
        private readonly ProjectSuperhero.Data.ProjectSuperheroContext _context;

        public CreateModel(ProjectSuperhero.Data.ProjectSuperheroContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Comic Comic { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Comic.Add(Comic);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
