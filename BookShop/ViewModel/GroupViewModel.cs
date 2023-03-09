using BookShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.ViewModel;

public class GroupViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Des { get; set; }
}
