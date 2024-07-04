public abstract class Person
{
    public string Name { get; set; }
}
public interface KPI
{
    void kpi();
}
public class Student : Person, KPI
{
    public string Major { get; set; }

    public Student(string name, string major)
    {
        Name = name;
        Major = major;
    }

    public void kpi()
    {
        // Giả sử phương thức kpi() đơn giản chỉ in ra một thông báo
        Console.WriteLine($"{Name} with major {Major} has a KPI calculation.");
    }
}

class bai32
{
    static void Main(string[] args)
    {
        Person obs = new Student("Nguyễn Văn Nam", "ICT");

        if (obs is Student student)
        {
            student.kpi();
        }
        else
        {
            Console.WriteLine("obs is not a Student.");
        }
    }
}
