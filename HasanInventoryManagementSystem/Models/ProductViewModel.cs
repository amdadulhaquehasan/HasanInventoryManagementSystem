namespace HasanInventoryManagementSystem.Models
{
    public class ProductViewModel
    {
        #region Properties
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public string ProductCategory { get; set; }
        public decimal Price { get; set; }

        #endregion
    }
}
