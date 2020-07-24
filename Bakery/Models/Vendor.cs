using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor 
  {
    private static List<Vendor> _listOfOrders = new List<Vendor> {};
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public int Id { get; }
    public List<Order> Order { get; set; }

    public Vendor (string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      _listOfOrders.Add(this);
      Id = _listOfOrders.Count;
      Order = new List<Order> {};
    }
    public static void ClearAll()
    {
      _listOfOrders.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _listOfOrders;
    }
  }
}