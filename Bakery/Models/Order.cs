using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string OrderItem { get; set;}
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _listOfOrders = new List<Order> {};
    public Order (string orderItem, string description, string date)
    {
      OrderItem = orderItem;
      Description = description;
      Price = Price;
      Date = date;
      _listOfOrders.Add(this);
      Id = _listOfOrders.Count;
    }

    public static void ClearAll()
    {
      _listOfOrders.Clear();
    }
  }
}