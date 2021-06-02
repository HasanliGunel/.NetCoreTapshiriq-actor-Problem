using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tapshiriq_actor_.Database
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> context) : base(context) { }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ActorMoviecs> ActorMoviecss { get; set; }

    }
}
