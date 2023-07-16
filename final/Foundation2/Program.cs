using System;
class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("---------------------------------------------");

        Address address1 = new Address ("4728 University Ave.", "Tampa", "FL", "USA");
        Customer customer1 = new Customer("Shak Tyrison", address1);

        double order1ShippingCost = customer1.GetShippingCost();

        Product order1Product1 = new Product("Dry Fruit", "37419", 0.25, 2);
        Product order1Product2 = new Product("Cake", "12568", 0.50, 4);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        double order1Subtotal = order1.CalculateSubtotal();
        double order1Total = order1.CalculateTotal();

        order1.DisplayShippingLabel(); 
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayCosts(order1Subtotal ,order1ShippingCost, order1Total);

        Console.WriteLine("---------------------------------------------");

        Address address2 = new Address ("Emiliano Zapata 53", "San Lorenzo", "Atizapan", "Mexico");
        Customer customer2 = new Customer("Lam Woodse", address2);

        double order2ShippingCost = customer2.GetShippingCost();

        Product order2Product1 = new Product("Mini CPU", "77285", 2.00, 5);
        Product order2Product2 = new Product("Monitor", "77763", 1.00, 4);
        Product order2Product3 = new Product("Powercord", "69006", 2.00, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.CalculateSubtotal();
        double order2Total = order2.CalculateTotal();

        order2.DisplayShippingLabel(); 
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
        Console.WriteLine("---------------------------------------------");
    }   
}