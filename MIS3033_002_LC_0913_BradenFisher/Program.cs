// MIS 3033 002 
// September 13, 2023
// Braden Fisher. 113492081
using a;

Console.WriteLine("Entity Framework 2");

OrderDB orderdb;
orderdb = new OrderDB();

Order order = new Order() { Id = 123, QtyApple = 3.5, QtyBananas = 4.6 };

orderdb.ordersTbl.Add(order);
orderdb.SaveChanges();