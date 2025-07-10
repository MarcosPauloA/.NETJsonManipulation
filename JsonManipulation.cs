using Newtonsoft.Json;

public class Product{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public List<string> Tags { get; set; }

}
public class Program
{
    public static void Main(string[] args)
    {
        string json = "{\"Name\": \"Laptop\", \"Price\": 999.99, \"Tags\": [\"Electronics\", \"Computers\"]}";
        Product product = JsonConvert.DeserializeObject<Product>(json);
        Console.WriteLine($"Product Name: {product.Name}");
        Console.WriteLine($"Product Price: {product.Price}");
        Console.WriteLine("Product Tags: " + string.Join(", ", product.Tags));

        Product newProduct = new Product
        {
            Name = "Smartphone",
            Price = 499.99m,
            Tags = new List<string> { "Electronics", "Mobile" }
        };
        string newJson = JsonConvert.SerializeObject(newProduct, Formatting.Indented);
        Console.WriteLine($"Serialized Product: \n{newJson}");
        
        
    }
}
