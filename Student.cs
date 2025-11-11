using System;

class Student
{
    public string Name;
    public int Age;
    public double Marks;

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Marks: {Marks}");
    }

    static void Main()
    {
        Console.WriteLine("=== Student Details ===");
        Student s1 = new Student();

        Console.Write("Enter student name: ");
        s1.Name = Console.ReadLine();

        Console.Write("Enter age: ");
        s1.Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks: ");
        s1.Marks = Convert.ToDouble(Console.ReadLine());

        s1.DisplayDetails();
    }
}
