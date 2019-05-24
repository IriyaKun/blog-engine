using System;
namespace BlogEngine.DLL
{
    public interface IConfiguration
    {
        string dbProvider { get; set; }
        string connectionString { get; set; }
    }
}
