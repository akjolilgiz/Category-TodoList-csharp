using System.Collections.Generic;
using System;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description;
    private static List<Item> _instances = new List<Item> {};

    public Item (string description)
    {
      _description = description;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<Item> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
        public static void ClearAll()
    {
      _instances.Clear();
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string addOrView = Console.ReadLine();
      if(addOrView == "Add")
      {
        Console.WriteLine("What to do?");
        string descriptionInput = Console.ReadLine();
        Item newItem = new Item(descriptionInput);
        newItem.Save();
        Main();
      }
      else if (addOrView == "View")
      {
        List<Item> input = Item.GetAll();

        foreach(Item itemToDo in input)
        {
          Console.WriteLine(itemToDo.GetDescription());
        }
      }
      else
      {
        Main();
      }
    }
  }
}
