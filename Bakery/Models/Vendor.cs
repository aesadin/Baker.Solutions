using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor 
  {
    private static List<Vendor> _listOfVendors = new List<Vendor> {};
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public int Id { get; }
    public List<Order> Order { get; set; }

    public Vendor (string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      _listOfVendors.Add(this);
      Id = _listOfVendors.Count;
      Order = new List<Order> {};
    }
    public static void ClearAll()
    {
      _listOfVendors.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _listOfVendors;
    }
    public static Vendor Find(int searchId)
    {
      return _listOfVendors[searchId-1];
    }
  }
}