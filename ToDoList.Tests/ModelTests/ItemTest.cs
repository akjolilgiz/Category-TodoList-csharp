using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;
using System;

namespace ToDoList.Tests
  {
    [TestClass]
    public class ItemTest : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }
    [TestMethod]
    public void GetDescription_ReturnsDesctiption_String()
    {
      // Arrange
      string description = "Walk Chan.";
      Item newItem = new Item(description);

      // Action
      string result = newItem.GetDescription();

      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetNewDesctiption_String()
    {
      // Arrange
      string description = "Walk Chan.";
      Item newItem = new Item(description);

      // Act
      string updatedDescription = "Feed Chan.";
      newItem.SetDescription(updatedDescription);
      string result = newItem.GetDescription();

      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void SaveAll_AddInstances_List()
    {
      // Arrange
      string description = "Walk Chan.";
      Item newItem = new Item(description);
      newItem.Save();

      // Act
      List<Item> instances = Item.GetAll();
      Item result = instances[0];

      Assert.AreEqual(newItem, result);
    }
    [TestMethod]
    public void GetAll_ReturnInstances_List()
    {
      // Arrange
      string description1 = "Text Chan.";
      Item newItem1 = new Item(description1);
      newItem1.Save();

      string description2 = "Chan.";
      Item newItem2 = new Item(description2);
      newItem2.Save();

      List<Item> newInstances = new List<Item> {newItem1, newItem2};

      // Action
      List<Item> result = Item.GetAll();

      foreach (Item thisItem in result)
    {
      Console.WriteLine("Output: " + thisItem.GetDescription());
    }

      CollectionAssert.AreEqual(newInstances, result);

    }
  }
}
