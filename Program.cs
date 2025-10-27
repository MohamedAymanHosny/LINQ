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
/* Funcation Max */

int[] numbers = [1, 5, 8, 12, 20];
var maximum = numbers.Max();
Console.WriteLine(maximum);
/*-------------------------------------------------------------------------------------*/
/* Funcation Min */

using System.Linq;
int[] numbers = [1, 5, 8, 12, 20];
var minimum = numbers.Min();
Console.WriteLine(minimum);
/*-------------------------------------------------------------------------------------*/
/* Funcation Average */

using System.Linq;
int[] numbers = [1, 5, 8, 12, 20];
var average = numbers.Average();
Console.WriteLine(average);
/*-------------------------------------------------------------------------------------*/
/* Funcation AggregateBy */

List<Employee> employees =
[
    new("Mohamed", "HR", 60_000),
    new("Ahmed", "IT", 80_000),
    new("Mohsen", "HR", 70_000),
    new("Saif", "IT", 90_000),
];
var salary = employees.AggregateBy(e => e.Department, seed: 0.0, (total, employee) => total + employee.Salary);
foreach (var item in salary)
{
    Console.WriteLine($"{item.Key} : {item.Value}");
}
var cars = CarRepository.GetCars();
var carWithModel = Car.AggregateBy
    (
     c => c.Make,
     seed: new List<string>(),
     (models, car) => [.. models, car.Model]
    );
foreach (var item in carWithModel)
{
    WriteLine(item.Key);

    foreach (var model in item.Value)
    {
        WriteLine($"\t {model}");
    }
}
/*-------------------------------------------------------------------------------------*/
/* Funcation Chunk */

