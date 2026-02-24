/* 
Lab 6: Cho lớp Vector3D có các thuộc tính tọa độ: x,y và z (float)
Khai báo các operator overloading sau
1/ Toán tử trừ 1 ngôi: Đổi chiều vector. Ví dụ a(1,2,3) thì -a (-1,-2,-3)
2/ Toán tử cộng, trừ 2 vector (toán tử 2 ngôi) tương ứng với cộng và trừ 2 vector.
3/ Toán tử ! để tính module của vector (toán tử 1 ngôi)
Trong hàm main, tạo một List các vector3D và test thử các phép toán trên.
*/
public class Vector3d
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }

    public Vector3d(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    // Đổi chiều vector
    public static Vector3d operator -(Vector3d vector)
    {
        return new Vector3d(-vector.x, -vector.y, -vector.z);
    }

    // Toán tử 2 ngôi cộng 2 vector
    public static Vector3d operator +(Vector3d a, Vector3d b)
    {
        return new Vector3d(a.x + b.x, a.y + b.y, a.z + b.z);
    }
    // Toán tử 2 ngôi trừ 2 vector
    public static Vector3d operator -(Vector3d a, Vector3d b)
    {
        return new Vector3d(a.x - b.x, a.y - b.y, a.z - b.z);
    }

    // Dùng toán tử ! để tính module vector
    // Công thức: Module = Căng bậc 2 của (x^2 + y^2 + z^2)
    public static float operator !(Vector3d vector)
    {
        double sumSquare = vector.x * vector.x + vector.y * vector.y + vector.z * vector.z;
        return (float)Math.Sqrt(sumSquare);
    }

    public override string ToString()
    {
        return $"({x},{y},{z})";
    }

}