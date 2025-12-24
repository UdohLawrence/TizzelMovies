using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TizzelMovies.Web.Data;
using TizzelMovies.Web.Models;

namespace TizzelMovies.Web.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly TizzelMovies.Web.Data.MoviesContext _context;

        public IndexModel(TizzelMovies.Web.Data.MoviesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