var cars = CarRepository.GetCars();
var result = cars.Chunk(33);
foreach (var chunk in result)
{
    foreach (var car in chunk)
    {
        Console.WriteLine($"Make: {car.Make} + Model: {car.Model}");
    }

    Console.WriteLine("-------------------- End of Chunk --------------------");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation Take */

var cars = CarRepository.GetCars();
var result = cars.Take(new Range(0, 3));
foreach (var car in result)
{
    Console.WriteLine($"{car.Id} - {car.Make} - {car.Model}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation TakeLast */

var cars = CarRepository.GetCars();
var result = cars.TakeLast(10);
foreach (var car in result)
{
    Console.WriteLine($"{car.Id} - {car.Make} - {car.Model}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation TakeWhile */

var cars = CarRepository.GetCars();
//var result = cars.TakeWhile(c => c.MaxSpeed > 200);
var result = cars.TakeWhile((c, i) => i < 200);
foreach (var car in result)
{
    Console.WriteLine($"{car.Id} - {car.Make} - {car.MaxSpeed}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation Skip */

var cars = CarRepository.GetCars();
var result = cars.Skip(100);
foreach (var car in result)
{
    Console.WriteLine($"{car.Id} - {car.Make} - {car.Model}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation SkipLast */

var cars = CarRepository.GetCars();
var result = cars.SkipLast(200);
foreach (var car in result)
{
    Console.WriteLine($"{car.Id} - {car.Make} - {car.Model}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation SkipWhile */

var cars = CarRepository.GetCars();
var result = cars.SkipWhile(c => c.Make == "Volvo");
var result2 = cars.TakeWhile((c, i) => i < 200);
foreach (var car in result)
{
    Console.WriteLine($"{car.Id} - {car.Make} - {car.MaxSpeed}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation DefaultIfEmpty */

var cars = CarRepository.GetCars();
var EmptyList = Enumerable.Empty<Car>();
int[] numbers = [];
var results = numbers.DefaultIfEmpty(1000);
foreach (var car in results)
{
    Console.WriteLine(car);
}
/*-------------------------------------------------------------------------------------*/
/* Funcation ElementAt */

var cars = CarRepository.GetCars();
var result = cars.ElementAt(0);
var result1 = cars.ElementAt(new Index(1, true));
Console.WriteLine(result);
Console.WriteLine(result1);
/*-------------------------------------------------------------------------------------*/
/* Funcation ElementAtOrDefault */

var cars = CarRepository.GetCars();
var result = cars.ElementAtOrDefault(1000);
var result1 = cars.ElementAtOrDefault(new Index(1, true));
int[] numbers = [];
var result2 = numbers.ElementAtOrDefault(1000);
Console.WriteLine(result);
Console.WriteLine(result1);
Console.WriteLine(result2);
/*-------------------------------------------------------------------------------------*/
/* Funcation Index */

var cars = CarRepository.GetCars();
var result = cars.Index();
foreach (var car in result)
{
    Console.WriteLine($"{car.Index} - {car.Item}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation Concat */

List<Car> cars1 =
[
        new Car(1,"Ford","GT",2005,"WAU3FAFR0BA781507","Mauv",298),
        new Car(2,"Mercury","Mystique",2000,"1FTEW1C89AK439924","Turquoise",217),
        new Car(3,"Volvo","S40",2001,"JTHBK1GGXF2728528","Orange",214),
        new Car(4,"Nissan","Maxima",2010,"TRUXD38J191264584","Fuscia",243),
        new Car(5,"Oldsmobile","Bravada",1994,"WAUDH48H19K669503","Yellow",221),
];
List<Car> cars2 =
[
        new Car(6,"Mercury","Mariner",2005,"5N1AA0NE4EN089552","Puce",282),
        new Car(7,"Geo","Tracker",1995,"3GYFK66N15G463658","Puce",259),
        new Car(8,"Mitsubishi","GTO",1991,"1VWAP7A39EC013320","Aquamarine",274),
        new Car(9,"Volkswagen","Eurovan",1995,"KMHFH4JG7FA285977","Orange",236),
        new Car(10,"GMC","Sierra 2500",2002,"1FAHP2D87DG093452","Yellow",275),
];
List<Car> cars3 =
[
        new Car(6,"Mercury","Mariner",2005,"5N1AA0NE4EN089552","Puce",282),
        new Car(7,"Geo","Tracker",1995,"3GYFK66N15G463658","Puce",259),
        new Car(8,"Mitsubishi","GTO",1991,"1VWAP7A39EC013320","Aquamarine",274),
        new Car(9,"Volkswagen","Eurovan",1995,"KMHFH4JG7FA285977","Orange",236),
        new Car(10,"GMC","Sierra 2500",2002,"1FAHP2D87DG093452","Yellow",275),
];
var allcars = cars1.Concat(cars2);
foreach (Car car in allcars)
{
    Console.WriteLine($"{car.Make} {car.Model}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation Union */

List<Car> cars1 =
[
        new Car(1,"Ford","GT",2005,"WAU3FAFR0BA781507","Mauv",298),
        new Car(2,"Mercury","Mystique",2000,"1FTEW1C89AK439924","Turquoise",217),
        new Car(3,"Volvo","S40",2001,"JTHBK1GGXF2728528","Orange",214),
        new Car(4,"Nissan","Maxima",2010,"TRUXD38J191264584","Fuscia",243),
        new Car(5,"Oldsmobile","Bravada",1994,"WAUDH48H19K669503","Yellow",221),
];
List<Car> cars2 =
[
        new Car(6,"Mercury","Mariner",2005,"5N1AA0NE4EN089552","Puce",282),
        new Car(7,"Geo","Tracker",1995,"3GYFK66N15G463658","Puce",259),
        new Car(8,"Mitsubishi","GTO",1991,"1VWAP7A39EC013320","Aquamarine",274),
        new Car(9,"Volkswagen","Eurovan",1995,"KMHFH4JG7FA285977","Orange",236),
        new Car(10,"GMC","Sierra 2500",2002,"1FAHP2D87DG093452","Yellow",275),
];
List<Car> cars3 =
[
        new Car(6,"Mercury","Mariner",2005,"5N1AA0NE4EN089552","Puce",282),
        new Car(7,"Geo","Tracker",1995,"3GYFK66N15G463658","Puce",259),
        new Car(8,"Mitsubishi","GTO",1991,"1VWAP7A39EC013320","Aquamarine",274),
        new Car(9,"Volkswagen","Eurovan",1995,"KMHFH4JG7FA285977","Orange",236),
        new Car(10,"GMC","Sierra 2500",2002,"1FAHP2D87DG093452","Yellow",275),
];
var allcars = cars1.Union(cars2).Union(cars3);
foreach (Car car in allcars)
{
    Console.WriteLine($"{car.Id} {car.Make} {car.Model}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation UnionBy */

List<Car> cars1 =
[
        new Car(1,"Ford","GT",2005,"WAU3FAFR0BA781507","Mauv",298),
        new Car(2,"Mercury","Mystique",2000,"1FTEW1C89AK439924","Turquoise",217),
        new Car(3,"Volvo","S40",2001,"JTHBK1GGXF2728528","Orange",214),
        new Car(4,"Nissan","Maxima",2010,"TRUXD38J191264584","Fuscia",243),
        new Car(5,"Oldsmobile","Bravada",1994,"WAUDH48H19K669503","Yellow",221),
];
List<Car> cars2 =
[
        new Car(6,"Mercury","Mariner",2005,"5N1AA0NE4EN089552","Puce",282),
        new Car(7,"Geo","Tracker",1995,"3GYFK66N15G463658","Puce",259),
        new Car(8,"Mitsubishi","GTO",1991,"1VWAP7A39EC013320","Aquamarine",274),
        new Car(9,"Volkswagen","Eurovan",1995,"KMHFH4JG7FA285977","Orange",236),
        new Car(10,"GMC","Sierra 2500",2002,"1FAHP2D87DG093452","Yellow",275),
];
List<Car> cars3 =
[
        new Car(6,"Mercury","Mariner",2005,"5N1AA0NE4EN089552","Puce",282),
        new Car(7,"Geo","Tracker",1995,"3GYFK66N15G463658","Puce",259),
        new Car(8,"Mitsubishi","GTO",1991,"1VWAP7A39EC013320","Aquamarine",274),
        new Car(9,"Volkswagen","Eurovan",1995,"KMHFH4JG7FA285977","Orange",236),
        new Car(10,"GMC","Sierra 2500",2002,"1FAHP2D87DG093452","Yellow",275),
];
var allcars = cars1.UnionBy(cars2, c => c.Id).UnionBy(cars3, c => c.Id);
foreach (Car car in allcars)
{
    Console.WriteLine($"{car.Id} {car.Make} {car.Model}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation Zip */

int[] numbers = [1, 2, 3, 4];
string[] words = ["one", "two", "three", "four"];
DateTime[] dates = [DateTime.Now, DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), DateTime.Now.AddDays(3)];
var result = numbers.Zip(words, dates);

foreach (var (First, Second, Third) in result)
{
    Console.WriteLine($"({First} - {Second} - {Third})");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation ToArray */

var cars = CarRepository.GetCars();
var carsToAray = cars.ToArray();
var firstCar = carsToAray[0];
Console.WriteLine($"First Car: {firstCar.Id} - {firstCar.Make} - {firstCar.Model}");
Console.WriteLine($"------------------- All Cars ------------------");
foreach (var car in carsToAray)
{
    Console.WriteLine($"{car.Id} - {car.Make} - {car.Model}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation ToDictionary */

var cars = CarRepository.GetCars();
var carsToDictionary = cars.ToDictionary(c => c.Id, c => $"{c.Make} - {c.Model}");
foreach (var car in carsToDictionary)
{
    Console.WriteLine($"Key: {car.Key} - Value: {car.Value}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation ToHashSet */

var cars = CarRepository.GetCars();
var carsToHashSet = cars.ToHashSet();
foreach (var car in carsToHashSet)
{
    Console.WriteLine($"{car.Id} - {car.Make} - {car.Model}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation ToList */

var cars = CarRepository.GetCars();
var carsToList = cars.ToList();
foreach (var car in carsToList)
{
    Console.WriteLine($"{car.Id} - {car.Make} - {car.Model}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation Contains */

int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
var result = numbers.Contains(25);
Console.WriteLine(result ? "I found it" : "I don't find it");
/*-------------------------------------------------------------------------------------*/
/* Funcation Intersect */

int[] numbers1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int[] numbers2 = [5, 6, 6, 7, 8, 9, 10, 11, 12, 12, 13, 14, 15];
var result = numbers1.Intersect(numbers2);
foreach (var number in result)
{
    Console.Write($"{number} ");
}

List<Car> cars1 =
[
        new Car(1,"Ford","GT",2005,"WAU3FAFR0BA781507","Mauv",298),
        new Car(2,"Mercury","Mystique",2000,"1FTEW1C89AK439924","Turquoise",217),
        new Car(3,"Volvo","S40",2001,"JTHBK1GGXF2728528","Orange",214),
        new Car(4,"Nissan","Maxima",2010,"TRUXD38J191264584","Fuscia",243),
        new Car(5,"Oldsmobile","Bravada",1994,"WAUDH48H19K669503","Yellow",221),
];
List<Car> cars2 =
[
        new Car(4,"Nissan","Maxima",2010,"TRUXD38J191264584","Fuscia",243),
        new Car(5,"Oldsmobile","Bravada",1994,"WAUDH48H19K669503","Yellow",221),
        new Car(6,"Mercury","Mariner",2005,"5N1AA0NE4EN089552","Puce",282),
        new Car(7,"Geo","Tracker",1995,"3GYFK66N15G463658","Puce",259),
        new Car(8,"Mitsubishi","GTO",1991,"1VWAP7A39EC013320","Aquamarine",274),
];
var result = cars1.Intersect(cars2);
foreach (var car in result)
{
    Console.WriteLine($"Make: {car.Make} - Model: {car.Model}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation IntersectBy */

List<Car> cars1 =
[
        new Car(1,"Ford","GT",2005,"WAU3FAFR0BA781507","Mauv",298),
        new Car(2,"Mercury","Mystique",2000,"1FTEW1C89AK439924","Turquoise",217),
        new Car(3,"Volvo","S40",2001,"JTHBK1GGXF2728528","Orange",214),
        new Car(4,"Nissan","Maxima",2010,"TRUXD38J191264584","Fuscia",243),
        new Car(5,"Oldsmobile","Bravada",1994,"WAUDH48H19K669503","Yellow",221),
];
List<Car> cars2 =
[
        new Car(4,"Nissan","Maxima",2010,"TRUXD38J191264584","Fuscia",243),
        new Car(5,"Oldsmobile","Bravada",1994,"WAUDH48H19K669503","Yellow",221),
        new Car(6,"Mercury","Mariner",2005,"5N1AA0NE4EN089552","Puce",282),
        new Car(7,"Geo","Tracker",1995,"3GYFK66N15G463658","Puce",259),
        new Car(8,"Mitsubishi","GTO",1991,"1VWAP7A39EC013320","Aquamarine",274),
];
var result = cars1.IntersectBy(cars2.Select(c => c.VIN), c => c.VIN);
foreach (var car in result)
{
    Console.WriteLine($"Id: {car.Id} - Make: {car.Make} - Model: {car.Model}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation SequenceEqual */

int[] numbers1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int[] numbers2 = [1, 2, 6, 4, 5, 3, 7, 9, 8, 10];
var result = numbers1.SequenceEqual(numbers2);
Console.WriteLine(result ? "Both sequences are equal" : "Sequences are not equal");
List<Car> cars1 =
[
        new Car(1,"Ford","GT",2005,"WAU3FAFR0BA781507","Mauv",298),
        new Car(2,"Mercury","Mystique",2000,"1FTEW1C89AK439924","Turquoise",217),
        new Car(3,"Volvo","S40",2001,"JTHBK1GGXF2728528","Orange",214),
        new Car(4,"Nissan","Maxima",2010,"TRUXD38J191264584","Fuscia",243),
        new Car(5,"Oldsmobile","Bravada",1994,"WAUDH48H19K669503","Yellow",221),
];
List<Car> cars2 =
[
        new Car(1,"Ford","GT",2005,"WAU3FAFR0BA781507","Mauv",298),
        new Car(2,"Mercury","Mystique",2000,"1FTEW1C89AK439924","Turquoise",217),
        new Car(3,"Volvo","S40",2001,"JTHBK1GGXF2728528","Orange",214),
        new Car(4,"Nissan","Maxima",2010,"TRUXD38J191264584","Fuscia",243),
        new Car(5,"Oldsmobile","Bravada",1994,"WAUDH48H19K669503","Yellow",221),
];
var result1 = cars1.SequenceEqual(cars2);
Console.WriteLine(result1 ? "Both sequences are equal" : "Sequences are not equal");
/*-------------------------------------------------------------------------------------*/
/* Funcation Except */

int[] numbers1 =  [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int[] numbers2 = [5, 6, 7, 8, 9, 10, 11, 12, 13];
var result1 = numbers1.Except(numbers2);
foreach (int number in result1)
{
    Console.Write($"{number} ");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation ExceptBy */

List<Car> cars1 =
[
        new Car(1,"Ford","GT",2005,"WAU3FAFR0BA781507","Mauv",298),
        new Car(2,"Mercury","Mystique",2000,"1FTEW1C89AK439924","Turquoise",217),
        new Car(3,"Volvo","S40",2001,"JTHBK1GGXF2728528","Orange",214),
        new Car(4,"Nissan","Maxima",2010,"TRUXD38J191264584","Fuscia",243),
        new Car(5,"Oldsmobile","Bravada",1994,"WAUDH48H19K669503","Yellow",221),
        new Car(6,"Mercury","Mariner",2005,"5N1AA0NE4EN089552","Puce",282),
        new Car(7,"Geo","Tracker",1995,"3GYFK66N15G463658","Puce",259),
];
List<Car> cars2 =
[
        new Car(6,"Mercury","Mariner",2005,"5N1AA0NE4EN089552","Puce",282),
        new Car(7,"Geo","Tracker",1995,"3GYFK66N15G463658","Puce",259),
        new Car(8,"Mitsubishi","GTO",1991,"1VWAP7A39EC013320","Aquamarine",274),
        new Car(9,"Volkswagen","Eurovan",1995,"KMHFH4JG7FA285977","Orange",236),
        new Car(10,"GMC","Sierra 2500",2002,"1FAHP2D87DG093452","Yellow",275),
];
var result = cars1.ExceptBy(cars2.Select(c => c.VIN), c => c.VIN);
foreach (Car car in result)
{
    Console.WriteLine($"{car.Id} {car.Make} {car.Model}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation Range */

var range = Enumerable.Range(1,10);
foreach (var number in range)
{
    Console.WriteLine($"Number: {number}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation Reverse */
var cars = CarRepository.GetCars();

int [] numbers= [1,2,3,4,5,6,7,8,9,10];
var result = numbers.Reverse();
foreach (var number in result)
{
    Console.Write($"{number} ");
}
var result = cars.Reverse();
foreach (var car in result)
{
    Console.WriteLine($"{car.Id} {car.Make} {car.Model}");
}
/*-------------------------------------------------------------------------------------*/
/* Funcation Shuffle */

var cars = CarRepository.GetCars();
var result = cars.Shuffle();
foreach (var car in result)
{
    Console.WriteLine($"{car.Make} {car.Model} ({car.Year})");
}
/*-------------------------------------------------------------------------------------*/

