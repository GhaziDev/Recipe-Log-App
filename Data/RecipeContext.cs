using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeApp.Models;

namespace RecipeApp.Data
{
    public class RecipeContext : DbContext
    {
        public RecipeContext (DbContextOptions<RecipeContext> options)
            : base(options)
        {
        }

        public DbSet<RecipeApp.Models.Recipe> Recipe { get; set; } = default!;
    }
}
