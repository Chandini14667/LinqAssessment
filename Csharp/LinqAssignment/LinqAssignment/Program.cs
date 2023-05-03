namespace LinqAssignment
{
    class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { ProductId = "P001", ProductName = "Laptop", Brand = "Dell", Quantity = 5, Price = 35000 },
                new Product { ProductId = "P002", ProductName = "Camera", Brand = "Canon", Quantity = 8, Price = 28500 },
                new Product { ProductId = "P003", ProductName = "Tablet", Brand = "Lenovo", Quantity = 4, Price = 15000 },
                new Product { ProductId = "P004", ProductName = "Mobile", Brand = "Apple", Quantity = 9, Price = 65000 },
                new Product { ProductId = "P005", ProductName = "Earphones", Brand = "Boat", Quantity = 2, Price = 1500 },
               
            };
            var query1 = products.Where(p => p.Price > 20000 && p.Price < 40000);
            foreach(Product p in query1)
            {
                Console.WriteLine($"{p.ProductName }");
                
            }
            Console.WriteLine("First one Completed");

            var query2 = products.Where(x => x.ProductName.Contains('a'));
            foreach (Product x in query2)
            {
                Console.WriteLine($"{x.ProductId} {x.ProductName} {x.Brand} {x.Quantity} {x.Price}");
                
            }
            Console.WriteLine("Second one Completed");

            var query3 = from c in products orderby c.ProductName select c;
            foreach(Product c in query3)
            {
                Console.WriteLine($"{c.ProductId} {c.ProductName} {c.Brand} {c.Quantity} {c.Price}");
                
            }
            Console.WriteLine("Third one Completed");

            var query4 = products.Where(a => a.Price == products.Max(a => a.Price)).ToList();
            foreach(Product a in query4) 
            {
                Console.WriteLine($"{a.Price}");
                
            }
            Console.WriteLine("Fourth one Completed");

            var query5 = products.Any(c => c.ProductId == "P003");
            Console.WriteLine(query5);
            Console.WriteLine("end");


        }
    }
}