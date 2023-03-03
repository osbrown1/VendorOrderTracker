using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string vendorName = "Suzie's Cafe";
      Vendor newVendor = new Vendor(vendorName);

      string result = newVendor.VendorName;

      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
      public void SetVendorName_SetVendorName_string()
      {
        string vendorName = "Test Vendor";
        Vendor newVendor = new Vendor(vendorName);

        string updatedVendorName = "Joe's Pub";
        newVendor.VendorName = updatedVendorName;
        string result = newVendor.VendorName;
        Assert.AreEqual(updatedVendorName, result);
      }

      [TestMethod]
      public void GetId_ReturnsVendorId_Int()
      {
        string vendorName = "Test Vendor";
        Vendor newVendor = new Vendor(vendorName);
        int result = newVendor.Id;
        Assert.AreEqual(1, result);
      }

  }
}