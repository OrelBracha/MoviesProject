using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoviesProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesProject.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MoviesProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MoviesProjectContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "King Bibi",
                         Photo = "~/Images/king bibi.jpg",
                         ReleaseDate = DateTime.Parse("2019-4-15"),
                         Genre = "Biography",
                         Price = 3.99M,
                         Rating = "1"
                     },
                     new Movie
                     {
                         Title = "Charlie and a Half",
                         Photo = "~/Images/charlie.jpg",
                         ReleaseDate = DateTime.Parse("1980-1-1"),
                         Genre = "Burekas",
                         Price = 3.99M,
                         Rating = "2"
                     },
                     new Movie
                     {
                         Title = "Party in the snooker",
                         Photo = "~/Images/snooker.jpg",
                         ReleaseDate = DateTime.Parse("1970-1-1"),
                         Genre = "Burekas",
                         Price = 3.99M,
                         Rating = "3"
                     },
                      new Movie
                      {
                          Title = "Rio Bravo",
                          Photo = "~/Images/rio bravo.jpg",
                          ReleaseDate = DateTime.Parse("1959-4-15"),
                          Genre = "Western",
                          Price = 3.99M,
                          Rating = "4"
                      },
                      new Movie
                      {
                          Title = "Ghostbusters 2",
                          Photo = "~/Images/Ghostbusters 2.jpg",
                          ReleaseDate = DateTime.Parse("1986-2-23"),
                          Genre = "Comedy",
                          Price = 9.99M,
                          Rating = "5"
                      },

                    

                    new Movie
                    {
                        Title = "Ghostbusters",
                        Photo = "~/Images/Ghostbusters.jpg",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "6"
                    },
                    
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        Photo = "~/Images/When Harry Met Sally.jpg",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "7"
                    },
                    
                  

                     new Movie
                     {
                         Title = "Star wars",
                         Photo = "~/Images/Star wars.jpg",
                         ReleaseDate = DateTime.Parse("1968-3-15"),
                         Genre = "Fictional Science",
                         Price = 3.99M,
                         Rating = "8"
                     },


                         new Movie
                         {
                             Title = "Toy Story",
                             Photo = "~/Images/toy story.jpg",
                             ReleaseDate = DateTime.Parse("1999-2-13"),
                             Genre = "Comedy",
                             Price = 3.99M,
                             Rating = "9"
                         },

                          new Movie
                          {
                              Title = "The silent killer",
                              Photo = "~/Images/silent killer.jpg",
                              ReleaseDate = DateTime.Parse("1995-11-4"),
                              Genre = "Drama",
                              Price = 3.99M,
                              Rating = "10"
                          }
                );
                context.SaveChanges();
            }
        }


    }
}
