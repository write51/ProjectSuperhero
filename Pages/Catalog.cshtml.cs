using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectSuperhero.Models;

namespace ProjectSuperhero.Pages
{
    public class CatalogModel : PageModel
    {
        private readonly ProjectSuperhero.Data.ProjectSuperheroContext _context;
        private const int PageSize = 32; // Set your limit per page

        public CatalogModel(ProjectSuperhero.Data.ProjectSuperheroContext context)
        {
            _context = context;
        }

        // Holds the results to display in the view
        public IList<Comic> Comics { get; set; } = default!;

        // Pagination properties
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;

        public async Task OnGetAsync(string letter, int? pageIndex)
        {
            // 1. Keep track of the active letter so we can highlight it in the UI
            ViewData["CurrentLetter"] = letter;

            // Set current page index (defaults to 1 if null)
            CurrentPage = pageIndex ?? 1;

            // 2. Start with the base query
            var comicsQuery = _context.Comic.AsQueryable();

            // 3. Apply the filter ONLY if a letter was clicked
            if (!string.IsNullOrEmpty(letter))
            {
                comicsQuery = comicsQuery.Where(c => c.Name.StartsWith(letter));
            }

            // 4. Calculate total count and pages based on the filtered query
            int totalItems = await comicsQuery.CountAsync();
            TotalPages = (int)Math.Ceiling(totalItems / (double)PageSize);

            // Guard against pageIndex numbers out of bounds
            if (CurrentPage < 1) CurrentPage = 1;

            // 5. Order alphabetically, apply pagination, and execute
            Comics = await comicsQuery
                .OrderBy(c => c.Name)
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}