using System;
using System.Collections.Generic;
using System.Linq;

// Abstract class Person
public abstract class Person
{
    private string _name;
    private string _id;

    // Properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Id
    {
        get { return _id; }
        set { _id = value; }
    }

    // Constructor
    public Person(string name, string id)
    {
        Name = name;
        Id = id;
    }

    // Abstract method
    public abstract float Kpi();
}

// Interface Kpi
public interface Kpi
{
    float Kpi();
}

// Class Student inheriting from Person and implementing Kpi interface
public class Student : Person, Kpi
{
    private string _department;

    // Department property with custom setter
    public string Department
    {
        get { return _department; }
        set
        {
            if (value == "ICT" || value == "ECO")
                _department = value;
            else
                throw new ArgumentException("Invalid department. Allowed departments: ICT, ECO");
        }
    }

    // Constructor
    public Student(string name, string id, string department) : base(name, id)
    {
        // Check ID format (8 characters, all digits)
        if (id.Length != 8 || !id.All(char.IsDigit))
        {
            throw new ArgumentException("Invalid student ID format. Must be 8 digits.");
        }

        Department = department;
    }

    // Implementing Kpi interface
    public override float Kpi()
    {
        // Assuming GPA is used as KPI
        // Calculate GPA logic here
        return 3.5f; // Example value, replace with actual GPA calculation
    }
}

class Bai36
{
    static void Main()
    {
        // Part d: Main function setup
        Person obs = null;

        try
        {
            // Part e: Allocate obs as Student
            obs = new Student("Nguyễn Tiến Dũng", "12345678", "ICT");
            Console.WriteLine($"KPI of {obs.Name}: {((Student)obs).Kpi()}");

            // Part g: Allocate obs with invalid id or department
            // Uncomment the following line to see the effect of invalid id or department
            //obs = new Student("Invalid Student", "1234", "InvalidDept");

            // Part h: Declare list1, list2
            List<Person> list1 = new List<Person>();
            List<Person> list2 = new List<Person>();

            // Part i: Input list1, list2 from keyboard
            Console.WriteLine("Enter students for list1 (table 1, class 23IT5, 25/06/2024). Enter # to end:");
            ReadStudents(list1);

            Console.WriteLine("Enter students for list2 (table 2, class 23IT6, 25/06/2024). Enter # to end:");
            ReadStudents(list2);

            // Part j: Display list1, list2
            Console.WriteLine("\nStudents in list1:");
            DisplayStudents(list1);

            Console.WriteLine("\nStudents in list2:");
            DisplayStudents(list2);

            // Part k: Declare and display list_list
            List<List<Person>> list_list = new List<List<Person>>();
            list_list.Add(list1);
            list_list.Add(list2);

            Console.WriteLine("\nContents of list_list:");
            DisplayListOfLists(list_list);

            // Part l: Create Dictionary dic11 for list1
            Dictionary<string, Student> dic11 = new Dictionary<string, Student>();
            foreach (var student in list1.OfType<Student>())
            {
                dic11.Add(student.Id, student);
            }

            // Find students named "Nam" in dic11
            var studentsNamedNam = dic11.Values.Where(s => s.Name.Contains("Nam")).ToList();
            Console.WriteLine("\nStudents in dic11 named 'Nam':");
            DisplayStudents(studentsNamedNam);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Helper method to read students from keyboard input
    static void ReadStudents(List<Person> list)
    {
        while (true)
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine().Trim();

            if (name == "#")
                break;

            Console.Write("Enter student ID (8 digits): ");
            string id = Console.ReadLine().Trim();

            Console.Write("Enter student department (ICT/ECO): ");
            string department = Console.ReadLine().Trim();

            try
            {
                list.Add(new Student(name, id, department));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}. Please try again.");
            }
        }
    }

    // Helper method to display students in a list
    static void DisplayStudents(List<Person> list)
    {
        foreach (var person in list)
        {
            Console.WriteLine($"{person.Name}, ID: {person.Id}, Department: {(person as Student)?.Department}");
        }
    }

    // Helper method to display a list of lists of persons
    static void DisplayListOfLists(List<List<Person>> list_list)
    {
        for (int i = 0; i < list_list.Count; i++)
        {
            Console.WriteLine($"List {i + 1}:");
            DisplayStudents(list_list[i]);
            Console.WriteLine();
        }
    }
}
