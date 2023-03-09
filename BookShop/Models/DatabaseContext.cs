using Microsoft.EntityFrameworkCore;

namespace BookShop.Models;
public class DatabaseContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder option)
    {
        option.UseSqlServer(@"Data Source=.\SQLEXPRESS; 
                                Initial Catalog=BookShopApp;
                                    Integrated Security=SSPI");
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Group> Groups { get; set; }
}
