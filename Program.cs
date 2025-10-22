/* Funcation First */
var cars = CarRepository.GetCars();
var result = cars.First();
Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/

/* Funcation FirstOrDefault */
var cars = CarRepository.GetCars();
var defaultCar = new Car (0, "Default", "Default", 0, "Default", "Default", 0);
var result = cars.FirstOrDefault(defaultCar);
Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/

/* Funcation Last */
var cars = CarRepository.GetCars();
var result = cars.Last();
Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/

/* Funcation LastOrDefault */
var cars = CarRepository.GetCars();
var defaultCar = new Car(1, "Default", "Default", 1, "Default", "Default", 1);
var result = cars.LastOrDefault(defaultCar);
Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/

/* Funcation Single */
var cars = CarRepository.GetCars();
var result = cars.Single();
Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/

/* Funcation SingleOrDefault */
var cars = CarRepository.GetCars();
var defaultCar = new Car(1, "Default", "Default", 1, "Default", "Default", 1);
var result = cars.SingleOrDefault();
Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/

/* Funcation Any */
var cars = CarRepository.GetCars();
var result = cars.Any();
Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/

/* Funcation All */
var cars = CarRepository.GetCars();
var result = cars.All(c => c.Make == "Ford");
Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/

/* Funcation Distinct */
var cars = CarRepository.GetCars();
var result = cars.Distinct();
foreach (var car in result)
{
    Console.WriteLine($"{car.Make} - {car.Year}");
}
/*-------------------------------------------------------------------------------------*/

/* Funcation DistinctBy */
var cars = CarRepository.GetCars();
var result = cars.DistinctBy(c => c.Make);
foreach (var car in result)
{
    Console.WriteLine($"{car.Id} = {car.Make} - {car.MaxSpeed}km/h");
}
/*-------------------------------------------------------------------------------------*/

/* Funcation OrderBy */
var cars = CarRepository.GetCars();
var result = cars.OrderBy(c => c.Make);
foreach (var car in result)
{
    Console.WriteLine($"{car.Make} - {car.Model} - {car.MaxSpeed}km/h");
}
/*-------------------------------------------------------------------------------------*/

/* Funcation OrderByDescending */
var cars = CarRepository.GetCars();
var result = cars.OrderByDescending(c => c.MaxSpeed);
foreach (var car in result)
{
    Console.WriteLine($"{car.Make} - {car.MaxSpeed}km/h");
}
/*-------------------------------------------------------------------------------------*/

/* Funcation Count */
var cars = CarRepository.GetCars();
var result = cars.Count();
var result2 = cars.Count(c => c.Make == "Ford");
var result3 = cars.Count(c => c.Year >= 2008);
Console.WriteLine($"{result} cars");
Console.WriteLine($"{result2} fords' car");
Console.WriteLine($"{result3} >= 2008");
/*-------------------------------------------------------------------------------------*/
