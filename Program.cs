/* Funcation First */

//using App1;
//using System.Linq;

//var cars = CarRepository.GetCars();

//var result = cars.First();

//Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/
/* Funcation FirstOrDefault */

//using App1;
//using System.Linq;

//var cars = CarRepository.GetCars();

//var defaultCar = new Car (0, "Default", "Default", 0, "Default", "Default", 0);

//// cars = []; /* If erase this comment the result will take the default car otherwise print the first */

//var result = cars.FirstOrDefault(defaultCar);

//Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/
/* Funcation Last */

//using App1;
//using System.Linq;

//var cars = CarRepository.GetCars();

//var result = cars.Last();

//Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/
/* Funcation LastOrDefault */

//using App1;
//using System.Linq;

//var cars = CarRepository.GetCars();

//var defaultCar = new Car(1, "Default", "Default", 1, "Default", "Default", 1);

//// cars = []; /* If erase this comment the result will take the default car otherwise print the last */

//var result = cars.LastOrDefault(defaultCar);

//Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/
/* Funcation Single */

//using App1;
//using System.Linq;

//var cars = CarRepository.GetCars();

//var result = cars.Single();

//Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/
/* Funcation SingleOrDefault */

//using App1;
//using System.Linq;

//var cars = CarRepository.GetCars();

//var defaultCar = new Car(1, "Default", "Default", 1, "Default", "Default", 1);

//// cars = [defaultCar]; /* If erase this comment the result will take the default car */

//var result = cars.SingleOrDefault();

//Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/
/* Funcation Any */

//using App1;
//using System.Linq;

//var cars = CarRepository.GetCars();

//var result = cars.Any(); // True
// var result = cars.Any(c => c.Make == "Ford"); // True
// var result2 = cars.Any(c => c.Id == 1001); // False

//Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/
/* Funcation All */

//using App1;
//using System.Linq;

//var cars = CarRepository.GetCars();

// var result = cars.All(c => c.Make == "Ford"); // False
// var result2 = cars.All(c => c.Year == 2020); // False

//Console.WriteLine(result);
/*-------------------------------------------------------------------------------------*/
/* Funcation Distinct */

//using App1;
//using System.Linq;

//var cars = CarRepository.GetCars();

//var result = cars.Distinct();

//foreach (var car in result)
//{
//    Console.WriteLine($"{car.Make} - {car.Year}");
//}
/*-------------------------------------------------------------------------------------*/
/* Funcation DistinctBy */

//using App1;
//using System.Linq;

//var cars = CarRepository.GetCars();

//var result = cars.DistinctBy(c => c.Make);

//foreach (var car in result)
//{
//    Console.WriteLine($"{car.Id} = {car.Make} - {car.MaxSpeed}km/h");
//}
/*-------------------------------------------------------------------------------------*/
/* Funcation OrderBy */

//using App1;
//using System.Linq;

//var cars = CarRepository.GetCars();

//var result = cars.OrderBy(c => c.Make);

//foreach (var car in result)
//{
//    Console.WriteLine($"{car.Make} - {car.Model} - {car.MaxSpeed}km/h");
//}
/*-------------------------------------------------------------------------------------*/
/* Funcation OrderByDescending */

//using App1;
//using System.Linq;

//var cars = CarRepository.GetCars();

//var result = cars.OrderByDescending(c => c.MaxSpeed);

//foreach (var car in result)
//{
//    Console.WriteLine($"{car.Make} - {car.MaxSpeed}km/h");
//}
/*-------------------------------------------------------------------------------------*/
/* Funcation Count */

//using App1;
//using System.Linq;

//var cars = CarRepository.GetCars();

//var result = cars.Count(); // 1000
//var result2 = cars.Count(c => c.Make == "Ford"); // 85
//var result3 = cars.Count(c => c.Year >= 2008); // 250

//Console.WriteLine($"{result} cars");
//Console.WriteLine($"{result2} fords' car");
//Console.WriteLine($"{result3} >= 2008");
/*-------------------------------------------------------------------------------------*/
