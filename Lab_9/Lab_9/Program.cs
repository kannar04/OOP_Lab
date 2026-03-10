// Trong chương tình quản lí bán hàng trong siêu thị, có các mặt hàng sau đây cần quản lý
// Hàng tươi sống (FreshFood)
// Hàng đông lạnh (FrozenFood)
// Hàng khô (FriedFood)

// Hãy xây dựng 1 lớp abstract AGood chứa các thông tin
// AGood(id, name, price) và 1 abstract method là CalPrice để tính giá dựa trên số lượng mua 
// và đơn giá price
// Ngoài ra, lớp FreshGood còn có thuộc tính BestUsedBefore (dùng trước thời hạn này)
// và FrozenGood có thuộc tính MaxTemp (nhiệt độ bảo quản không vượt quá)
// và FriedGood có thuộc tính thời hạn sử dụng (ExpiredDate)

// Yêu cầu:
// 1. Hãy xây dựng các lớp đối tượng nói trên.
// 2. Trong lớp SuperMarket có chứa List<AGood> với các mặt hàng được sinh ngẫu nhiên.
// Hãy lựa chọn 2 dạng pattern là Singleton và FactoryDesignPattern để tích hợp vào chương trình
// 3. Hãy xây dựng chương trình thể hiện rõ 4 tính chất của OOP và giải thích
// 4. Triển khai hàm main để thực thi kết quả, trong đó, cho phpes thêm các mặt hàng được mua
// vào Giỏ hàng (Cart) và thực hiện việc thanh toán (Checkout) với số lượng hàng hóa không giới hạn 
using System.Text;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.OutputEncoding = Encoding.Unicode;
            
        Supermarket mySupermarket = Supermarket.GetInstance();

        mySupermarket.GenerateRandomInventory(5);
        mySupermarket.DisplayInventory();

        Cart customerCart = new Cart();

        if (mySupermarket.inventory.Count >= 3)
        {
            customerCart.AddToCart(mySupermarket.inventory[0], 2); // Mua 2 cái của món hàng thứ 1
            customerCart.AddToCart(mySupermarket.inventory[2], 5); // Mua 5 cái của món hàng thứ 3
            customerCart.AddToCart(mySupermarket.inventory[4], 1); // Mua 1 cái của món hàng thứ 5
        }

        // 4. Thanh toán
        customerCart.Checkout();
    }
}