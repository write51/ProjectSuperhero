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

        public IndexModel(ProjectSuperhero.Data.ProjectSuperheroContext context)
        {
            _context = context;
        }

        public IList<Comic> Comic { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Comic = await _context.Comic.ToListAsync();
        }
    }
}
