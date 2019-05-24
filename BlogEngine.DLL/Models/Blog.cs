using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEngine.DLL.Models
{
    public class Blog : IModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Body { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
