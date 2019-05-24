using System;
using BlogEngine.DLL.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace BlogEngine.DLL
{
    public class BlogEngineDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        private IConfiguration _configuration;

        public BlogEngineDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO
            switch(_configuration.dbProvider)
            {
                case "SQL_SERVER": 
                {
                    
                    break;
                }
                case "MY_SQL": 
                {
                        optionsBuilder.UseMySQL("server=localhost;UserId=root;Password=bangarang12;database=blogEngineDb;");
                        break;
                }
                default: { break; };
            }

        }
    }
}
