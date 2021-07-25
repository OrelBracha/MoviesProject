using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesProject.Models;

namespace MoviesProject.Data
{
    public class MoviesProjectContext : DbContext
    {
        public MoviesProjectContext (DbContextOptions<MoviesProjectContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesProject.Models.Movie> Movie { get; set; }
    }
}
