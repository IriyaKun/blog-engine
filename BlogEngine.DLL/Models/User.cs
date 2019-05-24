using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogEngine.DLL.Models
{
    public class User : IModel
    {
        public int Id { get; set; }

        [Required]
        public string Login { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string NameSurname { get; set; }
        [Required]
        public string HashedPassword { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}
