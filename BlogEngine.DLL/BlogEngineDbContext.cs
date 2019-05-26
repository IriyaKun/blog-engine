using System;
using System.IO;
using BlogEngine.DLL.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace BlogEngine.DLL
{
    public class BlogEngineDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        private IConfiguration _configuration;

        public BlogEngineDbContext()
        {
            using(StreamReader r = new StreamReader("C:/Users/quiet/Desktop/Projects/blog-engine/BlogEngine.DLL/Helpers/BlogConfiguration.json"))
            {
                var json = r.ReadToEnd();

                _configuration = JsonConvert.DeserializeObject<BlogConfiguration>(json);
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO
            switch(_configuration.DbProvider)
            {
                case "SQL_SERVER": 
                {
                    
                    break;
                }
                case "MY_SQL": 
                {
                        optionsBuilder.UseMySQL(_configuration.ConnectionString);
                        break;
                }
                default: { break; };
            }

        }
    }
}
