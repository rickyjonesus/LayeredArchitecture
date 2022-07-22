// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var bs = new LayeredArchitecture.Business.BusinessService();

string model = bs.GetCar().Name;

Console.WriteLine(model);

