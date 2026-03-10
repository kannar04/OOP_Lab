using System.Runtime.Serialization;

[Serializable]
public class Employee : Human, ISerializable
{
    public string id { get; set; }
    public double coef_salary { get; set; } 
    public DateTime participation_date { get; set; }
    public string education_level { get; set; }

    public Employee() { }

    public Employee(string name, int age, string ide, double coef_salary, DateTime participation_date, string education_level) 
        : base(name, age)
    {
        this.id = id;
        this.coef_salary = coef_salary;
        this.participation_date = participation_date;
        this.education_level = education_level;
    }

    // Phương thức tính lương cho nhân viên
    public double CalculateSalary(double baseSalary)
    {
        // Tính số năm làm việc
        int yearsWorked = DateTime.Now.Year - participation_date.Year;
        if (DateTime.Now < participation_date.AddYears(yearsWorked)) // Nếu chưa đủ năm làm việc tròn, giảm đi 1 năm
        {
            yearsWorked--;
        }

        int increments = yearsWorked / 3; // Mỗi 3 năm tăng hệ số lương 0.3
        double currentCoef = coef_salary + (increments * 0.3);

        return currentCoef * baseSalary;
    }

    public Employee(SerializationInfo info, StreamingContext context) : base(info, context)
    {
        id = info.GetString("id");
        coef_salary = info.GetDouble("coef_salary");
        participation_date = info.GetDateTime("participation_date");
        education_level = info.GetString("education_level");
    }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context); 
        info.AddValue("id", id);
        info.AddValue("coef_salary", coef_salary);
        info.AddValue("participation_date", participation_date);
        info.AddValue("education_level", education_level);
    }

    public override string ToString()
    {
        return base.ToString() + $", Mã NV: {id}, Trình độ: {education_level}";
    }
}