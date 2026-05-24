using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectSuperhero.Models;

namespace ProjectSuperhero.Pages
{
    public class GenreModel : PageModel
    {
        private readonly ProjectSuperhero.Data.ProjectSuperheroContext _context;
        private const int PageSize = 32; // Limit to 32 items per page

        public GenreModel(ProjectSuperhero.Data.ProjectSuperheroContext context)
        {
            _context = context;
        }

        // The layout results to iterate over
        public IList<Comic> Comics { get; set; } = default!;

        // Active genre context tracked for layout headings and route persistence
        public string CurrentGenre { get; set; } = string.Empty;

        // Pagination Properties
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;

        public async Task OnGetAsync(string genre, int? pageIndex)
        {
            CurrentGenre = genre ?? string.Empty;
            CurrentPage = pageIndex ?? 1;
            if (CurrentPage < 1) CurrentPage = 1;

            var query = _context.Comic.AsQueryable();

            // Filter if a genre string is passed
            if (!string.IsNullOrEmpty(CurrentGenre))
            {
                // Checks if the database column contains the targeted genre segment
                query = query.Where(c => c.Genres != null && c.Genres.Contains(CurrentGenre));
            }

            // Calculate item distribution metrics
            int totalItems = await query.CountAsync();
            TotalPages = (int)Math.Ceiling(totalItems / (double)PageSize);

            // Fetch the sliced segment 
            Comics = await query
                .OrderBy(c => c.Name)
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}