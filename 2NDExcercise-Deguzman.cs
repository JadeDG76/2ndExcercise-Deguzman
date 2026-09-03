using System;

class Program
{
    static void Main()
    {
        // 1. Student Information
        Console.WriteLine("===== 1. STUDENT INFORMATION =====");

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter course: ");
        string course = Console.ReadLine();

        Console.Write("Enter year level: ");
        string yearLevel = Console.ReadLine();

        Console.Write("Enter section: ");
        string section = Console.ReadLine();

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Course: " + course);
        Console.WriteLine("Year Level: " + yearLevel);
        Console.WriteLine("Section: " + section);


        // 2. Basic Calculator
        Console.WriteLine("\n===== 2. BASIC CALCULATOR =====");

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Addition: " + (num1 + num2));
        Console.WriteLine("Subtraction: " + (num1 - num2));
        Console.WriteLine("Multiplication: " + (num1 * num2));
        Console.WriteLine("Division: " + (num1 / num2));


        // 3. Area of a Rectangle
        Console.WriteLine("\n===== 3. AREA OF A RECTANGLE =====");

        Console.Write("Enter length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = length * width;

        Console.WriteLine("Area: " + area);


        // 4. Student Grade
        Console.WriteLine("\n===== 4. STUDENT GRADE =====");

        Console.Write("Enter Prelim grade: ");
        double prelim = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Midterm grade: ");
        double midterm = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Final grade: ");
        double finalGrade = Convert.ToDouble(Console.ReadLine());

        double average = (prelim + midterm + finalGrade) / 3;

        Console.WriteLine("Average: " + average);


        // 5. Boolean Input
        Console.WriteLine("\n===== 5. BOOLEAN INPUT =====");

        Console.Write("Are you a student? (true/false): ");
        bool isStudent = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("You are a student: " + isStudent);


        // 6. Age Verification
        Console.WriteLine("\n===== 6. AGE VERIFICATION =====");

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        bool isAdult = age >= 18;

        Console.WriteLine("18 or older: " + isAdult);


        // 7. Full Name
        Console.WriteLine("\n===== 7. FULL NAME =====");

        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        string fullName = firstName + " " + lastName;

        Console.WriteLine("Full Name: " + fullName);


        // 8. Shopping Calculator
        Console.WriteLine("\n===== 8. SHOPPING CALCULATOR =====");

        Console.Write("Enter product name: ");
        string product = Console.ReadLine();

        Console.Write("Enter price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        double total = price * quantity;

        Console.WriteLine("Product: " + product);
        Console.WriteLine("Total: " + total);


        // 9. Salary Calculator
        Console.WriteLine("\n===== 9. SALARY CALCULATOR =====");

        Console.Write("Enter employee name: ");
        string employeeName = Console.ReadLine();

        Console.Write("Enter hours worked: ");
        double hours = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter hourly rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        double salary = hours * rate;

        Console.WriteLine("Employee: " + employeeName);
        Console.WriteLine("Salary: " + salary);


        // 10. Mini Student Information System
        Console.WriteLine("\n===== 10. MINI STUDENT INFORMATION SYSTEM =====");

        Console.Write("Enter name: ");
        string studentName = Console.ReadLine();

        Console.Write("Enter course: ");
        string studentCourse = Console.ReadLine();

        Console.Write("Enter age: ");
        int studentAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter year level: ");
        int studentYear = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Prelim grade: ");
        double studentPrelim = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Midterm grade: ");
        double studentMidterm = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Final grade: ");
        double studentFinal = Convert.ToDouble(Console.ReadLine());

        double studentAverage =
            (studentPrelim + studentMidterm + studentFinal) / 3;

        bool studentIsAdult = studentAge >= 18;

        Console.WriteLine("\n--- Student Information ---");
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Course: " + studentCourse);
        Console.WriteLine("Age: " + studentAge);
        Console.WriteLine("Year Level: " + studentYear);
        Console.WriteLine("Average Grade: " + studentAverage);
        Console.WriteLine("18 or older: " + studentIsAdult);
    }
}
