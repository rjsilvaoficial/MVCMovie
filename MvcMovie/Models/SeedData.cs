using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider servicesProvider)
        {
            using (var seedContext = new MvcMovieContext
                (servicesProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if (seedContext.Movie.Any())
                {
                    return;
                }

                seedContext.AddRange
                    (
                        new Movie { Title = "Duro de matar 1", ReleaseDate = DateTime.Parse("1984-3-13"), Genre = "Ação", Price = 1.99M, Rating = "R" },
                        new Movie { Title = "Duro de matar 1", ReleaseDate = DateTime.Parse("1985-4-14"), Genre = "Ação", Price = 2.99M, Rating = "R" },
                        new Movie { Title = "Duro de matar 1", ReleaseDate = DateTime.Parse("1986-5-15"), Genre = "Ação", Price = 3.99M, Rating = "R" },

                        new Movie { Title = "Predador 1", ReleaseDate = DateTime.Parse("1987-6-16"), Genre = "Ação", Price = 1.99M, Rating = "R" },
                        new Movie { Title = "Predador 2", ReleaseDate = DateTime.Parse("1988-7-17"), Genre = "Ação", Price = 2.99M, Rating = "R" }
                    );
                seedContext.SaveChanges();
            }
        }
    }
}
