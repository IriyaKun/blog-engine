using System;
namespace BlogEngine.DLL
{
    public interface IConfiguration
    {
        string DbProvider { get; set; }
        string ConnectionString { get; set; }
    }
}
