using AutoMapper;
using Products.BL.Models;
using Products.DAL.Managers;
using System.Collections.Generic;
using DAO = Products.DAL.Models;

namespace Products.BL.Managers
{
    public class ProductsManager
    {
        private ProductsPersistenceManager ppm = new ProductsPersistenceManager();

        #region Public methods

        /// <summary>
        /// Gets all products
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAll()
        {
            return Mapper.Map<List<DAO.Product>, List<Product>>(ppm.GetAll());
        }

        /// <summary>
        /// Saves product 
        /// </summary>
        /// <param name="product"></param>
        public void SaveProduct(Product product)
        {
            ppm.SaveProduct(Mapper.Map<Product, DAO.Product>(product));
        }

        /// <summary>
        /// Gets product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(int id)
        {
            return Mapper.Map<DAO.Product, Product>(ppm.GetProductById(id));
        }

        /// <summary>
        /// Updates product
        /// </summary>
        /// <param name="product"></param>
        public void UpdateProduct(Product product)
        {
            ppm.UpdateProduct(Mapper.Map<Product, DAO.Product>(product));
        }
        #endregion
    }
}
