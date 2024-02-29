

namespace InventoryManagement
{
    class InventorySystem
    {
        private List<Product> products;

        public InventorySystem()
        {
            this.products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public int TotalProducts()
        {
            return products.Count;
        }

        public void PrintProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(product);
            }
        }

        public List<Product> FindProductsByType(string type)
        {
            return products.Where(p => p.Type == type).ToList();
        }

        public void RemoveProduct(string name)
        {
            products.RemoveAll(p => p.Name == name);
        }

        public void UpdateProductQuantity(string name, int quantity)
        {
            var product = products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                product.Quantity = quantity;
            }
        }

        public decimal CalculateTotalPrice(params (string name, decimal weight)[] items)
        {
            decimal totalPrice = 0;
            foreach (var item in items)
            {
                var product = products.FirstOrDefault(p => p.Name == item.name);
                if (product != null)
                {
                    totalPrice += (product.Price * item.weight);
                }
            }
            return totalPrice;
        }
    }
}