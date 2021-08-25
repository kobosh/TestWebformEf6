using System.Data.Entity;
namespace TestWebformEf6
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("WingtipToy")
        {
          

        }
        public DbSet<Category> Categories { get; set; }
        
    }
}