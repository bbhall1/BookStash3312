// See https://aka.ms/new-console-template for more information

using ClassReview;

Car carOne = new Car();
carOne.Make = "Subaru";
carOne.Model = "Forester";
carOne.numDoors = 4;

Console.WriteLine($"carOne Make {carOne.Make} {carOne.Model} {carOne.numDoors}");

Car carTwo = new Car {Make = "Chevrolet", Model = "Silverado", numDoors = 2};

Console.WriteLine($"Car Two {carTwo.Make} {carTwo.Model} {carTwo.numDoors}");