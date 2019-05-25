using BlogEngine.BLL.Interfaces;
using BlogEngine.DLL;
using BlogEngine.DLL.Models;
using System;

namespace BlogEngine.BLL
{
    public class UsersRepository : IBloggingRepository<User>
    {
        private BlogEngineDbContext _db;
        

        public UsersRepository()
        {

        }
    }
}
