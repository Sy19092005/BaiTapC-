using System;

class Bai17
{
    static void Main()
    {
        // Thiết lập mã hóa UTF-8 để hiển thị tiếng Việt trong console
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Khai báo biến xâu kí tự st
        string st;

        while (true)
        {
            Console.Write("Nhập chuỗi kí tự: ");
            st = Console.ReadLine();

            // Nếu st là "#", phát tiếng beep
            if (st == "#")
            {
                Console.Beep();
                continue; // Tiếp tục yêu cầu nhập lại
            }

            // Gọi hàm để in ra số từ của st
            int soTu = DemSoTu(st);
            Console.WriteLine($"Số từ trong chuỗi '{st}' là: {soTu}");
        }
    }

    // Hàm static đếm số các từ của 1 xâu kí tự
    static int DemSoTu(string st)
    {
        if (string.IsNullOrWhiteSpace(st))
        {
            return 0;
        }

        // Tách chuỗi theo các ký tự không phải chữ cái hoặc số
        string[] tu = st.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '-', '_', '/', '\\', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return tu.Length;
    }
}

