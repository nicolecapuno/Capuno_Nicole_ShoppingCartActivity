using System;
using System.Collections.Generic;

class Product
{
    // Properties (Getter and Setter)
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public string Category { get; set; }
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
    // Properties
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public CartItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
}
class Order
{
    // Properties
    public int ReceiptNumber { get; set; }
    public DateTime Date { get; set; }
    public double Total { get; set; }
}
