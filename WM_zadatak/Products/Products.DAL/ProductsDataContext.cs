using Products.DAL.Models;
using System.Configuration;
using System.Data.Entity;

namespace Products.DAL
{
    public class ProductsDataContext : DbContext
    {
        public ProductsDataContext() : base(ConfigurationManager.ConnectionStrings["WMDatabase"].ConnectionString)
        {
            // it is a code first approach hence it will create init db data
            Database.SetInitializer(new DBInitializer());
        }

        public DbSet<Product> Products { get; set; }
    }
}
