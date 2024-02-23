using Microsoft.EntityFrameworkCore;
using Mission06_Cruz.Models;

namespace FilmCollection.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options) 
        {
        }   

        public DbSet<Movies> Movies { get; set;}
        public DbSet<Categories> Categories { get; set;}
    }
}
