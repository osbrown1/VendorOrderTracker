using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string VendorName { get; set; }
    public int Id { get; }
    public List<Vendor> Vendors { get; set; }

    public Vendor(string vendorName)
  {
    VendorName = vendorName;
    _instances.Add(this);
    Id = _instances.Count;
    Vendors = new List<Vendor> {};
  }

  public static void ClearAll()
  {
    _instances.Clear();
  }

  public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}
