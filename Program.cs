using System;

namespace OperatorOverloadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects with different values
            Employee employee1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            Employee employee2 = new Employee
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Compare employees using overloaded == operator
            Console.WriteLine("Comparing employees with different IDs:");
            Console.WriteLine($"employee1 == employee2: {employee1 == employee2}");
            Console.WriteLine($"employee1 != employee2: {employee1 != employee2}");

            // Create another employee with the same ID as employee1
            Employee employee3 = new Employee
            {
                Id = 1,
                FirstName = "Alice",
                LastName = "Johnson"
            };

            // Compare employees with same ID but different names
            Console.WriteLine("\nComparing employees with same ID:");
            Console.WriteLine($"employee1 == employee3: {employee1 == employee3}");
            Console.WriteLine($"employee1 != employee3: {employee1 != employee3}");

            // Wait for user input before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}