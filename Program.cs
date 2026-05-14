using System;
using System.Collections.Generic;

class Product
{
    // Getters and Setters
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public string Category { get; set; }
 
    // Constructor
    public Product(int id, string name, double price, int stock, string category)
    {
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
        Category = category;
    }
}
class CartItem
{
    // Getters and Setters
    public Product Product { get; set; }
    public int Quantity { get; set; }

    // Constructor
    public CartItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
}
class Order
{
    // Getters and Setters
    public int ReceiptNumber { get; set; }
    public DateTime Date { get; set; }
    public double Total { get; set; }
}
