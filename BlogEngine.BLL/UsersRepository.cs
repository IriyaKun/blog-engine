using BlogEngine.BLL.Interfaces;
using BlogEngine.DLL;
using BlogEngine.DLL.Models;
using System.Collections.Generic;
using System.Linq;
using BlogEngine.BLL.Helpers;

namespace BlogEngine.BLL
{

    public delegate string RepositoryHandler(object sender, string message, IModel entity);
    public class UsersRepository : IBloggingRepository<User>
    {
        private BlogEngineDbContext _db;

        public event RepositoryHandler Added;
        public event RepositoryHandler Removed;
        public event RepositoryHandler Updated;

        public UsersRepository()
        {
            using (_db = new BlogEngineDbContext())
            {
                _db.Database.EnsureCreated();
            }
        }

        public BlogOperationResult Add(User entity)
        {
            if (Exists(entity))
            {
                return BlogOperationResult.UserExists;
            }
            using (_db = new BlogEngineDbContext())
            {
                _db.Users.Add(entity);
                Added?.Invoke(this, "user-added-message", entity);
                _db.SaveChanges();
            }

            return BlogOperationResult.OK;
        }

        public BlogOperationResult Remove(User entity)
        {
            if (!Exists(entity))
            {
                return BlogOperationResult.UserDoesNotExist;
            }

            using (_db = new BlogEngineDbContext())
            {
                _db.Users.Remove(entity);
                Removed?.Invoke(this, "user-removed-message", entity);
                _db.SaveChanges();
            }

            return BlogOperationResult.OK;
        }

        public User Get(string login)
        {
            using (_db = new BlogEngineDbContext())
            {
                return _db.Users.FirstOrDefault(user => user.Login == login);
            }
        }

        public BlogOperationResult Update(User entity)
        {
            Updated?.Invoke(this, "user-updated-message", entity);
            return BlogOperationResult.OK;
        }

        public IEnumerable<User> ToEnumerable()
        {
            using (_db = new BlogEngineDbContext())
            {
                return _db.Users.Take(_db.Users.Count());
            }
        }

        public bool Exists(User entity)
        {
            using(_db = new BlogEngineDbContext())
            {
                return _db.Users.FirstOrDefault(user => user.Email == entity.Email) != null;
            }
        }
    }
} 
