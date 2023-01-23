using Microsoft.EntityFrameworkCore;
using MVC_Crud_Az_sym_Groot.Models;

namespace MVC_Crud_Az_sym_Groot.Context
{
    
        public class BlogContext : DbContext
        {
            public BlogContext(DbContextOptions options) : base(options)
            {

            }
            public DbSet<Blogs> Blogs { get; set; }
        }
    
}
