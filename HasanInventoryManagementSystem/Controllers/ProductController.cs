using HasanInventoryManagementSystem.InMemoryDb;
using HasanInventoryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace HasanInventoryManagementSystem.Controllers
{
    public class ProductController : Controller
    {
        #region Get

        [HttpGet]
        public IActionResult Products()
        {
            var products = ProductDb.products;

            return View(products);
        }

        [HttpGet]
        public IActionResult Edit(int productId)
        {
            var SelectedProduct = ProductDb.products
                .Where(p => p.ProductId == productId)
                .FirstOrDefault();

            ViewBag.PageHeader = "Update Product";
            ViewBag.ButtonText = "Update";

            return View(SelectedProduct);
        }

        [HttpGet]
        public IActionResult Create(int productId)
        {
            var maxProductId = ProductDb.products
                .Max(p => p.ProductId);
            ProductViewModel product = new ProductViewModel();
            product.ProductId = maxProductId+1;

            ViewBag.PageHeader = "Create New Product";
            ViewBag.ButtonText = "Create";

            return View("Edit", product);
        }

        [HttpGet]
        public IActionResult Delete(int productId)
        {
            var index = ProductDb.products
                .FindIndex(p => p.ProductId == productId);
            if(index >= 0)
                ProductDb.products.RemoveAt(index);

            return RedirectToAction("Products");
        }

        #endregion

        #region Post

        [HttpPost]
        public IActionResult Update(ProductViewModel product)
        {
            var index = ProductDb.products
                .FindIndex(p => p.ProductId == product.ProductId);

            if(index < 0)
            {
                ProductDb.products.Add(product);
            }
            else
            {
                ProductDb.products.RemoveAt(index);
                ProductDb.products.Add(product);
            }

            return RedirectToAction("Products");
        }

        #endregion
    }
}
