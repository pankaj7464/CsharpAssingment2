
namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            InventorySystem inventorySystem = new InventorySystem{ };
            inventorySystem.AddProduct(new Product("lettuce", 10.5m, 50, "Leafy green"));
            inventorySystem.AddProduct(new Product("cabbage", 20m, 100, "Cruciferous"));
            inventorySystem.AddProduct(new Product("pumpkin", 30m, 30, "Marrow"));
            inventorySystem.AddProduct(new Product("cauliflower", 10m, 25, "Cruciferous"));
            inventorySystem.AddProduct(new Product("zucchini", 20.5m, 50, "Marrow"));
            inventorySystem.AddProduct(new Product("yam", 30m, 50, "Root"));
            inventorySystem.AddProduct(new Product("spinach", 10m, 100, "Leafy green"));
            inventorySystem.AddProduct(new Product("broccoli", 20.2m, 75, "Cruciferous"));
            inventorySystem.AddProduct(new Product("garlic", 30m, 20, "Leafy green"));
            inventorySystem.AddProduct(new Product("silverbeet", 10m, 50, "Marrow"));



            // Print total number of products
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Total number of products: " + inventorySystem.TotalProducts());

            // Add a new product
            Console.WriteLine("----------------------------------------");
            inventorySystem.AddProduct(new Product("Potato", 10m, 50, "Root"));

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\nList of all products after adding Potato:");
            inventorySystem.PrintProducts();
            Console.WriteLine("Total number of products: " + inventorySystem.TotalProducts());

            // Print all products of type Leafy green
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\nProducts of type Leafy green:");
            foreach (var product in inventorySystem.FindProductsByType("Leafy green"))
            {
                Console.WriteLine(product);
            }

            // Remove Garlic from the list
            Console.WriteLine("----------------------------------------");
            inventorySystem.RemoveProduct("garlic");
            Console.WriteLine("\nTotal number of products left after removing Garlic: " + inventorySystem.TotalProducts());

            // Update quantity of Cabbage
            Console.WriteLine("----------------------------------------");
            inventorySystem.UpdateProductQuantity("cabbage", 150);
            Console.WriteLine("\nUpdated quantity of Cabbage: " + inventorySystem.FindProductsByType("Cruciferous").FirstOrDefault(p => p.Name == "cabbage").Quantity);

            // Calculate total price
            Console.WriteLine("----------------------------------------");
            decimal totalPrice = inventorySystem.CalculateTotalPrice(("lettuce", 1), ("zucchini", 2), ("broccoli", 1));
            Console.WriteLine("\nTotal price for 1kg lettuce, 2kg zucchini, 1kg broccoli: " + totalPrice + " RS");
        }
    }
}