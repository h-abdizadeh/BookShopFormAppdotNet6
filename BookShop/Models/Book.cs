using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Models;

public class Book
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Writer { get; set; }

    [Required]
    public string Publisher { get; set; }
    public string? Language { get; set; }
    public string? Translator { get; set; }
    public string? CoverImg { get; set; }
    public int Price { get; set; } = 0;
    public int Inventory { get; set; } = 0;

    [MaxLength(300)]
    public string? Summary { get; set; }

    public int GroupId { get; set; }


    [ForeignKey("GroupId")]
    public virtual Group? Group { get; set; }

}
