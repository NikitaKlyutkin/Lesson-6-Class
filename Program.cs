﻿// See https://aka.ms/new-console-template for more information
using Lesson_6_Class;
using System.ComponentModel;
Initializator initializator = new Initializator();
Inventorycs inventory = initializator.Initialize();

initializator.Initialize();
inventory.PrintAllProduct();

Console.WriteLine("_____________________");
Console.WriteLine("Sort by Food:");
List<Food> result = inventory.SortByType<Food>();