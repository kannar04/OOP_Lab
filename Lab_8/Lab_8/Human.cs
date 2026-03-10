using System.Runtime.Serialization;

[Serializable]
public class Human : ISerializable
{
    public string name { get; set; }
    public int age { get; set; }

    public Human() { }

    public Human(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public Human(SerializationInfo info, StreamingContext context)
    {
        name = info.GetString("name");
        age = info.GetInt32("age");
    }

    public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("name", name);
        info.AddValue("age", age);
    }

    public override string ToString()
    {
        return $"Tên: {name}, Tuổi: {age}";
    }
}