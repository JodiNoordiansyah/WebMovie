using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMovie.Models;

namespace WebMovie.Data
{
    public class WebMovieContext : DbContext
    {
        public WebMovieContext (DbContextOptions<WebMovieContext> options)
            : base(options)
        {
        }

        public DbSet<WebMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
