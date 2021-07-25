using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesProject.Data;
using MoviesProject.Migrations;
using MoviesProject.Models;

namespace MoviesProject.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly MoviesProject.Data.MoviesProjectContext _context;

        public CreateModel(MoviesProject.Data.MoviesProjectContext context)
        {
            _context = context;
        }
        
        public IActionResult OnGet()
        {
            
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var moviesArray = _context.Movie.ToArray();
            for(int i=0; i<moviesArray.Length; i++)
            {
                if(Movie.Title.Equals(moviesArray[i].Title))
                {
                    ModelState.AddModelError("DuplicateMovie", "This Movie Already Exists");
                    return Page();
                }
            }
            Movie.Photo = "~/Images/default.jpg";
            int ratingCurrent = Int32.Parse(Movie.Rating);
            
            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
