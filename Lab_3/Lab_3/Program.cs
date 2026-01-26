using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        List<Vecto2d> danhSachVecto = new List<Vecto2d>();

        Vecto2d v1 = new Vecto2d(3, 4);       // Có tham số
        Vecto2d v2 = new Vecto2d();           // Không tham số (0,0) 
        v2.x = 1; v2.y = 2;
        Vecto2d v3 = new Vecto2d(v1);         // Sao chép từ v1 (3,4)
        Vecto2d vVuongGoc = new Vecto2d(-4, 3); // Vector vuông góc với v1
        Vecto2d vNguocHuong = new Vecto2d(-3, -4); // Ngược hướng v1

        danhSachVecto.Add(v1);
        danhSachVecto.Add(v2);
        danhSachVecto.Add(v3);
        danhSachVecto.Add(vVuongGoc);

        Console.WriteLine("========== DANH SÁCH CÁC VEC-TO ===========");
        foreach (var vecto in danhSachVecto)
        {
            Console.WriteLine(vecto);
        }


        Console.WriteLine("========== CỘNG HAI VECO-TO ==========");
        Vecto2d vTong = v1.Cong(v2, v3);
        Console.WriteLine($"{v1} + {v2} + {v3} = {vTong}");


        Console.WriteLine("====== NHÂN HAI VEC-TO HOẶC NHÂN VEC-TO VỚI MỘT SỐ BẤT KÌ =====");
        Vecto2d vNhanSo = v1.Nhan(2.0f);
        float tichVoHuong = v1.Nhan(v2); 
        Console.WriteLine($"V1 * 2 = {vNhanSo}");
        Console.WriteLine($"V1 * V2 (Tích vô hướng) = {tichVoHuong}");


        Console.WriteLine("=== CÁC PHÉP KIỂM TRA (VỚI V1 (3,4)) ===");
        Console.WriteLine($"Độ dài (Modun) V1: {v1.Modun()}");
            
        Console.WriteLine($"V1 vs V3 (Copy của V1):");
        Console.WriteLine($"- Cùng phương? {v1.CungPhuong(v3)}");
        Console.WriteLine($"- Cùng hướng? {v1.CungHuong(v3)}");

        Console.WriteLine($"V1 vs Vecto_VuongGoc (-4,3):");
        Console.WriteLine($"- Vuông góc? {v1.VuongGoc(vVuongGoc)}");

        Console.WriteLine($"V1 vs Vecto_NguocHuong (-3,-4):");
        Console.WriteLine($"- Cùng phương? {v1.CungPhuong(vNguocHuong)}");
        Console.WriteLine($"- Cùng hướng? {v1.CungHuong(vNguocHuong)}");


        Console.WriteLine("=== TỊNH TIẾN ===");
        Console.WriteLine($"V2 trước khi tịnh tiến: {v2}");
        v2.TinhTien(5, 5); // Tăng x thêm 5, y thêm 5
        Console.WriteLine($"V2 sau khi tịnh tiến (5,5): {v2}");

    }
}