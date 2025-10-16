// Creating objects of each class
using Demo10;

Clothing jeans = new Clothing("Jeans", 49.99, 10, "L", "Blue");
Food apple = new Food("Apple", 0.99, 50, new DateTime(2023, 5, 30));

bool expired = apple.CheckExpiry();

if (expired)
    Console.WriteLine("Expired!");
else
    Console.WriteLine("Good to consume");

List<Product> products =  new List<Product>();
products.Add(jeans);
products.Add(apple);

foreach (Product product in products)
{
    Console.WriteLine(product.GetInfo());
    Console.WriteLine();
}