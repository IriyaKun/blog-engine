using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEngine.DLL.Models
{
    public interface IModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        int Id { get; set; }
    }
}
