using System.Text;

public struct BangGhiHangHoa
{
    public string maHang;
    public string tenHang;
    public int soLuong;
    public double donGia;
}

public class Program
{
    static void NhapThongTinMatHang(out BangGhiHangHoa hangHoa)
    {
        Console.Write("Nhập mã hàng: ");
        hangHoa.maHang = Console.ReadLine();
        Console.Write("Nhập tên hàng: ");
        hangHoa.tenHang = Console.ReadLine();
        Console.Write("Nhập số lượng: ");
        hangHoa.soLuong = int.Parse(Console.ReadLine());
        Console.Write("Nhập đơn giá: ");
        hangHoa.donGia = double.Parse(Console.ReadLine());
    }

    static void InThongTinMatHang(BangGhiHangHoa hangHoa)
    {
        Console.WriteLine(">> Thông tin mặt hàng: (Mã hàng: {0}, Tên hàng: {1}, Số lượng: {2}, Đơn giá: {3})",
        hangHoa.maHang, hangHoa.tenHang, hangHoa.soLuong, hangHoa.donGia);
    }
    static void BoSungThongTinVaoDanhSach(List<BangGhiHangHoa> danhSachHangHoa)
    {
        BangGhiHangHoa hangHoaMoi;
        NhapThongTinMatHang(out hangHoaMoi);
        danhSachHangHoa.Add(hangHoaMoi);
    }

    static void InDanhSachHangHoa(List<BangGhiHangHoa> danhSachHangHoa)
    {
        Console.WriteLine("========== Danh sách hàng hóa ==========");
        Console.WriteLine("| {0, -10} | {1, -30} | {2, 10} | {3, 15} |", "Mã hàng", "Tên hàng", "Số lượng", "Đơn giá");
        foreach (var hangHoa in danhSachHangHoa)
        {
            Console.WriteLine("| {0, -10} | {1, -30} | {2, 10} | {3, 15} |", hangHoa.maHang, hangHoa.tenHang, hangHoa.soLuong, hangHoa.donGia);
        }
    }

    static void TimMatHangTheoTen(List<BangGhiHangHoa> danhSachHangHoa, string tenHangCanTim)
    {
        foreach (var hangHoa in danhSachHangHoa)
        {
            if (hangHoa.tenHang.Equals(tenHangCanTim))
            {
                InThongTinMatHang(hangHoa);
                return;
            }
        }
        Console.WriteLine("Không tìm thấy mặt hàng với tên: " + tenHangCanTim);
    }

    static void InDanhSachMatHangTheoKhoangGia(List<BangGhiHangHoa> danhSachHangHoa)
    {
        Console.WriteLine("== Nhập khoảng giá để lọc mặt hàng ==");
        Console.Write("Nhập giá min: ");
        double giaMin = double.Parse(Console.ReadLine());
        Console.Write("Nhập giá max: ");
        double giaMax = double.Parse(Console.ReadLine());

        Console.WriteLine("== Danh sách mặt hàng trong khoảng giá từ {0} đến {1} ==", giaMin, giaMax);
        foreach (var hangHoa in danhSachHangHoa)
        {
            if (hangHoa.donGia >= giaMin && hangHoa.donGia <= giaMax)
            {
                InThongTinMatHang(hangHoa);
                // InDanhSachHangHoa(new List<BangGhiHangHoa> { hangHoa });
            }
        }
    }

    static void ThemMatHangVaoGioHang(List<BangGhiHangHoa> danhSachHangHoa, List<BangGhiHangHoa> gioHang)
    {
        while (true)
        {
            Console.WriteLine("== Danh sách hàng hóa hiện có trong kho ==");
            InDanhSachHangHoa(danhSachHangHoa);

            Console.Write("Nhập mã hàng cần thêm vào giỏ hàng: ");
            string maHangCanThem = Console.ReadLine();

            Console.Write("Nhập số lượng cần thêm vào giỏ hàng: ");
            int soLuongCanThem = int.Parse(Console.ReadLine());
            
            bool timThay = false;

            for (int i = 0; i < danhSachHangHoa.Count; i++)
            {
                if (danhSachHangHoa[i].maHang == maHangCanThem)
                {
                    timThay = true;

                    if (soLuongCanThem <= danhSachHangHoa[i].soLuong)
                    {
                        gioHang.Add(new BangGhiHangHoa
                        {
                            maHang = danhSachHangHoa[i].maHang,
                            tenHang = danhSachHangHoa[i].tenHang,
                            soLuong = soLuongCanThem,
                            donGia = danhSachHangHoa[i].donGia
                        } );

                        BangGhiHangHoa hangKho = danhSachHangHoa[i];
                        hangKho.soLuong -= soLuongCanThem;
                        danhSachHangHoa[i] = hangKho;

                        Console.WriteLine("Đã thêm mặt hàng vào giỏ hàng.");

                        Console.Write("Bạn có muốn mua thêm không? (y/n): ");
                        string luaChon = Console.ReadLine().ToLower();

                        if (luaChon != "y")
                            return;   
                    }
                    else
                    {
                        Console.WriteLine("Số lượng tồn kho không đủ. Vui lòng nhập lại.");
                    }
                    break;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("Không tìm thấy mặt hàng với mã: " + maHangCanThem);
            }
        }
    }
    static void ThanhToanChoGioHang(List<BangGhiHangHoa> gioHang)
    {
        InDanhSachHangHoa(gioHang);

        double tongTien = 0;
        foreach (var hangHoa in gioHang)
        {
            tongTien += hangHoa.soLuong * hangHoa.donGia;
        }
        Console.WriteLine("Tổng tiền thanh toán cho giỏ hàng: " + tongTien);
    }
    static void Main()
    {
        Console.Clear();
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        // BangGhiHangHoa hanghoa;
        // NhapThongTinMatHang(out hanghoa);
        // InThongTinMatHang(hanghoa);

        List<BangGhiHangHoa> danhSachHangHoa = new List<BangGhiHangHoa>();

        BoSungThongTinVaoDanhSach(danhSachHangHoa);
        BoSungThongTinVaoDanhSach(danhSachHangHoa);
        BoSungThongTinVaoDanhSach(danhSachHangHoa);
        BoSungThongTinVaoDanhSach(danhSachHangHoa);
        BoSungThongTinVaoDanhSach(danhSachHangHoa);

        InDanhSachHangHoa(danhSachHangHoa);

        Console.WriteLine("Nhập tên hàng hóa cần tìm: ");
        string tenCanTim = Console.ReadLine();
        TimMatHangTheoTen(danhSachHangHoa, tenCanTim);

        InDanhSachMatHangTheoKhoangGia(danhSachHangHoa);

        List<BangGhiHangHoa> gioHang = new List<BangGhiHangHoa>();
        ThemMatHangVaoGioHang(danhSachHangHoa, gioHang);

        Console.WriteLine("========== Hóa đơn thanh toán ==========");
        ThanhToanChoGioHang(gioHang);
    }
}