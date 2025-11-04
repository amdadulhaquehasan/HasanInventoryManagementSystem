using HasanInventoryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace HasanInventoryManagementSystem.Controllers
{
    public class ProductController : Controller
    {
        private List<ProductViewModel> _products = new List<ProductViewModel>()
        {
            new ProductViewModel(){ProductId = 1, ProductName = "Car", ProductBrand = "Toyota", Price = 100000.25m, ProductCategory = "Electronic"},
            new ProductViewModel(){ ProductId = 2, ProductName = "Laptop", ProductBrand = "Dell", Price = 85000.99m, ProductCategory = "Electronics" },
            new ProductViewModel(){ ProductId = 3, ProductName = "Smartphone", ProductBrand = "Samsung", Price = 69999.50m, ProductCategory = "Electronics" },
            new ProductViewModel(){ ProductId = 4, ProductName = "Washing Machine", ProductBrand = "LG", Price = 55000.00m, ProductCategory = "Home Appliance" },
            new ProductViewModel(){ ProductId = 5, ProductName = "Table", ProductBrand = "IKEA", Price = 12000.75m, ProductCategory = "Furniture" },
            new ProductViewModel(){ ProductId = 6, ProductName = "Air Conditioner", ProductBrand = "Hitachi", Price = 75000.00m, ProductCategory = "Home Appliance" },
            new ProductViewModel(){ ProductId = 7, ProductName = "Headphones", ProductBrand = "Sony", Price = 9999.99m, ProductCategory = "Electronics" },
            new ProductViewModel(){ ProductId = 8, ProductName = "Refrigerator", ProductBrand = "Whirlpool", Price = 68000.50m, ProductCategory = "Home Appliance" },
            new ProductViewModel(){ ProductId = 9, ProductName = "Chair", ProductBrand = "Hatil", Price = 7500.00m, ProductCategory = "Furniture" },
            new ProductViewModel(){ ProductId = 10, ProductName = "Microwave Oven", ProductBrand = "Panasonic", Price = 18500.25m, ProductCategory = "Home Appliance" },
            new ProductViewModel(){ ProductId = 11, ProductName = "Smartwatch", ProductBrand = "Apple", Price = 45999.00m, ProductCategory = "Electronics" },
            new ProductViewModel(){ ProductId = 12, ProductName = "Electric Scooter", ProductBrand = "Xiaomi", Price = 95000.00m, ProductCategory = "Automotive" }

        };
        public IActionResult Products()
        {
            var products = _products;

            return View(products);
        }

        public IActionResult Edit(int productId)
        {
            var SelectedProduct = _products
                .Where(p => p.ProductId == productId)
                .FirstOrDefault();

            return View(SelectedProduct);
        }

        public IActionResult Update(ProductViewModel product)
        {
            return RedirectToAction("Products");
        }
    }
}
