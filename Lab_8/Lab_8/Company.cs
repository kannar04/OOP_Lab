using System.Runtime.Serialization;

[Serializable]
public class Company : ISerializable
{
    public string name { get; set; }
    public string address { get; set; }
    public List<Employee> employees { get; set; }

    public Company() { }

    public Company(string name, string address)
    {
        this.name = name;
        this.address = address;
        employees = new List<Employee>();
    }

    // Phương thức in bảng lương cho tất cả nhân viên trong công ty
    public void PrintSalaryBoard(double baseSalary)
    {
        Console.WriteLine($"\nBẢNG LƯƠNG CÔNG TY {name.ToUpper()}");
        Console.WriteLine(new string('-', 95));
        Console.WriteLine($"| {"STT",-3} | {"Mã NV",-6} | {"Họ và Tên",-20} | {"Ngày vào",-12} | {"Hệ số",-6} | {"Lương (VND)",-15} |");
        Console.WriteLine(new string('-', 95));

        double total = 0;
        // Duyệt qua danh sách nhân viên và in thông tin cùng lương
        for (int i = 0; i < employees.Count; i++)
        {
            var emp = employees[i]; // Lấy nhân viên thứ i
            double salary = emp.CalculateSalary(baseSalary); // Tính lương dựa trên hệ số và thời gian làm việc
            total += salary; // Cộng dồn vào tổng chi

            double currentCoef = salary / baseSalary; // Tính hệ số lương hiện tại để hiển thị
            Console.WriteLine($"| {i + 1,-3} | {emp.id,-6} | {emp.name,-20} | {emp.participation_date.ToString("dd/MM/yyyy"),-12} | {currentCoef,-6:F1} | {salary,15:N0} |");
        }
        Console.WriteLine(new string('-', 95));
        Console.WriteLine($"=> TỔNG CHI: {total:N0} VND\n");
    }

    // Phương thức khởi tạo từ dữ liệu đã serialize
    public Company(SerializationInfo info, StreamingContext context)
    {
        name = info.GetString("name");
        address = info.GetString("address");
        employees = (List<Employee>)info.GetValue("employees", typeof(List<Employee>));
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("name", name);
        info.AddValue("address", address);
        info.AddValue("employees", employees);
    }
}