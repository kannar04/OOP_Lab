// 1/Human gồm các thuộc tính name, age 
// 2/Employee kế thừa Human gồm các thuộc tínhL ide, oef-salary, participation_date, education level
// 3/Company gồm các thuộc tính name, address, List<Employee> employees

// Yêu cầu:
// 1. Xây dựng 3 lớp Human, Employee và Company nói trên. Bổ sung các lớp cần thiết getter,setter constructor, ToString

// 2. Bổ sung phương thức tính lương cho lớp Employee, biết rằng coef_salary là hệ số lương khởi điểm khi vào công ty và 
// cứ 3 năm kể từ thời điểm vào công ty thì được tăng lương 1 lần với phần tăng hệ số là +0.3 
// và lương = hệ số lương x lương cơ bản

// 3. Khởi tạo 1 đối tượng Company với tối thiểu là 5 Employee sau đó bổ sung vào lớp Company phương thức 
// in bảng lương cho tất cả các nhân viên trong công ty, trong đó có tính tổng lương đã chi trong tháng 
// (dạng bảng gồm các cột, stt, họ tên, ... , lương sau đó -> Tổng chi)

// 4. Triển khai kĩ thuật serialize và deserialize để cho phép lưu ra file cũng như đọc từ file dữ liệu của Company.

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
#pragma warning disable SYSLIB0011

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        string file = "Company_Data.bin";
        double baseSal = 1500000;

        // Khởi tạo công ty FPT và 5 nhân viên
        Company company = new Company("Company", "Khu 1, Q1");
        company.employees.Add(new Employee("Nguyễn Văn A", 25, "0001", 2.0, new DateTime(2023, 1, 10), "Đại học")); // Làm 3 năm -> +0.3
        company.employees.Add(new Employee("Lý Thị B", 30, "0002", 2.5, new DateTime(2020, 5, 20), "Thạc sĩ")); // Làm 6 năm -> +0.6
        company.employees.Add(new Employee("Trần Văn C", 22, "0003", 1.8, new DateTime(2025, 8, 15), "Đại học")); // Làm 1 năm -> +0.0
        company.employees.Add(new Employee("Nguyễn Thị D", 28, "0004", 2.2, new DateTime(2019, 3, 1), "Cao đẳng")); // Làm 7 năm -> +0.6
        company.employees.Add(new Employee("Lê Hoàng E", 26, "0005", 2.0, new DateTime(2022, 11, 11), "Đại học")); // Làm 3 năm -> +0.3

        // In bảng lương ban đầu
        company.PrintSalaryBoard(baseSal);

        // Lưu file (Serialize)
        IFormatter formatter = new BinaryFormatter();
        using (Stream stream = new FileStream(file, FileMode.Create)) // Mở file để ghi
        {
            formatter.Serialize(stream, company); // Ghi dữ liệu công ty vào file
        }
        Console.WriteLine($"Đã lưu file {file}");

        // Đọc file (Deserialize)
        Company loadedCompany;
        using (Stream stream = new FileStream(file, FileMode.Open)) // Mở file để đọc
        {
            loadedCompany = (Company)formatter.Deserialize(stream); // Đọc dữ liệu công ty từ file và ép kiểu về Company
        }
        
        // In lại để test
        Console.WriteLine("\nDữ liệu đọc từ file:");
        loadedCompany.PrintSalaryBoard(baseSal);

        Console.ReadLine();
    }
}