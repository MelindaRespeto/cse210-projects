using System;
using System.Collections.Generic;

// Product class
class Product
{
    public string Name { get; set; }
    public string ProductID { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, string productID, double price, int quantity)
    {
        Name = name;
        ProductID = productID;
        Price = price;
        Quantity = quantity;
    }

    // Compute total cost for this product
    public double TotalCost()
    {
        return Price * Quantity;
    }
}

// Address class
class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string StateOrProvince { get; set; }
    public string Country { get; set; }

    public Address(string street, string city, string stateOrProvince, string country)
    {
        Street = street;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    // Check if address is in the USA
    public bool IsInUSA()
    {
        return Country.ToUpper() == "USA";
    }

    // Return full address as string
    public string FullAddress()
    {
        return $"{Street}\n{City}, {StateOrProvince}\n{Country}";
    }
}

// Customer class
class Customer
{
    public string Name { get; set; }
    public Address Address { get; set; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    // Check if customer lives in the USA
    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }
}

// Order class
class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    // Calculate total cost including shipping
    public double TotalCost()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.TotalCost();
        }

        // Shipping cost
        double shippingCost = Customer.IsInUSA() ? 5 : 35;
        total += shippingCost;

        return total;
    }

    // Packing label: product name and ID
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"Product: {product.Name}, ID: {product.ProductID}\n";
        }
        return label;
    }

    // Shipping label: customer name and address
    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {Customer.Name}\n{Customer.Address.FullAddress()}";
    }
}

// Test program
class Program
{
    static void Main(string[] args)
    {
        // Create address
        Address address = new Address("123 Main St", "Los Angeles", "CA", "USA");

        // Create customer
        Customer customer = new Customer("Melinda", address);

        // Create products
        Product product1 = new Product("Cellphone", "LAP123", 999.99, 1);
        Product product2 = new Product("Mouse", "MOU456", 25.50, 2);

        // Create order
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Print labels and total cost
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.TotalCost():0.00}");
    }
}
