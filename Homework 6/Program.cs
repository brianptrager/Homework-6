using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = setupOrders();

            //PART 1
            Console.WriteLine("Get a list of all orders on or after April 8, 2017.");

            //TODO

            //PART 2
            Console.WriteLine("Same as #1, but retrieve only the orderID and the amount into an anonymous type.");


            //TODO

            //PART 3
            Console.WriteLine("Find the order by the largest amount.");


            //TODO

            //PART 4
            Console.WriteLine("Find all orders containing widgets.");


            //TODO

            //PART 5
            Console.WriteLine("Sum up the value of all order items.");


            //TODO

            //PART 6
            Console.WriteLine("The average order total.");


            //TODO

            //PART 7
            Console.WriteLine("How many orders have multiple items?");


            //TODO

            Console.ReadLine();

            //PART 8
            Console.WriteLine("Create a flat list of a new anonymous type using LINQ to project the fields OrderID, OrderItemID, ProductName of every order item.");


            //TODO

            //PART 9
            Console.WriteLine("Create a new set of orders based on the existing orders, BUT add 1000 to each OrderID and set the OrderDate to now.  (Yes, this is evil!)");


            //TODO

            //PART 10
            Console.WriteLine("Create your own query by generating an anonymous type to display a customized list of orders.");


            //TODO

            Console.ReadLine();
        }

        private static List<Order> setupOrders()
        {
            List<Order> orderList = new List<Order>();

            Order o1 = new Order();
            o1.OrderDate = DateTime.Parse("4/7/2017 1:05 PM");
            o1.OrderID = 9009;
            o1.OrderAmount = 150M;

            OrderItem oi1 = new OrderItem();
            oi1.OrderItemID = 123;
            oi1.ProductName = "FooBar";
            oi1.Quantity = 2;
            o1.OrderItems.Add(oi1);

            OrderItem oi2 = new OrderItem();
            oi2.OrderItemID = 124;
            oi2.ProductName = "BazQuirk";
            oi2.Quantity = 3;
            o1.OrderItems.Add(oi2);

            Order o2 = new Order();
            o2.OrderDate = DateTime.Parse("4/8/2017 8:20 AM");
            o2.OrderID = 9114;
            o2.OrderAmount = 175M;

            OrderItem oi3 = new OrderItem();
            oi3.OrderItemID = 125;
            oi3.ProductName = "FooBar";
            oi3.Quantity = 1;
            o2.OrderItems.Add(oi3);

            OrderItem oi4 = new OrderItem();
            oi4.OrderItemID = 126;
            oi4.ProductName = "Gadgets";
            oi4.Quantity = 5;
            o2.OrderItems.Add(oi4);

            OrderItem oi5 = new OrderItem();
            oi5.OrderItemID = 127;
            oi5.ProductName = "BazQuirk";
            oi5.Quantity = 1;
            o2.OrderItems.Add(oi5);

            OrderItem oi6 = new OrderItem();
            oi6.OrderItemID = 128;
            oi6.ProductName = "Widgets";
            oi6.Quantity = 5;
            o2.OrderItems.Add(oi6);

            Order o3 = new Order();
            o3.OrderDate = DateTime.Parse("4/9/2017 11:14 AM");
            o3.OrderID = 1104;
            o3.OrderAmount = 250M;

            OrderItem oi7 = new OrderItem();
            oi7.OrderItemID = 129;
            oi7.ProductName = "Widgets";
            oi7.Quantity = 14;
            o3.OrderItems.Add(oi7);

            Order o4 = new Order();
            o4.OrderDate = DateTime.Parse("4/10/2017 8:20 AM");
            o4.OrderID = 1234;
            o4.OrderAmount = 225M;

            OrderItem oi8 = new OrderItem();
            oi8.OrderItemID = 130;
            oi8.ProductName = "Gadgets";
            oi8.Quantity = 5;
            o4.OrderItems.Add(oi8);

            OrderItem oi9 = new OrderItem();
            oi9.OrderItemID = 130;
            oi9.ProductName = "Widgets";
            oi9.Quantity = 1;
            o4.OrderItems.Add(oi9);

            orderList.Add(o1);
            orderList.Add(o2);
            orderList.Add(o3);
            orderList.Add(o4);

            return orderList;

        }
    }

    class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderAmount { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

        public Order(int orderID, DateTime orderDate)
        {
            OrderID = orderID;
            OrderDate = orderDate;
        }
    }

    class OrderItem
    {
        public int OrderItemID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

    }

    class Address
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    class OrderSummary
    {
        public DateTime OrderDate { get; set; }
        public int OrderID { get; set; }
    }
}
