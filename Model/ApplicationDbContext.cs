using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace booklist.Model
{

    // Connect to db, requires .json db context string
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Book { get; set; }

    }
}
