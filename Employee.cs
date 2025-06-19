using System;

namespace OperatorOverloadingDemo
{
    // This class represents an Employee with basic properties and overloaded equality operators
    public class Employee
    {
        // Properties to store employee information
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the equality operator (==) to compare employees based on their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Handle cases where either object might be null
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare employees based on their Id property
            return emp1.Id == emp2.Id;
        }

        // Overload the inequality operator (!=) as operators must be overloaded in pairs
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Use the already defined == operator and negate its result
            return !(emp1 == emp2);
        }

        // Override Equals method to maintain consistency with == operator
        public override bool Equals(object obj)
        {
            if (obj is Employee employee)
                return this == employee;
            return false;
        }

        // Override GetHashCode to maintain consistency with Equals
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}