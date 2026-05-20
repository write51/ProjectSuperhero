using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectSuperhero.Data;
using ProjectSuperhero.Models;



namespace ProjectSuperhero.Pages
{


    public class LatestModel : PageModel
    {
        private readonly ProjectSuperhero.Data.ProjectSuperheroContext _context;

        public LatestModel(ProjectSuperhero.Data.ProjectSuperheroContext context)
        {
            _context = context;
        }

        public IList<Comic> Latest { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Latest = await _context.Comic.ToListAsync();

        }
    }
}
