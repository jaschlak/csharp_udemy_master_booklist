using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data;
using Microsoft.EntityFrameworkCore;

namespace booklist.Model
{
    // Connect to db, requires .json db context string
    // inherit DbContext from Entity Framework
    public class ApplicationDbContext : DbContext
    {
        // add constructor, pass dbcontextoptions to the parent class (ApplicationDbContext), pass to base and name it options
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        // add bookmodel database
        public DbSet<Book> Book { get; set; }
    }
}