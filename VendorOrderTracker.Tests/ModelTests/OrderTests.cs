using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }
    
    [TestMethod]
    public void 
    OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

     [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Bread";

      //Act
      Order newOrder = new Order(title);
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    } 

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Bread";
      Order newOrder = new Order(title);

      //Act
      string updatedTitle = "Whole Wheat";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(updatedTitle, result);
    } 

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string description01 = "Bread";
      string description02 = "White Bread";
      Order newOrder1 = new Order(description01);
      Order newOrder2 = new Order(description02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
