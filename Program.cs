using LinqForCSharpDevelopers;

var cars = CarRepository.GetCars();

foreach (var car in cars)
{
    Console.WriteLine(car);
}
