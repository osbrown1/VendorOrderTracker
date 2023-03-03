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

      [TestMethod]
      public void GetAll_ReturnsVendors_VendorList()
      {
      string vendorName01 = "Joe's Pub";
      string vendorName02 = "Test Vendor";
      Vendor newVendor1 = new Vendor(vendorName01);
      Vendor newVendor2 = new Vendor(vendorName02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
      }

      [TestMethod]
      public void Find_ReturnsCorrectVendor_Vendor()
      {
      string vendorName01 = "Joe's Pub";
      string vendorName02 = "Test Vendor";
      Vendor newVendor1 = new Vendor(vendorName01);
      Vendor newVendor2 = new Vendor(vendorName02);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
      }

  }
}