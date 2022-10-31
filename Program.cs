// See https://aka.ms/new-console-template for more information
using Lesson_6_Class;
using System.ComponentModel;
Initializator initializator = new Initializator();
Inventorycs inventory = initializator.Initialize();

initializator.Initialize();
inventory.PrintAllProduct();

List<Food> result = inventory.SortByType<Food>();
List<Food> result2 = inventory.SumByType<Food>();
List<Machinery> result5 = inventory.SortByType<Machinery>();
List<Machinery> result6 = inventory.SumByType<Machinery>();
List<Chemical> chemicals = inventory.SortByType<Chemical>();
List<Chemical> chemicals2 = inventory.SumByType<Chemical>();
inventory.SumInventorycsAll();