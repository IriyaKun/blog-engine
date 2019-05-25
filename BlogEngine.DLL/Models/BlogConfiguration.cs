using System;
using System.Collections.Generic;
using System.Text;

namespace BlogEngine.DLL.Models
{
    class BlogConfiguration : IConfiguration
    {
        public string DbProvider { get; set; }
        public string ConnectionString { get; set; }
    }
}
