using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectSuperhero.Data;
using ProjectSuperhero.Models;

namespace ProjectSuperhero.Pages.Comics
{
    public class IndexModel : PageModel
    {
        private readonly ProjectSuperhero.Data.ProjectSuperheroContext _context;
        private const int PageSize = 32; // Limit to 32 comics at a time

        public IndexModel(ProjectSuperhero.Data.ProjectSuperheroContext context)
        {
            _context = context;
        }

        public IList<Comic> Comic { get; set; } = default!;

        // Pagination Properties
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;

        public async Task OnGetAsync(int? pageIndex)
        {
            // Set current page index (defaults to 1 if null or less than 1)
            CurrentPage = pageIndex ?? 1;
            if (CurrentPage < 1) CurrentPage = 1;

            // Start with the base query
            var query = _context.Comic.AsQueryable();

            // Calculate total items and total pages
            int totalItems = await query.CountAsync();
            TotalPages = (int)Math.Ceiling(totalItems / (double)PageSize);

            // Execute paginated query (ordered by Name for stability across pages)
            Comic = await query
                .OrderBy(c => c.Name)
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}