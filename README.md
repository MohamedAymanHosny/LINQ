# LINQ Functions Showcase

This repository demonstrates the usage of various LINQ functions in C#. Each code snippet highlights how to perform common data manipulation and querying operations using LINQ.

## 🚗 Data Source

Most examples make use of a `CarRepository.GetCars()` method which returns a collection of `Car` objects. The examples show how to transform, filter, aggregate, and group data using LINQ.

## 📌 Covered LINQ Functions

The following LINQ functions are demonstrated:

* **Element operations:** `First`, `FirstOrDefault`, `Last`, `LastOrDefault`, `Single`, `SingleOrDefault`, `ElementAt`, `ElementAtOrDefault`, `DefaultIfEmpty`
* **Quantifier operations:** `Any`, `All`, `Contains`
* **Set operations:** `Distinct`, `DistinctBy`, `Union`, `UnionBy`, `Intersect`, `IntersectBy`, `Except`, `ExceptBy`
* **Ordering operations:** `OrderBy`, `OrderByDescending`, `Reverse`, `Shuffle`
* **Projection and aggregation:** `Count`, `Max`, `Min`, `Average`, `AggregateBy`
* **Partitioning:** `Chunk`, `Take`, `TakeLast`, `TakeWhile`, `Skip`, `SkipLast`, `SkipWhile`
* **Transformation and conversion:** `ToArray`, `ToDictionary`, `ToHashSet`, `ToList`, `Zip`
* **Miscellaneous:** `Range`, `Index`

## ✅ Example Format

Each section of the demo includes:

1. The function name
2. The code snippet
3. Console output (where relevant)

## 🧾 Usage

Clone the repository and run the application to view examples in action. Each code snippet prints its result to the console so you can observe the behavior live.

## 📚 Requirements

* .NET 6 or later
* Namespace: `System.Linq`

## 🚀 Purpose

This collection serves as a quick reference for developers who want to:

* Learn LINQ through practical examples
* Understand differences between similar operators (e.g., `First` vs `FirstOrDefault`)
* Improve proficiency in C# collection manipulation

## 📄 License

MIT License

---

Feel free to extend this guide with more LINQ methods or real-world usage examples!
