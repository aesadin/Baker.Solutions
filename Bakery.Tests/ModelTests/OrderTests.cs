using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test2", "Test4");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrder_OrderList()
    {
      string title1 = "title1";
      string title2 = "title2";
      string description1 = "this is title1";
      string description2 = "this is title 2";
      string date1 = "this date";
      string date2 = "that date";
      Order newOrder1 = new Order(title1, description1, date1);
      Order newOrder2 = new Order(title2, description2, date2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiatedWithAnIdGetterReurns_Int()
    {
      string title = "title";
      string description = "this is title";
      string date = "that date";
      Order newOrder = new Order(title, description, date);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title1 = "title1";
      string title2 = "title2";
      string description1 = "this is title1";
      string description2 = "this is title 2";
      string date1 = "this date";
      string date2 = "that date";
      Order newOrder1 = new Order(title1, description1, date1);
      Order newOrder2 = new Order(title2, description2, date2);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
  }
}