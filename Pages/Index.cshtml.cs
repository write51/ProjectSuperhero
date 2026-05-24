using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectSuperhero.Models;

namespace Lab5.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ProjectSuperhero.Data.ProjectSuperheroContext _context;

        public IndexModel(ILogger<IndexModel> logger, ProjectSuperhero.Data.ProjectSuperheroContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Comic> Latest { get; set; } = default!;

        // Pagination Properties
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;

        // Set the number of items per page
        private const int PageSize = 16;

        public async Task OnGetAsync(int? pageIndex)
        {
            // Default to page 1 if no pageIndex is provided
            CurrentPage = pageIndex ?? 1;

            // 1. Get the total count of comics
            int totalComics = await _context.Comic.CountAsync();

            // 2. Calculate total pages needed
            TotalPages = (int)Math.Ceiling(totalComics / (double)PageSize);

            // 3. Fetch only the 16 comics for the current page
            // Assuming you want the actual "Latest" added, order by Id descending
            Latest = await _context.Comic
                .OrderByDescending(c => c.Id)
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync();
        }
    }
}