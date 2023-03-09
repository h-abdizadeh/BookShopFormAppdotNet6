using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models;

public class Group
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [MaxLength(150)]
    public string? Des { get; set; }

    public virtual ICollection<Book>? Books { get; set; }
}
