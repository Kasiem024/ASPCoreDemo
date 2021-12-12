using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPCoreDemo.Models;

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {}

        // Creates a DbSet<Movie> property that represents the movies in the database
        public DbSet<ASPCoreDemo.Models.Movie> Movie { get; set; }
    }
