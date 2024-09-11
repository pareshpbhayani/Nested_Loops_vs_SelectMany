// See https://aka.ms/new-console-template for more information
using Nested_Loops_vs_SelectMany;

var departments = new List<Department>
{
    new Department { Employees = new List<string> { "Alice", "Bob" } },
    new Department { Employees = new List<string> { "Charlie", "David" } }
};

Console.WriteLine("Using Nested Loops");

var allEmployees = new List<string>();

foreach (var department in departments)
{
    foreach (var employee in department.Employees)
    {
        allEmployees.Add(employee);
    }
}

foreach (var employee in allEmployees)
{
    Console.WriteLine(employee);
}

Console.WriteLine();
Console.WriteLine("Using SelectMany");

// Using SelectMany to flatten the list
var allEmployees2 = departments.SelectMany(d => d.Employees).ToList();

foreach (var employee in allEmployees2)
{
    Console.WriteLine(employee);
}
