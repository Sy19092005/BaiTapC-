using System;

public abstract class Shape
{
    private int soDinh;

    public int so_dinh
    {
        get { return soDinh; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Số đỉnh phải lớn hơn 0.");
            }
            soDinh = value;
        }
    }
}

public class tam_giac : Shape
{
    public tam_giac()
    {
        so_dinh = 3;
    }

    public new int so_dinh
    {
        get { return base.so_dinh; }
        private set
        {
            if (value != 3)
            {
                throw new ArgumentException("Số đỉnh của tam giác phải là 3.");
            }
            base.so_dinh = value;
        }
    }
}

class bai35
{
    static void Main(string[] args)
    {
        try
        {
            // Khởi tạo đối tượng tam_giac
            tam_giac tg = new tam_giac();
            Console.WriteLine($"Số đỉnh của tam giác: {tg.so_dinh}");

            // Thử khởi tạo một đối tượng Shape với số đỉnh không hợp lệ
            Shape shape = new tam_giac();
            shape.so_dinh = 4; // Điều này sẽ ném ra ArgumentException
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
