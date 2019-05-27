using System;
using BlogEngine.BLL;
using BlogEngine.BLL.Helpers;
using BlogEngine.DLL;
using BlogEngine.DLL.Models;
using Xunit;

namespace BlogEngine.Tests
{
    public class UnitTest1
    {
        private readonly UsersRepository _repo;

        public UnitTest1()
        {
            _repo = new UsersRepository();
        }

        [Fact]
        public void UserShouldBeAdded()
        {
            var user = new User()
            {
                Email = "ilyasrevenge@gmail.com",
                HashedPassword = "rdjlsad",
                Login = "ilyasrevenge",
                NameSurname = "Gomel Ilya"
            };
            Assert.Equal(BlogOperationResult.OK, _repo.Add(user));
        }

        [Fact]
        public void UserShouldBeRemoved()
        {
            var user = _repo.Get(1);
            Assert.Equal(BlogOperationResult.OK, _repo.Remove(user));
        }
    }
}
