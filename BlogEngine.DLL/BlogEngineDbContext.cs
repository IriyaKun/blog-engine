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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO
            optionsBuilder.UseMySQL("server=localhost;UserId=root;Password=bangarang12;database=blogEngineDb;");
        }
    }
}
