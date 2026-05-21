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


        public async Task OnGetAsync()
        {
            Latest = await _context.Comic.ToListAsync();

        }

    }
}
