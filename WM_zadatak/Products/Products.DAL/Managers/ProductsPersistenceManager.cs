using Products.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Products.DAL.Managers
{
    public class ProductsPersistenceManager
    {
        private ProductsDataContext context = new ProductsDataContext();

        #region Public methods

        /// <summary>
        /// Gets all products
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        /// <summary>
        /// Saves product 
        /// </summary>
        /// <param name="product"></param>
        public void SaveProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        /// <summary>
        /// Gets product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(int id)
        {
            return context.Products.Find(id);
        }

        /// <summary>
        /// Updates product
        /// </summary>
        /// <param name="product"></param>
        public void UpdateProduct(Product product)
        {
            context.Entry(product).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion
    }
}
