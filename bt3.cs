using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
}

public class JsonManager
{
    public static List<Product> ReadProductsFromJson(string filePath)
    {
        var products = new List<Product>();

        using (var reader = new StreamReader(filePath))
        {
            var json = reader.ReadToEnd();
            products = JsonSerializer.Deserialize<List<Product>>(json);
        }

        return products;
    }

    public static void WriteProductsToJson(string filePath, List<Product> products)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        var json = JsonSerializer.Serialize(products, options);

        File.WriteAllText(filePath, json);
    }
}

public class bt3
{
    public static void Main(string[] args)
    {
        var products = JsonManager.ReadProductsFromJson("products.json");

        // Thao tác với danh sách products ở đây

        JsonManager.WriteProductsToJson("products_output.json", products);
    }
}