using Products.DAL.Models;
using System.Data.Entity;

namespace Products.DAL
{
    public class DBInitializer : DropCreateDatabaseAlways<ProductsDataContext>
    {
        protected override void Seed(ProductsDataContext context)
        {
            context.Products.Add(
                new Product
                {
                    Name = "Samsung The frame",
                    Description = "Smart TV",
                    Category = "TV",
                    Manufacturer = "Samsung",
                    Supplier = "Tehnomanija",
                    Price = 1100
                });

            context.Products.Add(
                new Product
                {
                    Name = "HUAWEI power bank",
                    Description = "HUAWEI power bank",
                    Category = "Charger",
                    Manufacturer = "Huawei",
                    Supplier = "Tehnomanija",
                    Price = 30
                });

            context.Products.Add(
                new Product
                {
                    Id = 1,
                    Name = "Huawei P30-Kristal",
                    Description = "Conversation-changer",
                    Category = "Mobile Phones",
                    Manufacturer = "Huawei",
                    Supplier = "Tehnomanija",
                    Price = 700
                });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
