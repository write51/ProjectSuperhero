using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectSuperhero.Models;

namespace ProjectSuperhero.Pages
{
    public class CatalogModel : PageModel
    {

        private readonly ProjectSuperhero.Data.ProjectSuperheroContext _context;

        public CatalogModel(ProjectSuperhero.Data.ProjectSuperheroContext context)
        {
            _context = context;
        }


        // This will hold the results to display in the view
        public IList<Comic> Comics { get; set; } = default!;

        public async Task OnGetAsync(string letter)
        {
            // 1. Keep track of the active letter so we can highlight it in the UI
            ViewData["CurrentLetter"] = letter;

            // 2. Start with the base query
            var comicsQuery = _context.Comic.AsQueryable();

            // 3. Apply the filter ONLY if a letter was clicked
            if (!string.IsNullOrEmpty(letter))
            {
                comicsQuery = comicsQuery.Where(c => c.Name.StartsWith(letter));
            }

            // 4. Order alphabetically by default and execute
            Comics = await comicsQuery
                .OrderBy(c => c.Name)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
