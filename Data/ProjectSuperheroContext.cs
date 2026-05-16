using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectSuperhero.Models;

namespace ProjectSuperhero.Data
{
    public class ProjectSuperheroContext : DbContext
    {
        public ProjectSuperheroContext (DbContextOptions<ProjectSuperheroContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectSuperhero.Models.Series> Patient { get; set; } = default!;
    }
}
