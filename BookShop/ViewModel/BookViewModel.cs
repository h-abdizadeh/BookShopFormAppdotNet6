using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.ViewModel;

public class BookViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Writer { get; set; }
    public string Publisher { get; set; }
    public int Inventory { get; set; }
    public int Price { get; set; }
    public string GroupName { get; set; }


}
