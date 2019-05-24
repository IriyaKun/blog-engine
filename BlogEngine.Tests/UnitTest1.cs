using System;
using BlogEngine.DLL;
using Xunit;

namespace BlogEngine.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var db = new BlogEngineDbContext();
            db.Database.EnsureCreated();
        }
    }
}
