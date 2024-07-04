using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class SinhVien
{
    public string MSSV { get; set; }
    public string HoTen { get; set; }
    public double DiemToan { get; set; }
    public double DiemLy { get; set; }
    public double DiemHoa { get; set; }

    public double DiemTrungBinh
    {
        get { return (DiemToan + DiemLy + DiemHoa) / 3; }
    }
}

class bai31
{
    static void Main(string[] args)
    {
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        // a. Nhập số lượng sinh viên
        int soLuongSinhVien = NhapSoLuongSinhVien();

        // b. Nhập thông tin sinh viên
        NhapThongTinSinhVien(danhSachSinhVien, soLuongSinhVien);

        // c. Tính điểm trung bình
        TinhDiemTrungBinh(danhSachSinhVien);

        // d. Hiển thị thông tin sinh viên
        HienThiThongTinSinhVien(danhSachSinhVien);

        // e. Hiển thị sinh viên đầu tiên có điểm trung bình > 9.5
        HienThiSinhVienDiemCao(danhSachSinhVien);

        // g. Đếm số sinh viên có điểm trung bình lớn hơn 5.0
        DemSinhVienDiemLonHonNam(danhSachSinhVien);

        // h. Sắp xếp danh sách sinh viên theo thứ tự điểm trung bình từ thấp đến cao
        SapXepTheoDiemTrungBinh(danhSachSinhVien);
        Console.WriteLine("Danh sách sinh viên sau khi sắp xếp theo điểm trung bình:");
        HienThiThongTinSinhVien(danhSachSinhVien);

        // i. Sắp xếp sinh viên theo thứ tự alphabet của Họ tên sinh viên
        SapXepTheoHoTen(danhSachSinhVien);
        Console.WriteLine("Danh sách sinh viên sau khi sắp xếp theo họ tên:");
        HienThiThongTinSinhVien(danhSachSinhVien);

        // k. Ghi thông tin sinh viên vào file
        Console.Write("Nhập tên file để ghi thông tin sinh viên: ");
        string tenFile = Console.ReadLine();
        GhiThongTinSinhVienVaoFile(danhSachSinhVien, tenFile);

        // l. Đọc thông tin sinh viên từ file
        Console.Write("Nhập tên file để đọc thông tin sinh viên: ");
        string tenFileDoc = Console.ReadLine();
        List<SinhVien> danhSachSinhVienTuFile = DocThongTinSinhVienTuFile(tenFileDoc);
        Console.WriteLine("Danh sách sinh viên đọc từ file:");
        HienThiThongTinSinhVien(danhSachSinhVienTuFile);
    }

    static int NhapSoLuongSinhVien()
    {
        int soLuong = 0;
        while (true)
        {
            try
            {
                Console.Write("Nhập số lượng sinh viên: ");
                soLuong = int.Parse(Console.ReadLine());
                if (soLuong > 0)
                    break;
                else
                    Console.WriteLine("Số lượng sinh viên phải lớn hơn 0.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
            }
        }
        return soLuong;
    }

    static void NhapThongTinSinhVien(List<SinhVien> danhSachSinhVien, int soLuongSinhVien)
    {
        for (int i = 0; i < soLuongSinhVien; i++)
        {
            SinhVien sv = new SinhVien();
            Console.WriteLine($"Nhập thông tin cho sinh viên thứ {i + 1}:");
            Console.Write("Mã số sinh viên: ");
            sv.MSSV = Console.ReadLine();
            Console.Write("Họ tên: ");
            sv.HoTen = Console.ReadLine();
            sv.DiemToan = NhapDiem("Toán");
            sv.DiemLy = NhapDiem("Lý");
            sv.DiemHoa = NhapDiem("Hóa");
            danhSachSinhVien.Add(sv);
        }
    }

    static double NhapDiem(string monHoc)
    {
        double diem = 0;
        while (true)
        {
            try
            {
                Console.Write($"Điểm {monHoc}: ");
                diem = double.Parse(Console.ReadLine());
                if (diem >= 0 && diem <= 10)
                    break;
                else
                    Console.WriteLine("Điểm phải nằm trong khoảng từ 0 đến 10.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Vui lòng nhập một số thực hợp lệ.");
            }
        }
        return diem;
    }

    static void TinhDiemTrungBinh(List<SinhVien> danhSachSinhVien)
    {
        foreach (var sv in danhSachSinhVien)
        {
            // Điểm trung bình đã được tính trong property DiemTrungBinh của class SinhVien
        }
    }

    static void HienThiThongTinSinhVien(List<SinhVien> danhSachSinhVien)
    {
        foreach (var sv in danhSachSinhVien)
        {
            Console.WriteLine($"MSSV: {sv.MSSV}, Họ tên: {sv.HoTen}, Điểm trung bình: {sv.DiemTrungBinh:F2}");
        }
    }

    static void HienThiSinhVienDiemCao(List<SinhVien> danhSachSinhVien)
    {
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.DiemTrungBinh > 9.5)
            {
                Console.WriteLine($"Sinh viên đầu tiên có điểm trung bình > 9.5: MSSV: {sv.MSSV}, Họ tên: {sv.HoTen}, Điểm trung bình: {sv.DiemTrungBinh:F2}");
                break;
            }
        }
    }

    static void DemSinhVienDiemLonHonNam(List<SinhVien> danhSachSinhVien)
    {
        int count = 0;
        foreach (var sv in danhSachSinhVien)
        {
            if (sv.DiemTrungBinh > 5.0)
            {
                count++;
                continue;
            }
        }
        Console.WriteLine($"Số lượng sinh viên có điểm trung bình lớn hơn 5.0: {count}");
    }

    static void SapXepTheoDiemTrungBinh(List<SinhVien> danhSachSinhVien)
    {
        danhSachSinhVien.Sort((sv1, sv2) => sv1.DiemTrungBinh.CompareTo(sv2.DiemTrungBinh));
    }

    static void SapXepTheoHoTen(List<SinhVien> danhSachSinhVien)
    {
        danhSachSinhVien.Sort((sv1, sv2) => string.Compare(sv1.HoTen, sv2.HoTen, StringComparison.CurrentCulture));
    }

    static void GhiThongTinSinhVienVaoFile(List<SinhVien> danhSachSinhVien, string tenFile)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(tenFile))
            {
                foreach (var sv in danhSachSinhVien)
                {
                    writer.WriteLine($"{sv.MSSV},{sv.HoTen},{sv.DiemToan},{sv.DiemLy},{sv.DiemHoa},{sv.DiemTrungBinh}");
                }
            }
            Console.WriteLine("Ghi thông tin sinh viên vào file thành công.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Có lỗi xảy ra khi ghi file: {e.Message}");
        }
    }

    static List<SinhVien> DocThongTinSinhVienTuFile(string tenFile)
    {
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        try
        {
            using (StreamReader reader = new StreamReader(tenFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 6)
                    {
                        SinhVien sv = new SinhVien
                        {
                            MSSV = parts[0],
                            HoTen = parts[1],
                            DiemToan = double.Parse(parts[2]),
                            DiemLy = double.Parse(parts[3]),
                            DiemHoa = double.Parse(parts[4])
                        };
                        danhSachSinhVien.Add(sv);
                    }
                }
            }
            Console.WriteLine("Đọc thông tin sinh viên từ file thành công.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Có lỗi xảy ra khi đọc file: {e.Message}");
        }
        return danhSachSinhVien;
    }
}

