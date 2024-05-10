// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x = 10;

int [] myArray = {10, 20, 30};

List<int> myList = new List<int>();

List<string> listOfStrings = new List<string>() {"red", "green", "yellow"};

foreach (string element in listOfStrings)
 {
    Console.WriteLine(element);
 }

for (int i = 0; i < listOfStrings.Count; i++)
 {
    Console.WriteLine(listOfStrings[i]);
 }

 listOfStrings.Add("blue");
 listOfStrings.Remove("green");

 if (listOfStrings.Contains("red"))
    {
        Console.WriteLine("red is in your list!");
    }
    else
    {
        Console.WriteLine("red is NOT in your list");
    }

listOfStrings.Clear();
Console.WriteLine($"list of strings contains {listOfStrings.Count} elements"); 