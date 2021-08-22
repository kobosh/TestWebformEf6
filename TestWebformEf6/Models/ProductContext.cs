using System.Data.Entity;
namespace TestWebformEf6
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            //: base("WingtipToy")
        {
          // Database.SetInitializer<ProductContext>(new CreateDatabaseIfNotExists<ProductContext>());

        }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Product> Products { get; set; }
    }
}