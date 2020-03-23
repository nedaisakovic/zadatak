using AutoMapper;
using Products.BL.Managers;
using Products.BL.Models;
using Products.Models;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace Products.Controllers
{
    public class ProductsController : Controller
    {
        private ProductsManager manager = new ProductsManager();

        /// <summary>
        /// Goes to products list page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View(Mapper.Map<List<Product>, List<ProductVM>>(manager.GetAll()));
        }

        /// <summary>
        /// Gets empty view for new product
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Creates new product and return to list of products
        /// </summary>
        /// <param name="productVm"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductVM productVm)
        {
            if (ModelState.IsValid)
            {
                manager.SaveProduct(Mapper.Map<ProductVM, Product>(productVm));
                return RedirectToAction("Index");
            }

            return View(productVm);
        }

        /// <summary>
        /// Gets view for selected product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ProductVM productVm = Mapper.Map<Product, ProductVM>(manager.GetProductById(id.Value));

            if (productVm == null)
            {
                return HttpNotFound();
            }

            return View(productVm);
        }

        /// <summary>
        /// Updates product and return to list of products if success
        /// </summary>
        /// <param name="productVm"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductVM productVm)
        {
            if (ModelState.IsValid)
            {
                manager.UpdateProduct(Mapper.Map<ProductVM, Product>(productVm));
                return RedirectToAction("Index");
            }
            return View(productVm);
        }
    }
}