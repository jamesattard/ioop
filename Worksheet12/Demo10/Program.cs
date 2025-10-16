// Creating objects of each class
using Demo10;

Clothing jeans = new Clothing("Jeans", 49.99, 10, "L", "Blue");
Electronics laptop = new Electronics("Laptop", 799.99, 5, 24, 65);
Food apple = new Food("Apple", 0.99, 50, new DateTime(2023, 5, 30));
Furniture bed = new Furniture("Bed", 199, 20, "Pine", 300);

bool expired = apple.CheckExpiry();

if (expired)
    Console.WriteLine("Expired!");
else
    Console.WriteLine("Good to consume");

bool delivery = bed.EligibleForDelivery();
if (delivery)
    Console.WriteLine("Eligible for delivery");
else
    Console.WriteLine("Not eligible for delivery");

List<Product> products =  new List<Product>();
products.Add(jeans);
products.Add(laptop);
products.Add(apple);
products.Add(bed);

foreach (Product product in products)
{
    Console.WriteLine(product.GetInfo());
    Console.WriteLine(product.ApplyDiscount(20));
    Console.WriteLine();
}